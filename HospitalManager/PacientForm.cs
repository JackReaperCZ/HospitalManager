using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManager;

/// <summary>
/// Form for managing patient information, visits, and prescriptions.
/// </summary>
public partial class PacientForm : Form
{
    /// <summary>
    /// Gets or sets the patient associated with the form.
    /// </summary>
    private Pacient Pacient { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PacientForm"/> class.
    /// </summary>
    /// <param name="pacient">The patient to be displayed or edited.</param>
    public PacientForm(Pacient pacient)
    {
        InitializeComponent();

        if (pacient != null)
        {
            Pacient = pacient;

            // Populate patient information fields.
            richTextBoxJmeno.Text = pacient.Jmeno;
            richTextBoxPrijmeni.Text = pacient.Prijmeni;
            richTextBoxEmail.Text = pacient.Email;
            richTextBoxTel.Text = pacient.Telefon.ToString();
            richTextBoxBirthday.Text = pacient.Birthday.ToLongDateString();

            // Set up visits DataGridView.
            dataGridViewNavstevy.ColumnCount = 3;
            dataGridViewNavstevy.Columns[0].Name = "Lékař";
            dataGridViewNavstevy.Columns[1].Name = "Datum";
            dataGridViewNavstevy.Columns[2].Name = "Poznámka";
            dataGridViewNavstevy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<Navstevy> navstevy = Navstevy.GetAll(pacient);

            foreach (Navstevy nav in navstevy)
            {
                dataGridViewNavstevy.Rows.Add(nav.Lekar.ToString(), nav.Datum.ToLongDateString(), nav.Poznamka);
            }

            // Set up prescriptions DataGridView.
            dataGridViewPredpisy.ColumnCount = 3;
            dataGridViewPredpisy.Columns[0].Name = "Lékař";
            dataGridViewPredpisy.Columns[1].Name = "Lék";
            dataGridViewPredpisy.Columns[2].Name = "Dávka";
            dataGridViewPredpisy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            List<Predpis> predpisy = Predpis.GetAll(pacient);

            foreach (Predpis pre in predpisy)
            {
                dataGridViewPredpisy.Rows.Add(pre.Lekar.ToString(), pre.Lek.Name, pre.Davka);
            }

            // Enable buttons for adding visits and prescriptions.
            buttonAddNavsteva.Visible = true;
            buttonAddPredpis.Visible = true;

            buttonAddPredpis.Click += AddPredpisClick;
            buttonAddNavsteva.Click += AddNavstevyClick;

            // Enable and handle the remove button.
            buttonRemove.Visible = true;

            buttonRemove.Click += (sender, args) =>
            {
                Pacient.Delete(pacient);

                MainForm.Instance.Refresh();
                Hide();
            };
        }

        // Handle the OK button click event.
        buttonOK.Click += OkButtonClick;
    }

    /// <summary>
    /// Opens the form to add a new patient visit.
    /// </summary>
    private void AddNavstevyClick(object sender, EventArgs e)
    {
        NavstevyForm navstevyForm = new NavstevyForm(Pacient);
        navstevyForm.Show();

        MainForm.Instance.Refresh();
        Hide();
    }

    /// <summary>
    /// Opens the form to add a new prescription for the patient.
    /// </summary>
    private void AddPredpisClick(object sender, EventArgs e)
    {
        PredpisForm predpisForm = new PredpisForm(Pacient);
        predpisForm.Show();

        MainForm.Instance.Refresh();
        Hide();
    }

    /// <summary>
    /// Validates and submits patient information.
    /// </summary>
    private void OkButtonClick(object sender, EventArgs e)
    {
        try
        {
            // Validate phone number.
            int tel = int.Parse(richTextBoxTel.Text);
            if (!(tel >= 100000000 && tel <= 999999999)) throw new Exception();
        }
        catch (Exception)
        {
            MessageBox.Show("Číslo musí obsahovat 9 číslic bez mezer.");
            return;
        }

        try
        {
            // Validate birthday format.
            DateTime.Parse(richTextBoxBirthday.Text);
        }
        catch (Exception)
        {
            MessageBox.Show("Datum zadejte ve formátu YYYY-MM-DD.");
            return;
        }

        // Submit or update patient data.
        if (Pacient == null)
        {
            Pacient.Submit(new Pacient(-1, richTextBoxJmeno.Text, richTextBoxPrijmeni.Text,
                richTextBoxEmail.Text, int.Parse(richTextBoxTel.Text), DateTime.Parse(richTextBoxBirthday.Text)));
        }
        else
        {
            Pacient.Submit(new Pacient(Pacient.ID, richTextBoxJmeno.Text, richTextBoxPrijmeni.Text,
                richTextBoxEmail.Text, int.Parse(richTextBoxTel.Text), DateTime.Parse(richTextBoxBirthday.Text)));
        }

        MainForm.Instance.Refresh();
        Hide();
    }
}
