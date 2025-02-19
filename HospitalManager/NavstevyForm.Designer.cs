using System.ComponentModel;

namespace HospitalManager;

partial class NavstevyForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.labelLekar = new System.Windows.Forms.Label();
        this.labelPacient = new System.Windows.Forms.Label();
        this.labelDatum = new System.Windows.Forms.Label();
        this.labelPoznamka = new System.Windows.Forms.Label();
        this.richTextBoxPoznamka = new System.Windows.Forms.RichTextBox();
        this.buttonOK = new System.Windows.Forms.Button();
        this.comboBoxLekar = new System.Windows.Forms.ComboBox();
        this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
        this.richTextBoxPacient = new System.Windows.Forms.RichTextBox();
        this.SuspendLayout();
        // 
        // labelLekar
        // 
        this.labelLekar.Location = new System.Drawing.Point(12, 10);
        this.labelLekar.Name = "labelLekar";
        this.labelLekar.Size = new System.Drawing.Size(125, 30);
        this.labelLekar.TabIndex = 0;
        this.labelLekar.Text = "Lékař";
        this.labelLekar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelPacient
        // 
        this.labelPacient.Location = new System.Drawing.Point(12, 40);
        this.labelPacient.Name = "labelPacient";
        this.labelPacient.Size = new System.Drawing.Size(125, 30);
        this.labelPacient.TabIndex = 1;
        this.labelPacient.Text = "Pacient";
        this.labelPacient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelDatum
        // 
        this.labelDatum.Location = new System.Drawing.Point(12, 70);
        this.labelDatum.Name = "labelDatum";
        this.labelDatum.Size = new System.Drawing.Size(125, 30);
        this.labelDatum.TabIndex = 2;
        this.labelDatum.Text = "Datum";
        this.labelDatum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelPoznamka
        // 
        this.labelPoznamka.Location = new System.Drawing.Point(12, 100);
        this.labelPoznamka.Name = "labelPoznamka";
        this.labelPoznamka.Size = new System.Drawing.Size(125, 30);
        this.labelPoznamka.TabIndex = 3;
        this.labelPoznamka.Text = "Poznámka";
        this.labelPoznamka.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // richTextBoxPoznamka
        // 
        this.richTextBoxPoznamka.Location = new System.Drawing.Point(143, 100);
        this.richTextBoxPoznamka.Name = "richTextBoxPoznamka";
        this.richTextBoxPoznamka.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxPoznamka.TabIndex = 7;
        this.richTextBoxPoznamka.Text = "";
        // 
        // buttonOK
        // 
        this.buttonOK.Location = new System.Drawing.Point(384, 139);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(135, 25);
        this.buttonOK.TabIndex = 8;
        this.buttonOK.Text = "OK";
        this.buttonOK.UseVisualStyleBackColor = true;
        // 
        // comboBoxLekar
        // 
        this.comboBoxLekar.FormattingEnabled = true;
        this.comboBoxLekar.Location = new System.Drawing.Point(143, 16);
        this.comboBoxLekar.Name = "comboBoxLekar";
        this.comboBoxLekar.Size = new System.Drawing.Size(376, 21);
        this.comboBoxLekar.TabIndex = 9;
        // 
        // dateTimePicker
        // 
        this.dateTimePicker.Location = new System.Drawing.Point(143, 76);
        this.dateTimePicker.Name = "dateTimePicker";
        this.dateTimePicker.Size = new System.Drawing.Size(376, 20);
        this.dateTimePicker.TabIndex = 14;
        // 
        // richTextBoxPacient
        // 
        this.richTextBoxPacient.Enabled = false;
        this.richTextBoxPacient.Location = new System.Drawing.Point(143, 40);
        this.richTextBoxPacient.Name = "richTextBoxPacient";
        this.richTextBoxPacient.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxPacient.TabIndex = 15;
        this.richTextBoxPacient.Text = "";
        // 
        // NavstevyForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(531, 176);
        this.Controls.Add(this.richTextBoxPacient);
        this.Controls.Add(this.dateTimePicker);
        this.Controls.Add(this.comboBoxLekar);
        this.Controls.Add(this.buttonOK);
        this.Controls.Add(this.richTextBoxPoznamka);
        this.Controls.Add(this.labelPoznamka);
        this.Controls.Add(this.labelDatum);
        this.Controls.Add(this.labelPacient);
        this.Controls.Add(this.labelLekar);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "NavstevyForm";
        this.Text = "NavstevyForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox richTextBoxPacient;

    private System.Windows.Forms.DateTimePicker dateTimePicker;

    private System.Windows.Forms.ComboBox comboBoxLekar;

    private System.Windows.Forms.Button buttonOK;

    private System.Windows.Forms.RichTextBox richTextBoxPoznamka;

    private System.Windows.Forms.Label labelPoznamka;

    private System.Windows.Forms.Label labelPacient;
    private System.Windows.Forms.Label labelDatum;

    private System.Windows.Forms.Label labelLekar;

    #endregion
}