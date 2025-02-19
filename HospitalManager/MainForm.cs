using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.Json;

namespace HospitalManager
{
    /// <summary>
    /// Represents the main form of the Hospital Manager application.
    /// </summary>
    public partial class MainForm : Form
    {
        private PANEL selectedPANEL = PANEL.Def;
        private DataGridViewCellEventHandler currentCellDoubleClickHandler;
        public static MainForm Instance;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            LekariButtonClick(this, EventArgs.Empty);

            this.buttonLekari.Click += LekariButtonClick;
            this.buttonPacienti.Click += PacientiButtonClick;
            this.buttonLeky.Click += LekyButtonClick;
            this.buttonAdd.Click += AddButtonClick;
            this.buttonImport.Click += ImportButtonClick;
            
            Instance = this;
        }

        /// <summary>
        /// Handles the Pacienti button click event to display patient data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void PacientiButtonClick(object sender, EventArgs e)
        {
            if (selectedPANEL == PANEL.Pacient) return;

            selectedPANEL = PANEL.Pacient;

            dataGridView.Rows.Clear();

            List<Pacient> pacienti = Pacient.GetAll();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = pacienti;
            dataGridView.DataSource = bindingSource;

            dataGridView.Columns["ID"].Visible = false;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CleanEvents();

            currentCellDoubleClickHandler = (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    Pacient selected = (Pacient)dataGridView.Rows[e.RowIndex].DataBoundItem;
                    PacientForm form = new PacientForm(selected);
                    form.Show();
                }
            };

            dataGridView.CellDoubleClick += currentCellDoubleClickHandler;
        }

        /// <summary>
        /// Handles the Lekari button click event to display doctor data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void LekariButtonClick(object sender, EventArgs e)
        {
            if (selectedPANEL == PANEL.Lekar) return;

            selectedPANEL = PANEL.Lekar;

            dataGridView.Rows.Clear();

            List<Lekar> lekars = Lekar.GetAll();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lekars;
            dataGridView.DataSource = bindingSource;

            dataGridView.Columns["ID"].Visible = false;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CleanEvents();

            currentCellDoubleClickHandler = (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    Lekar selected = (Lekar)dataGridView.Rows[e.RowIndex].DataBoundItem;
                    LekarForm form = new LekarForm(selected);
                    form.Show();
                }
            };

            dataGridView.CellDoubleClick += currentCellDoubleClickHandler;
        }

        /// <summary>
        /// Handles the Leky button click event to display medication data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void LekyButtonClick(object sender, EventArgs e)
        {
            if (selectedPANEL == PANEL.Lek) return;

            selectedPANEL = PANEL.Lek;

            dataGridView.Rows.Clear();

            List<Lek> leky = Lek.GetAll();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = leky;
            dataGridView.DataSource = bindingSource;

            dataGridView.Columns["ID"].Visible = false;

            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            CleanEvents();

            currentCellDoubleClickHandler = (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    Lek selected = (Lek)dataGridView.Rows[e.RowIndex].DataBoundItem;
                    LekForm form = new LekForm(selected);
                    form.Show();
                }
            };

            dataGridView.CellDoubleClick += currentCellDoubleClickHandler;
        }

        /// <summary>
        /// Handles the Add button click event to add a new record based on the selected panel.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void AddButtonClick(object sender, EventArgs e)
        {
            switch (selectedPANEL)
            {
                case PANEL.Pacient:
                    PacientForm formp = new PacientForm(null);
                    formp.Show();
                    break;
                case PANEL.Lek:
                    LekForm forml = new LekForm(null);
                    forml.Show();
                    break;
                case PANEL.Lekar:
                    LekarForm formlek = new LekarForm(null);
                    formlek.Show();
                    break;
                default:
                    return;
            }
        }

        private void ImportButtonClick(object sender, EventArgs e)
        {
            // Open File Dialog to Select JSON File
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                openFileDialog.Title = "Select a JSON File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonContent = File.ReadAllText(openFileDialog.FileName);

                        using JsonDocument doc = JsonDocument.Parse(jsonContent);
                        JsonElement root = doc.RootElement;

                        switch (selectedPANEL)
                        {
                            case PANEL.Pacient:
                                Pacient pacient = new Pacient(
                                    -1,
                                    root.GetProperty("jmeno").GetString(),
                                    root.GetProperty("prijmeni").GetString(),
                                    root.GetProperty("email").GetString(),
                                    root.GetProperty("telefon").GetInt32(),
                                    root.GetProperty("datum_nar").GetDateTime()
                                );

                                Pacient.Submit(pacient);
                                
                                Refresh();
                                break;
                            case PANEL.Lek:
                                Lek lek = new Lek(
                                    -1,
                                    root.GetProperty("nazev").GetString(),
                                    (float)root.GetProperty("cena").GetDecimal(),
                                    root.GetProperty("popis").GetString(),
                                    root.GetProperty("vyrobce").GetString()
                                );

                                Lek.Submit(lek);
                                
                                Refresh();
                                break;
                            case PANEL.Lekar:
                                Lekar lekar = new Lekar(
                                    -1,
                                    root.GetProperty("kod").GetInt32(),
                                    root.GetProperty("titul").GetString(),
                                    root.GetProperty("jmeno").GetString(),
                                    root.GetProperty("prijmeni").GetString(),
                                    root.GetProperty("email").GetString(),
                                    root.GetProperty("telefon").GetInt32()
                                );
                                Lekar.Submit(lekar);
                                
                                Refresh();
                                break;
                            default:
                                return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"JSON struktura neplatná. Prosím zkontrolujte ji podle dokumentace.");
                    }
                }
            }
        }

        /// <summary>
        /// Refreshes the data displayed in the current panel.
        /// </summary>
        public void Refresh()
        {
            switch (selectedPANEL)
            {
                case PANEL.Pacient:
                    selectedPANEL = PANEL.Def;
                    PacientiButtonClick(null, EventArgs.Empty);
                    break;
                case PANEL.Lek:
                    selectedPANEL = PANEL.Def;
                    LekyButtonClick(null, EventArgs.Empty);
                    break;
                case PANEL.Lekar:
                    selectedPANEL = PANEL.Def;
                    LekariButtonClick(null, EventArgs.Empty);
                    break;
                default:
                    return;
            }
        }

        /// <summary>
        /// Removes event handlers from the DataGridView to prevent duplication.
        /// </summary>
        private void CleanEvents()
        {
            if (currentCellDoubleClickHandler != null)
            {
                dataGridView.CellDoubleClick -= currentCellDoubleClickHandler;
            }
        }
    }

    /// <summary>
    /// Enum representing the different panels available in the MainForm.
    /// </summary>
    public enum PANEL
    {
        Def,
        Lekar,
        Lek,
        Pacient
    }
}