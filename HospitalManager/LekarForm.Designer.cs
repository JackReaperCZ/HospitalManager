using System.ComponentModel;

namespace HospitalManager;

partial class LekarForm
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
        this.labelTitle = new System.Windows.Forms.Label();
        this.richTextBoxTitle = new System.Windows.Forms.RichTextBox();
        this.labelCode = new System.Windows.Forms.Label();
        this.buttonRemove = new System.Windows.Forms.Button();
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
        this.buttonOK.Location = new System.Drawing.Point(384, 173);
        this.buttonOK.Name = "buttonOK";
        this.buttonOK.Size = new System.Drawing.Size(135, 25);
        this.buttonOK.TabIndex = 8;
        this.buttonOK.Text = "OK";
        this.buttonOK.UseVisualStyleBackColor = true;
        // 
        // labelTitle
        // 
        this.labelTitle.Location = new System.Drawing.Point(12, 130);
        this.labelTitle.Name = "labelTitle";
        this.labelTitle.Size = new System.Drawing.Size(125, 30);
        this.labelTitle.TabIndex = 9;
        this.labelTitle.Text = "Titul";
        this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // richTextBoxTitle
        // 
        this.richTextBoxTitle.Location = new System.Drawing.Point(143, 130);
        this.richTextBoxTitle.Name = "richTextBoxTitle";
        this.richTextBoxTitle.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxTitle.TabIndex = 10;
        this.richTextBoxTitle.Text = "";
        // 
        // labelCode
        // 
        this.labelCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
        this.labelCode.Location = new System.Drawing.Point(12, 173);
        this.labelCode.Name = "labelCode";
        this.labelCode.Size = new System.Drawing.Size(145, 24);
        this.labelCode.TabIndex = 15;
        this.labelCode.Text = "CODE";
        this.labelCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // buttonRemove
        // 
        this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        this.buttonRemove.Location = new System.Drawing.Point(243, 173);
        this.buttonRemove.Name = "buttonRemove";
        this.buttonRemove.Size = new System.Drawing.Size(135, 25);
        this.buttonRemove.TabIndex = 16;
        this.buttonRemove.Text = "Odebrat";
        this.buttonRemove.UseVisualStyleBackColor = true;
        // 
        // LekarForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(531, 210);
        this.Controls.Add(this.buttonRemove);
        this.Controls.Add(this.labelCode);
        this.Controls.Add(this.richTextBoxTitle);
        this.Controls.Add(this.labelTitle);
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
        this.Name = "LekarForm";
        this.Text = "LekarForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonRemove;

    private System.Windows.Forms.Label labelCode;

    private System.Windows.Forms.RichTextBox richTextBoxTitle;

    private System.Windows.Forms.Label labelTitle;

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