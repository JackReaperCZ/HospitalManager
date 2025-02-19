using System.ComponentModel;

namespace HospitalManager;

partial class PacientForm
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
        this.labelJmeno = new System.Windows.Forms.Label();
        this.labelPrijmeni = new System.Windows.Forms.Label();
        this.labelEmail = new System.Windows.Forms.Label();
        this.labelTel = new System.Windows.Forms.Label();
        this.richTextBoxJmeno = new System.Windows.Forms.RichTextBox();
        this.richTextBoxPrijmeni = new System.Windows.Forms.RichTextBox();
        this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
        this.richTextBoxTel = new System.Windows.Forms.RichTextBox();
        this.buttonOK = new System.Windows.Forms.Button();
        this.labelBirthday = new System.Windows.Forms.Label();
        this.richTextBoxBirthday = new System.Windows.Forms.RichTextBox();
        this.panelPredpisy = new System.Windows.Forms.Panel();
        this.buttonAddPredpis = new System.Windows.Forms.Button();
        this.dataGridViewPredpisy = new System.Windows.Forms.DataGridView();
        this.panelNavstevy = new System.Windows.Forms.Panel();
        this.buttonAddNavsteva = new System.Windows.Forms.Button();
        this.dataGridViewNavstevy = new System.Windows.Forms.DataGridView();
        this.labelPredpisy = new System.Windows.Forms.Label();
        this.labelNavstevy = new System.Windows.Forms.Label();
        this.buttonRemove = new System.Windows.Forms.Button();
        this.panelPredpisy.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredpisy)).BeginInit();
        this.panelNavstevy.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNavstevy)).BeginInit();
        this.SuspendLayout();
        // 
        // labelJmeno
        // 
        this.labelJmeno.Location = new System.Drawing.Point(12, 10);
        this.labelJmeno.Name = "labelJmeno";
        this.labelJmeno.Size = new System.Drawing.Size(125, 30);
        this.labelJmeno.TabIndex = 0;
        this.labelJmeno.Text = "Jméno";
        this.labelJmeno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelPrijmeni
        // 
        this.labelPrijmeni.Location = new System.Drawing.Point(12, 40);
        this.labelPrijmeni.Name = "labelPrijmeni";
        this.labelPrijmeni.Size = new System.Drawing.Size(125, 30);
        this.labelPrijmeni.TabIndex = 1;
        this.labelPrijmeni.Text = "Příjmení";
        this.labelPrijmeni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelEmail
        // 
        this.labelEmail.Location = new System.Drawing.Point(12, 70);
        this.labelEmail.Name = "labelEmail";
        this.labelEmail.Size = new System.Drawing.Size(125, 30);
        this.labelEmail.TabIndex = 2;
        this.labelEmail.Text = "Email";
        this.labelEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelTel
        // 
        this.labelTel.Location = new System.Drawing.Point(12, 100);
        this.labelTel.Name = "labelTel";
        this.labelTel.Size = new System.Drawing.Size(125, 30);
        this.labelTel.TabIndex = 3;
        this.labelTel.Text = "Telefon";
        this.labelTel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // richTextBoxJmeno
        // 
        this.richTextBoxJmeno.Location = new System.Drawing.Point(143, 10);
        this.richTextBoxJmeno.Name = "richTextBoxJmeno";
        this.richTextBoxJmeno.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxJmeno.TabIndex = 4;
        this.richTextBoxJmeno.Text = "";
        // 
        // richTextBoxPrijmeni
        // 
        this.richTextBoxPrijmeni.Location = new System.Drawing.Point(143, 40);
        this.richTextBoxPrijmeni.Name = "richTextBoxPrijmeni";
        this.richTextBoxPrijmeni.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxPrijmeni.TabIndex = 5;
        this.richTextBoxPrijmeni.Text = "";
        // 
        // richTextBoxEmail
        // 
        this.richTextBoxEmail.Location = new System.Drawing.Point(143, 70);
        this.richTextBoxEmail.Name = "richTextBoxEmail";
        this.richTextBoxEmail.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxEmail.TabIndex = 6;
        this.richTextBoxEmail.Text = "";
        // 
        // richTextBoxTel
        // 
        this.richTextBoxTel.Location = new System.Drawing.Point(143, 100);
        this.richTextBoxTel.Name = "richTextBoxTel";
        this.richTextBoxTel.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxTel.TabIndex = 7;
        this.richTextBoxTel.Text = "";
        // 
        // buttonOK
        // 
        this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonOK.Location = new System.Drawing.Point(384, 800);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(135, 25);
        this.buttonOK.TabIndex = 8;
        this.buttonOK.Text = "OK";
        this.buttonOK.UseVisualStyleBackColor = true;
        // 
        // labelBirthday
        // 
        this.labelBirthday.Location = new System.Drawing.Point(12, 130);
        this.labelBirthday.Name = "labelBirthday";
        this.labelBirthday.Size = new System.Drawing.Size(125, 30);
        this.labelBirthday.TabIndex = 9;
        this.labelBirthday.Text = "Dat. Nar.";
        this.labelBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // richTextBoxBirthday
        // 
        this.richTextBoxBirthday.Location = new System.Drawing.Point(143, 130);
        this.richTextBoxBirthday.Name = "richTextBoxBirthday";
        this.richTextBoxBirthday.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxBirthday.TabIndex = 10;
        this.richTextBoxBirthday.Text = "";
        // 
        // panelPredpisy
        // 
        this.panelPredpisy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.panelPredpisy.AutoScroll = true;
        this.panelPredpisy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panelPredpisy.Controls.Add(this.buttonAddPredpis);
        this.panelPredpisy.Controls.Add(this.dataGridViewPredpisy);
        this.panelPredpisy.Location = new System.Drawing.Point(12, 214);
        this.panelPredpisy.Name = "panelPredpisy";
        this.panelPredpisy.Size = new System.Drawing.Size(507, 264);
        this.panelPredpisy.TabIndex = 11;
        // 
        // buttonAddPredpis
        // 
        this.buttonAddPredpis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonAddPredpis.Location = new System.Drawing.Point(455, 213);
        this.buttonAddPredpis.Name = "buttonAddPredpis";
        this.buttonAddPredpis.Size = new System.Drawing.Size(45, 45);
        this.buttonAddPredpis.TabIndex = 1;
        this.buttonAddPredpis.Text = "Nový";
        this.buttonAddPredpis.UseVisualStyleBackColor = true;
        this.buttonAddPredpis.Visible = false;
        // 
        // dataGridViewPredpisy
        // 
        this.dataGridViewPredpisy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewPredpisy.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridViewPredpisy.Location = new System.Drawing.Point(0, 0);
        this.dataGridViewPredpisy.Name = "dataGridViewPredpisy";
        this.dataGridViewPredpisy.Size = new System.Drawing.Size(505, 262);
        this.dataGridViewPredpisy.TabIndex = 0;
        // 
        // panelNavstevy
        // 
        this.panelNavstevy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.panelNavstevy.AutoScroll = true;
        this.panelNavstevy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.panelNavstevy.Controls.Add(this.buttonAddNavsteva);
        this.panelNavstevy.Controls.Add(this.dataGridViewNavstevy);
        this.panelNavstevy.Location = new System.Drawing.Point(12, 525);
        this.panelNavstevy.Name = "panelNavstevy";
        this.panelNavstevy.Size = new System.Drawing.Size(507, 264);
        this.panelNavstevy.TabIndex = 12;
        // 
        // buttonAddNavsteva
        // 
        this.buttonAddNavsteva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonAddNavsteva.Location = new System.Drawing.Point(455, 214);
        this.buttonAddNavsteva.Name = "buttonAddNavsteva";
        this.buttonAddNavsteva.Size = new System.Drawing.Size(45, 45);
        this.buttonAddNavsteva.TabIndex = 1;
        this.buttonAddNavsteva.Text = "Nový";
        this.buttonAddNavsteva.UseVisualStyleBackColor = true;
        this.buttonAddNavsteva.Visible = false;
        // 
        // dataGridViewNavstevy
        // 
        this.dataGridViewNavstevy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewNavstevy.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridViewNavstevy.Location = new System.Drawing.Point(0, 0);
        this.dataGridViewNavstevy.Name = "dataGridViewNavstevy";
        this.dataGridViewNavstevy.Size = new System.Drawing.Size(505, 262);
        this.dataGridViewNavstevy.TabIndex = 0;
        // 
        // labelPredpisy
        // 
        this.labelPredpisy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.labelPredpisy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.labelPredpisy.Location = new System.Drawing.Point(12, 170);
        this.labelPredpisy.Name = "labelPredpisy";
        this.labelPredpisy.Size = new System.Drawing.Size(507, 41);
        this.labelPredpisy.TabIndex = 13;
        this.labelPredpisy.Text = "Předpisy";
        this.labelPredpisy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelNavstevy
        // 
        this.labelNavstevy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
        this.labelNavstevy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.labelNavstevy.Location = new System.Drawing.Point(12, 481);
        this.labelNavstevy.Name = "labelNavstevy";
        this.labelNavstevy.Size = new System.Drawing.Size(507, 41);
        this.labelNavstevy.TabIndex = 14;
        this.labelNavstevy.Text = "Návštěvy";
        this.labelNavstevy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // buttonRemove
        // 
        this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonRemove.Location = new System.Drawing.Point(13, 800);
        this.buttonRemove.Name = "buttonRemove";
        this.buttonRemove.Size = new System.Drawing.Size(135, 25);
        this.buttonRemove.TabIndex = 15;
        this.buttonRemove.Text = "Odebrat";
        this.buttonRemove.UseVisualStyleBackColor = true;
        this.buttonRemove.Visible = false;
        // 
        // PacientForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(531, 837);
        this.Controls.Add(this.buttonRemove);
        this.Controls.Add(this.labelNavstevy);
        this.Controls.Add(this.labelPredpisy);
        this.Controls.Add(this.panelNavstevy);
        this.Controls.Add(this.panelPredpisy);
        this.Controls.Add(this.richTextBoxBirthday);
        this.Controls.Add(this.labelBirthday);
        this.Controls.Add(this.buttonOK);
        this.Controls.Add(this.richTextBoxTel);
        this.Controls.Add(this.richTextBoxEmail);
        this.Controls.Add(this.richTextBoxPrijmeni);
        this.Controls.Add(this.richTextBoxJmeno);
        this.Controls.Add(this.labelTel);
        this.Controls.Add(this.labelEmail);
        this.Controls.Add(this.labelPrijmeni);
        this.Controls.Add(this.labelJmeno);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "PacientForm";
        this.Text = "PacientForm";
        this.panelPredpisy.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPredpisy)).EndInit();
        this.panelNavstevy.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNavstevy)).EndInit();
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonRemove;

    private System.Windows.Forms.Button buttonAddPredpis;
    private System.Windows.Forms.Button buttonAddNavsteva;

    private System.Windows.Forms.DataGridView dataGridViewPredpisy;

    private System.Windows.Forms.DataGridView dataGridViewNavstevy;

    private System.Windows.Forms.Panel panelPredpisy;
    private System.Windows.Forms.Label labelNavstevy;

    private System.Windows.Forms.Label labelPredpisy;

    private System.Windows.Forms.RichTextBox richTextBoxBirthday;
    private System.Windows.Forms.Panel panelNavstevy;

    private System.Windows.Forms.Label labelBirthday;

    private System.Windows.Forms.Button buttonOK;

    private System.Windows.Forms.RichTextBox richTextBoxJmeno;
    private System.Windows.Forms.RichTextBox richTextBoxPrijmeni;
    private System.Windows.Forms.RichTextBox richTextBoxEmail;
    private System.Windows.Forms.RichTextBox richTextBoxTel;

    private System.Windows.Forms.Label labelTel;

    private System.Windows.Forms.Label labelPrijmeni;
    private System.Windows.Forms.Label labelEmail;

    private System.Windows.Forms.Label labelJmeno;

    #endregion
}