using System.ComponentModel;

namespace HospitalManager;

partial class PredpisForm
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
        this.labelLek = new System.Windows.Forms.Label();
        this.labelVyrobce = new System.Windows.Forms.Label();
        this.richTextBoxDavka = new System.Windows.Forms.RichTextBox();
        this.buttonOK = new System.Windows.Forms.Button();
        this.comboBoxLekar = new System.Windows.Forms.ComboBox();
        this.comboBoxLek = new System.Windows.Forms.ComboBox();
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
        // labelLek
        // 
        this.labelLek.Location = new System.Drawing.Point(12, 70);
        this.labelLek.Name = "labelLek";
        this.labelLek.Size = new System.Drawing.Size(125, 30);
        this.labelLek.TabIndex = 2;
        this.labelLek.Text = "Lék";
        this.labelLek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelVyrobce
        // 
        this.labelVyrobce.Location = new System.Drawing.Point(12, 100);
        this.labelVyrobce.Name = "labelVyrobce";
        this.labelVyrobce.Size = new System.Drawing.Size(125, 30);
        this.labelVyrobce.TabIndex = 3;
        this.labelVyrobce.Text = "Dávka";
        this.labelVyrobce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // richTextBoxDavka
        // 
        this.richTextBoxDavka.Location = new System.Drawing.Point(143, 100);
        this.richTextBoxDavka.Name = "richTextBoxDavka";
        this.richTextBoxDavka.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxDavka.TabIndex = 7;
        this.richTextBoxDavka.Text = "";
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
        // comboBoxLek
        // 
        this.comboBoxLek.FormattingEnabled = true;
        this.comboBoxLek.Location = new System.Drawing.Point(143, 73);
        this.comboBoxLek.Name = "comboBoxLek";
        this.comboBoxLek.Size = new System.Drawing.Size(376, 21);
        this.comboBoxLek.TabIndex = 11;
        // 
        // richTextBoxPacient
        // 
        this.richTextBoxPacient.Location = new System.Drawing.Point(143, 40);
        this.richTextBoxPacient.Name = "richTextBoxPacient";
        this.richTextBoxPacient.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxPacient.TabIndex = 13;
        this.richTextBoxPacient.Text = "";
        // 
        // PredpisForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(531, 176);
        this.Controls.Add(this.richTextBoxPacient);
        this.Controls.Add(this.comboBoxLek);
        this.Controls.Add(this.comboBoxLekar);
        this.Controls.Add(this.buttonOK);
        this.Controls.Add(this.richTextBoxDavka);
        this.Controls.Add(this.labelVyrobce);
        this.Controls.Add(this.labelLek);
        this.Controls.Add(this.labelPacient);
        this.Controls.Add(this.labelLekar);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "PredpisForm";
        this.Text = "PredpisForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox richTextBoxPacient;

    private System.Windows.Forms.ComboBox comboBoxLekar;
    private System.Windows.Forms.ComboBox comboBoxLek;

    private System.Windows.Forms.Button buttonOK;

    private System.Windows.Forms.RichTextBox richTextBoxDavka;

    private System.Windows.Forms.Label labelVyrobce;

    private System.Windows.Forms.Label labelPacient;
    private System.Windows.Forms.Label labelLek;

    private System.Windows.Forms.Label labelLekar;

    #endregion
}