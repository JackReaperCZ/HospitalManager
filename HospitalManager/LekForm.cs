using System;
using System.Windows.Forms;

namespace HospitalManager;

/// <summary>
/// Represents a form for managing medication information.
/// </summary>
public partial class LekForm : Form
{
    private Lek _lek;

    /// <summary>
    /// Initializes a new instance of the <see cref="LekForm"/> class.
    /// </summary>
    /// <param name="lek">The medication object to be displayed and edited.</param>
    public LekForm(Lek lek)
    {
        InitializeComponent();

        if (lek != null)
        {
            _lek = lek;
            this.richTextBoxName.Text = lek.Name;
            this.richTextBoxCena.Text = lek.Cena.ToString();
            this.richTextBoxPopis.Text = lek.Popis;
            this.richTextBoxVyrobce.Text = lek.Vyrobce;   

            buttonRemove.Visible = true;

            buttonRemove.Click += (sender, args) =>
            {
                Lek.Delete(lek);

                MainForm.Instance.Refresh();
                Hide();
            };
        }

        buttonOK.Click += OkButtonClick;
    }

    /// <summary>
    /// Handles the OK button click event to submit or update medication information.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
    private void OkButtonClick(object sender, EventArgs e)
    {
        try
        {
            int cena = int.Parse(richTextBoxCena.Text);
        }
        catch (Exception exception)
        {
            MessageBox.Show("Cena musí být číclo.");
            return;
        }

        if (_lek == null)
        {
            Random r = new Random();

            Lek.Submit(new Lek(-1, richTextBoxName.Text, int.Parse(richTextBoxCena.Text), richTextBoxPopis.Text, richTextBoxVyrobce.Text));
        }
        else
        {
            Lek.Submit(new Lek(_lek.ID, richTextBoxName.Text, int.Parse(richTextBoxCena.Text), richTextBoxPopis.Text, richTextBoxVyrobce.Text));
        }

        MainForm.Instance.Refresh();
        Hide();
    }
}