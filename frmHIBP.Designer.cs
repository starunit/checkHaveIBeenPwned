//-----------------------------------------------------------------------
// <copyright file="frmHIBP.Designer.cs" company="Starunit Web Services">
//     Copyright (c) Starunit Web Services.
// </copyright>
//-----------------------------------------------------------------------

namespace checkHaveIBeenPwned
{
  partial class FrmHibp
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      pnlControls = new System.Windows.Forms.Panel();
      btnClose = new System.Windows.Forms.Button();
      pnlResults = new System.Windows.Forms.Panel();
      txtResults = new System.Windows.Forms.RichTextBox();
      lstAddresses = new System.Windows.Forms.ListBox();
      txtNewAddress = new System.Windows.Forms.TextBox();
      btnAddNew = new System.Windows.Forms.Button();
      btnRemove = new System.Windows.Forms.Button();
      lblHeader = new System.Windows.Forms.Label();
      menuStrip1 = new System.Windows.Forms.MenuStrip();
      fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      pnlControls.SuspendLayout();
      pnlResults.SuspendLayout();
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // pnlControls
      // 
      pnlControls.Controls.Add(btnClose);
      pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
      pnlControls.Location = new System.Drawing.Point(0, 545);
      pnlControls.Name = "pnlControls";
      pnlControls.Size = new System.Drawing.Size(833, 47);
      pnlControls.TabIndex = 0;
      // 
      // btnClose
      // 
      btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      btnClose.Location = new System.Drawing.Point(746, 13);
      btnClose.Name = "btnClose";
      btnClose.Size = new System.Drawing.Size(75, 23);
      btnClose.TabIndex = 0;
      btnClose.Text = "&Close";
      btnClose.UseVisualStyleBackColor = true;
      btnClose.Click += new System.EventHandler(btnClose_Click);
      // 
      // pnlResults
      // 
      pnlResults.BackColor = System.Drawing.SystemColors.ActiveCaption;
      pnlResults.Controls.Add(txtResults);
      pnlResults.Dock = System.Windows.Forms.DockStyle.Bottom;
      pnlResults.Location = new System.Drawing.Point(0, 171);
      pnlResults.Name = "pnlResults";
      pnlResults.Size = new System.Drawing.Size(833, 374);
      pnlResults.TabIndex = 1;
      // 
      // txtResults
      // 
      txtResults.BackColor = System.Drawing.SystemColors.Info;
      txtResults.Dock = System.Windows.Forms.DockStyle.Fill;
      txtResults.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      txtResults.Location = new System.Drawing.Point(0, 0);
      txtResults.Name = "txtResults";
      txtResults.ReadOnly = true;
      txtResults.Size = new System.Drawing.Size(833, 374);
      txtResults.TabIndex = 0;
      txtResults.Text = string.Empty;
      // 
      // lstAddresses
      // 
      lstAddresses.FormattingEnabled = true;
      lstAddresses.Location = new System.Drawing.Point(86, 59);
      lstAddresses.Name = "lstAddresses";
      lstAddresses.Size = new System.Drawing.Size(413, 95);
      lstAddresses.TabIndex = 2;
      lstAddresses.SelectedIndexChanged += new System.EventHandler(lstAddresses_SelectedIndexChanged);
      // 
      // txtNewAddress
      // 
      txtNewAddress.Location = new System.Drawing.Point(521, 59);
      txtNewAddress.Name = "txtNewAddress";
      txtNewAddress.Size = new System.Drawing.Size(215, 20);
      txtNewAddress.TabIndex = 3;
      // 
      // btnAddNew
      // 
      btnAddNew.Location = new System.Drawing.Point(742, 59);
      btnAddNew.Name = "btnAddNew";
      btnAddNew.Size = new System.Drawing.Size(28, 23);
      btnAddNew.TabIndex = 4;
      btnAddNew.Text = "+";
      btnAddNew.UseVisualStyleBackColor = true;
      btnAddNew.Click += new System.EventHandler(btnAddNew_Click);
      // 
      // btnRemove
      // 
      btnRemove.Location = new System.Drawing.Point(521, 131);
      btnRemove.Name = "btnRemove";
      btnRemove.Size = new System.Drawing.Size(175, 23);
      btnRemove.TabIndex = 5;
      btnRemove.Text = "Remove Selected";
      btnRemove.UseVisualStyleBackColor = true;
      btnRemove.Click += new System.EventHandler(btnRemove_Click);
      // 
      // lblHeader
      // 
      lblHeader.AutoSize = true;
      lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      lblHeader.Location = new System.Drawing.Point(131, 31);
      lblHeader.Name = "lblHeader";
      lblHeader.Size = new System.Drawing.Size(565, 25);
      lblHeader.TabIndex = 6;
      lblHeader.Text = "Check Have I Been Pwned site (thanks to Troy Hunt)";
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            helpToolStripMenuItem});
      menuStrip1.Location = new System.Drawing.Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new System.Drawing.Size(833, 24);
      menuStrip1.TabIndex = 7;
      menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            exitToolStripMenuItem});
      fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      fileToolStripMenuItem.Text = "File";
      // 
      // exitToolStripMenuItem
      // 
      exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      exitToolStripMenuItem.Text = "Exit";
      exitToolStripMenuItem.Click += new System.EventHandler(exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            aboutToolStripMenuItem});
      helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      aboutToolStripMenuItem.Text = "About";
      aboutToolStripMenuItem.Click += new System.EventHandler(aboutToolStripMenuItem_Click);
      // 
      // FrmHibp
      // 
      AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      ClientSize = new System.Drawing.Size(833, 592);
      Controls.Add(lblHeader);
      Controls.Add(btnRemove);
      Controls.Add(btnAddNew);
      Controls.Add(txtNewAddress);
      Controls.Add(lstAddresses);
      Controls.Add(pnlResults);
      Controls.Add(pnlControls);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      MaximizeBox = false;
      MaximumSize = new System.Drawing.Size(849, 630);
      MinimumSize = new System.Drawing.Size(849, 630);
      Name = "FrmHibp";
      SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      Text = "Check Troy Hunt\'s Have I Been Pwned";
      Load += new System.EventHandler(frmHIBP_Load);
      pnlControls.ResumeLayout(false);
      pnlResults.ResumeLayout(false);
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlControls;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Panel pnlResults;
    private System.Windows.Forms.ListBox lstAddresses;
    private System.Windows.Forms.TextBox txtNewAddress;
    private System.Windows.Forms.Button btnAddNew;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.RichTextBox txtResults;
    private System.Windows.Forms.Label lblHeader;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
  }
}