using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManager;

/// <summary>
/// Form for creating and submitting a new prescription.
/// </summary>
public partial class PredpisForm : Form
{
    /// <summary>
    /// Gets or sets the patient associated with the prescription.
    /// </summary>
    private Pacient Pacient { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="PredpisForm"/> class.
    /// </summary>
    /// <param name="pacient">The patient for whom the prescription is being created.</param>
    public PredpisForm(Pacient pacient)
    {
        InitializeComponent();

        richTextBoxPacient.Text = $"{pacient.Jmeno} {pacient.Prijmeni}";

        List<Lekar> lekars = Lekar.GetAll();
        List<Lek> leky = Lek.GetAll();

        Pacient = pacient;

        comboBoxLekar.DataSource = lekars;
        comboBoxLekar.DisplayMember = "ToString";

        comboBoxLek.DataSource = leky;
        comboBoxLek.DisplayMember = "Name";

        buttonOK.Click += OkButtonClick;
    }

    /// <summary>
    /// Handles the click event for the OK button to submit a prescription.
    /// </summary>
    private void OkButtonClick(object sender, EventArgs e)
    {
        Lekar lekar = (Lekar)comboBoxLekar.SelectedItem;
        Lek lek = (Lek)comboBoxLek.SelectedItem;

        Predpis.Submit(new Predpis(-1, lekar, Pacient, lek, int.Parse(richTextBoxDavka.Text)));

        MainForm.Instance.Refresh();
        Hide();
    }
}
