using System.ComponentModel;

namespace HospitalManager;

partial class LekForm
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
        this.labelName = new System.Windows.Forms.Label();
        this.labelCena = new System.Windows.Forms.Label();
        this.labelPopis = new System.Windows.Forms.Label();
        this.labelVyrobce = new System.Windows.Forms.Label();
        this.richTextBoxName = new System.Windows.Forms.RichTextBox();
        this.richTextBoxCena = new System.Windows.Forms.RichTextBox();
        this.richTextBoxPopis = new System.Windows.Forms.RichTextBox();
        this.richTextBoxVyrobce = new System.Windows.Forms.RichTextBox();
        this.buttonOK = new System.Windows.Forms.Button();
        this.buttonRemove = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // labelName
        // 
        this.labelName.Location = new System.Drawing.Point(12, 10);
        this.labelName.Name = "labelName";
        this.labelName.Size = new System.Drawing.Size(125, 30);
        this.labelName.TabIndex = 0;
        this.labelName.Text = "Název";
        this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelCena
        // 
        this.labelCena.Location = new System.Drawing.Point(12, 40);
        this.labelCena.Name = "labelCena";
        this.labelCena.Size = new System.Drawing.Size(125, 30);
        this.labelCena.TabIndex = 1;
        this.labelCena.Text = "Cena";
        this.labelCena.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelPopis
        // 
        this.labelPopis.Location = new System.Drawing.Point(12, 70);
        this.labelPopis.Name = "labelPopis";
        this.labelPopis.Size = new System.Drawing.Size(125, 30);
        this.labelPopis.TabIndex = 2;
        this.labelPopis.Text = "Popis";
        this.labelPopis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // labelVyrobce
        // 
        this.labelVyrobce.Location = new System.Drawing.Point(12, 100);
        this.labelVyrobce.Name = "labelVyrobce";
        this.labelVyrobce.Size = new System.Drawing.Size(125, 30);
        this.labelVyrobce.TabIndex = 3;
        this.labelVyrobce.Text = "Výrobce";
        this.labelVyrobce.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // richTextBoxName
        // 
        this.richTextBoxName.Location = new System.Drawing.Point(143, 10);
        this.richTextBoxName.Name = "richTextBoxName";
        this.richTextBoxName.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxName.TabIndex = 4;
        this.richTextBoxName.Text = "";
        // 
        // richTextBoxCena
        // 
        this.richTextBoxCena.Location = new System.Drawing.Point(143, 40);
        this.richTextBoxCena.Name = "richTextBoxCena";
        this.richTextBoxCena.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxCena.TabIndex = 5;
        this.richTextBoxCena.Text = "";
        // 
        // richTextBoxPopis
        // 
        this.richTextBoxPopis.Location = new System.Drawing.Point(143, 70);
        this.richTextBoxPopis.Name = "richTextBoxPopis";
        this.richTextBoxPopis.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxPopis.TabIndex = 6;
        this.richTextBoxPopis.Text = "";
        // 
        // richTextBoxVyrobce
        // 
        this.richTextBoxVyrobce.Location = new System.Drawing.Point(143, 100);
        this.richTextBoxVyrobce.Name = "richTextBoxVyrobce";
        this.richTextBoxVyrobce.Size = new System.Drawing.Size(376, 30);
        this.richTextBoxVyrobce.TabIndex = 7;
        this.richTextBoxVyrobce.Text = "";
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
        // buttonRemove
        // 
        this.buttonRemove.Location = new System.Drawing.Point(233, 139);
        this.buttonRemove.Name = "buttonRemove";
        this.buttonRemove.Size = new System.Drawing.Size(135, 25);
        this.buttonRemove.TabIndex = 9;
        this.buttonRemove.Text = "Odebrat";
        this.buttonRemove.UseVisualStyleBackColor = true;
        this.buttonRemove.Visible = false;
        // 
        // LekForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(531, 176);
        this.Controls.Add(this.buttonRemove);
        this.Controls.Add(this.buttonOK);
        this.Controls.Add(this.richTextBoxVyrobce);
        this.Controls.Add(this.richTextBoxPopis);
        this.Controls.Add(this.richTextBoxCena);
        this.Controls.Add(this.richTextBoxName);
        this.Controls.Add(this.labelVyrobce);
        this.Controls.Add(this.labelPopis);
        this.Controls.Add(this.labelCena);
        this.Controls.Add(this.labelName);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.MinimizeBox = false;
        this.Name = "LekForm";
        this.Text = "LekForm";
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.Button buttonRemove;

    private System.Windows.Forms.Button buttonOK;

    private System.Windows.Forms.RichTextBox richTextBoxName;
    private System.Windows.Forms.RichTextBox richTextBoxCena;
    private System.Windows.Forms.RichTextBox richTextBoxPopis;
    private System.Windows.Forms.RichTextBox richTextBoxVyrobce;

    private System.Windows.Forms.Label labelVyrobce;

    private System.Windows.Forms.Label labelCena;
    private System.Windows.Forms.Label labelPopis;

    private System.Windows.Forms.Label labelName;

    #endregion
}