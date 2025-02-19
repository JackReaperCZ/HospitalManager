using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalManager;

/// <summary>
/// Form for managing patient visits.
/// </summary>
public partial class NavstevyForm : Form
{
    /// <summary>
    /// Gets or sets the patient associated with the visit.
    /// </summary>
    private Pacient Pacient { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NavstevyForm"/> class.
    /// </summary>
    /// <param name="pacient">The patient for whom the visit is being recorded.</param>
    public NavstevyForm(Pacient pacient)
    {
        InitializeComponent();

        // Display patient name in the rich text box.
        richTextBoxPacient.Text = $"{pacient.Jmeno} {pacient.Prijmeni}";

        // Retrieve and bind all doctors to the combo box.
        List<Lekar> lekars = Lekar.GetAll();

        Pacient = pacient;

        comboBoxLekar.DataSource = lekars;
        comboBoxLekar.DisplayMember = "ToString";

        // Attach event handler to the OK button.
        buttonOK.Click += OkButtonClick;
    }

    /// <summary>
    /// Handles the click event for the OK button to submit a visit record.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">Event data.</param>
    private void OkButtonClick(object sender, EventArgs e)
    {
        // Get the selected doctor from the combo box.
        Lekar lekar = (Lekar)comboBoxLekar.SelectedItem;

        // Submit the visit record to the database.
        Navstevy.Submit(new Navstevy(-1, Pacient, lekar, dateTimePicker.Value.Date, richTextBoxPoznamka.Text));

        // Refresh the main form and hide the current form.
        MainForm.Instance.Refresh();
        Hide();
    }
}