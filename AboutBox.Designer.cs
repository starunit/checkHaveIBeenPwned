//-----------------------------------------------------------------------
// <copyright file="AboutBox.Designer.cs" company="Starunit Web Services">
//     Copyright (c) Starunit Web Services.
// </copyright>
//-----------------------------------------------------------------------

namespace checkHaveIBeenPwned
{
  partial class frmHIBP_About
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

/// <summary>
/// Clean up any resources being used.
/// </summary>
/// <param name="disposing">Boolean parameter</param>
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHIBP_About));
      this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
      this.logoPictureBox = new System.Windows.Forms.PictureBox();
      this.lblProductName = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.lblCopyright = new System.Windows.Forms.Label();
      this.lblCompanyName = new System.Windows.Forms.Label();
      this.okButton = new System.Windows.Forms.Button();
      this.txtDescription = new System.Windows.Forms.RichTextBox();
      this.tableLayoutPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel
      // 
      this.tableLayoutPanel.ColumnCount = 2;
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
      this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
      this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
      this.tableLayoutPanel.Controls.Add(this.lblProductName, 1, 0);
      this.tableLayoutPanel.Controls.Add(this.lblVersion, 1, 1);
      this.tableLayoutPanel.Controls.Add(this.lblCopyright, 1, 2);
      this.tableLayoutPanel.Controls.Add(this.lblCompanyName, 1, 3);
      this.tableLayoutPanel.Controls.Add(this.okButton, 1, 5);
      this.tableLayoutPanel.Controls.Add(this.txtDescription, 1, 4);
      this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel.Location = new System.Drawing.Point(9, 9);
      this.tableLayoutPanel.Name = "tableLayoutPanel";
      this.tableLayoutPanel.RowCount = 6;
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
      this.tableLayoutPanel.Size = new System.Drawing.Size(417, 265);
      this.tableLayoutPanel.TabIndex = 0;
      // 
      // logoPictureBox
      // 
      this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
      this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
      this.logoPictureBox.Name = "logoPictureBox";
      this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
      this.logoPictureBox.Size = new System.Drawing.Size(131, 259);
      this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.logoPictureBox.TabIndex = 12;
      this.logoPictureBox.TabStop = false;
      // 
      // lblProductName
      // 
      this.lblProductName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblProductName.Location = new System.Drawing.Point(143, 0);
      this.lblProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.lblProductName.MaximumSize = new System.Drawing.Size(0, 17);
      this.lblProductName.Name = "lblProductName";
      this.lblProductName.Size = new System.Drawing.Size(271, 17);
      this.lblProductName.TabIndex = 19;
      this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblVersion
      // 
      this.lblVersion.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblVersion.Location = new System.Drawing.Point(143, 26);
      this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.lblVersion.MaximumSize = new System.Drawing.Size(0, 17);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(271, 17);
      this.lblVersion.TabIndex = 0;
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblCopyright
      // 
      this.lblCopyright.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCopyright.Location = new System.Drawing.Point(143, 52);
      this.lblCopyright.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.lblCopyright.MaximumSize = new System.Drawing.Size(0, 17);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new System.Drawing.Size(271, 17);
      this.lblCopyright.TabIndex = 21;
      this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblCompanyName
      // 
      this.lblCompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCompanyName.Location = new System.Drawing.Point(143, 78);
      this.lblCompanyName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
      this.lblCompanyName.MaximumSize = new System.Drawing.Size(0, 17);
      this.lblCompanyName.Name = "lblCompanyName";
      this.lblCompanyName.Size = new System.Drawing.Size(271, 17);
      this.lblCompanyName.TabIndex = 22;
      this.lblCompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // okButton
      // 
      this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.okButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.okButton.Location = new System.Drawing.Point(339, 239);
      this.okButton.Name = "okButton";
      this.okButton.Size = new System.Drawing.Size(75, 23);
      this.okButton.TabIndex = 24;
      this.okButton.Text = "&OK";
      this.okButton.Click += new System.EventHandler(this.okButton_Click);
      // 
      // txtDescription
      // 
      this.txtDescription.Cursor = System.Windows.Forms.Cursors.Default;
      this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtDescription.Location = new System.Drawing.Point(140, 107);
      this.txtDescription.Name = "txtDescription";
      this.txtDescription.ReadOnly = true;
      this.txtDescription.Size = new System.Drawing.Size(274, 126);
      this.txtDescription.TabIndex = 25;
      this.txtDescription.Text = "";
      // 
      // frmHIBP_About
      // 
      this.AcceptButton = this.okButton;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 283);
      this.Controls.Add(this.tableLayoutPanel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmHIBP_About";
      this.Padding = new System.Windows.Forms.Padding(9);
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Have I Been Pwned (access Troy Hunt\'s site)";
      this.Load += new System.EventHandler(this.frmHIBP_About_Load);
      this.tableLayoutPanel.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
    private System.Windows.Forms.PictureBox logoPictureBox;
    private System.Windows.Forms.Label lblProductName;
    private System.Windows.Forms.Label lblVersion;
    private System.Windows.Forms.Label lblCopyright;
    private System.Windows.Forms.Label lblCompanyName;
    private System.Windows.Forms.Button okButton;
    private System.Windows.Forms.RichTextBox txtDescription;
  }
}
