using System;
using System.Windows.Forms;

namespace HospitalManager;

/// <summary>
/// Represents a form for adding or editing a doctor (Lekar).
/// </summary>
public partial class LekarForm : Form
{
    /// <summary>
    /// Gets or sets the doctor object associated with the form.
    /// </summary>
    private Lekar LekarObj { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LekarForm"/> class.
    /// </summary>
    /// <param name="lekar">The doctor object to be edited. If null, a new doctor will be created.</param>
    public LekarForm(Lekar lekar)
    {
        InitializeComponent();

        if (lekar != null)
        {
            LekarObj = lekar;
            richTextBoxJmeno.Text = lekar.Jmeno;
            richTextBoxPrijmeni.Text = lekar.Prijmeni;
            richTextBoxEmail.Text = lekar.Email;
            richTextBoxTitle.Text = lekar.Title;
            richTextBoxTel.Text = lekar.Telefon.ToString();

            labelCode.Text = lekar.Code.ToString();
            
            buttonRemove.Visible = true;
            
            buttonRemove.Click += (sender, args) =>
            {
                Lekar.Delete(lekar);
                
                MainForm.Instance.Refresh();
                Hide();
            };
        }
        else
        {
            labelCode.Text = "";
        }

        buttonOK.Click += OkButtonClick;
    }

    /// <summary>
    /// Handles the OK button click event to save or update the doctor record.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void OkButtonClick(object sender, EventArgs e)
    {
        try
        {
            int tel = int.Parse(richTextBoxTel.Text);
            if (!(tel >= 100000000 && tel <= 999999999)) throw new Exception();
        }
        catch (Exception exception)
        {
            MessageBox.Show("Číslo musí obsahovat 9 číslic bez mezer.");
            return;
        }

        if (LekarObj == null)
        {
            Random r = new Random();

            Lekar.Submit(new Lekar(-1, r.Next(999), richTextBoxTitle.Text, richTextBoxJmeno.Text, richTextBoxPrijmeni.Text,
                richTextBoxEmail.Text, int.Parse(richTextBoxTel.Text)));
        }
        else
        {
            Lekar.Submit(new Lekar(LekarObj.ID, LekarObj.Code, richTextBoxTitle.Text, richTextBoxJmeno.Text, richTextBoxPrijmeni.Text,
                richTextBoxEmail.Text, int.Parse(richTextBoxTel.Text)));
        }
        
        MainForm.Instance.Refresh();
        Hide();
    }
}