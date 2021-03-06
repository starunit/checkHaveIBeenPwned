﻿//-----------------------------------------------------------------------
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
      this.components = new System.ComponentModel.Container();
      this.pnlControls = new System.Windows.Forms.Panel();
      this.btnCheckAll = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.pnlResults = new System.Windows.Forms.Panel();
      this.txtResults = new System.Windows.Forms.RichTextBox();
      this.lstAddresses = new System.Windows.Forms.ListBox();
      this.txtNewAddress = new System.Windows.Forms.TextBox();
      this.btnAddNew = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.lblHeader = new System.Windows.Forms.Label();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.txtFound = new System.Windows.Forms.TextBox();
      this.txtFoundMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.checkAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lblFound = new System.Windows.Forms.Label();
      this.pnlControls.SuspendLayout();
      this.pnlResults.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.txtFoundMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlControls
      // 
      this.pnlControls.Controls.Add(this.btnCheckAll);
      this.pnlControls.Controls.Add(this.btnClose);
      this.pnlControls.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlControls.Location = new System.Drawing.Point(0, 645);
      this.pnlControls.Name = "pnlControls";
      this.pnlControls.Size = new System.Drawing.Size(833, 47);
      this.pnlControls.TabIndex = 0;
      // 
      // btnCheckAll
      // 
      this.btnCheckAll.Location = new System.Drawing.Point(14, 10);
      this.btnCheckAll.Name = "btnCheckAll";
      this.btnCheckAll.Size = new System.Drawing.Size(104, 25);
      this.btnCheckAll.TabIndex = 1;
      this.btnCheckAll.Text = "Check All";
      this.btnCheckAll.UseVisualStyleBackColor = true;
      this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(746, 13);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(75, 23);
      this.btnClose.TabIndex = 0;
      this.btnClose.Text = "&Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // pnlResults
      // 
      this.pnlResults.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.pnlResults.Controls.Add(this.txtResults);
      this.pnlResults.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnlResults.Location = new System.Drawing.Point(0, 251);
      this.pnlResults.Name = "pnlResults";
      this.pnlResults.Size = new System.Drawing.Size(833, 394);
      this.pnlResults.TabIndex = 1;
      // 
      // txtResults
      // 
      this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtResults.BackColor = System.Drawing.SystemColors.Info;
      this.txtResults.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResults.Location = new System.Drawing.Point(0, 3);
      this.txtResults.Name = "txtResults";
      this.txtResults.ReadOnly = true;
      this.txtResults.Size = new System.Drawing.Size(830, 388);
      this.txtResults.TabIndex = 0;
      this.txtResults.Text = "";
      // 
      // lstAddresses
      // 
      this.lstAddresses.FormattingEnabled = true;
      this.lstAddresses.Location = new System.Drawing.Point(0, 59);
      this.lstAddresses.Name = "lstAddresses";
      this.lstAddresses.Size = new System.Drawing.Size(413, 186);
      this.lstAddresses.TabIndex = 2;
      this.lstAddresses.SelectedIndexChanged += new System.EventHandler(this.lstAddresses_SelectedIndexChanged);
      // 
      // txtNewAddress
      // 
      this.txtNewAddress.Location = new System.Drawing.Point(423, 59);
      this.txtNewAddress.Name = "txtNewAddress";
      this.txtNewAddress.Size = new System.Drawing.Size(215, 20);
      this.txtNewAddress.TabIndex = 3;
      // 
      // btnAddNew
      // 
      this.btnAddNew.Location = new System.Drawing.Point(644, 59);
      this.btnAddNew.Name = "btnAddNew";
      this.btnAddNew.Size = new System.Drawing.Size(28, 23);
      this.btnAddNew.TabIndex = 4;
      this.btnAddNew.Text = "+";
      this.btnAddNew.UseVisualStyleBackColor = true;
      this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Location = new System.Drawing.Point(692, 59);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(129, 24);
      this.btnRemove.TabIndex = 5;
      this.btnRemove.Text = "Remove Selected";
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // lblHeader
      // 
      this.lblHeader.AutoSize = true;
      this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeader.Location = new System.Drawing.Point(131, 31);
      this.lblHeader.Name = "lblHeader";
      this.lblHeader.Size = new System.Drawing.Size(565, 25);
      this.lblHeader.TabIndex = 6;
      this.lblHeader.Text = "Check Have I Been Pwned site (thanks to Troy Hunt)";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(833, 24);
      this.menuStrip1.TabIndex = 7;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // txtFound
      // 
      this.txtFound.ContextMenuStrip = this.txtFoundMenu;
      this.txtFound.Location = new System.Drawing.Point(423, 117);
      this.txtFound.Multiline = true;
      this.txtFound.Name = "txtFound";
      this.txtFound.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtFound.Size = new System.Drawing.Size(401, 128);
      this.txtFound.TabIndex = 8;
      // 
      // txtFoundMenu
      // 
      this.txtFoundMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAddressToolStripMenuItem});
      this.txtFoundMenu.Name = "contextMenuStrip1";
      this.txtFoundMenu.Size = new System.Drawing.Size(181, 48);
      // 
      // checkAddressToolStripMenuItem
      // 
      this.checkAddressToolStripMenuItem.Name = "checkAddressToolStripMenuItem";
      this.checkAddressToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.checkAddressToolStripMenuItem.Text = "Check Address";
      this.checkAddressToolStripMenuItem.Click += new System.EventHandler(this.checkAddressToolStripMenuItem_Click);
      // 
      // lblFound
      // 
      this.lblFound.AutoSize = true;
      this.lblFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFound.Location = new System.Drawing.Point(420, 101);
      this.lblFound.Name = "lblFound";
      this.lblFound.Size = new System.Drawing.Size(76, 13);
      this.lblFound.TabIndex = 9;
      this.lblFound.Text = "Found Items";
      // 
      // FrmHibp
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(833, 692);
      this.Controls.Add(this.lblFound);
      this.Controls.Add(this.txtFound);
      this.Controls.Add(this.lblHeader);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnAddNew);
      this.Controls.Add(this.txtNewAddress);
      this.Controls.Add(this.lstAddresses);
      this.Controls.Add(this.pnlResults);
      this.Controls.Add(this.pnlControls);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(849, 730);
      this.MinimumSize = new System.Drawing.Size(849, 630);
      this.Name = "FrmHibp";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Check Troy Hunt\'s Have I Been Pwned";
      this.Load += new System.EventHandler(this.frmHIBP_Load);
      this.pnlControls.ResumeLayout(false);
      this.pnlResults.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.txtFoundMenu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

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
    private System.Windows.Forms.TextBox txtFound;
    private System.Windows.Forms.Label lblFound;
    private System.Windows.Forms.Button btnCheckAll;
    private System.Windows.Forms.ContextMenuStrip txtFoundMenu;
    private System.Windows.Forms.ToolStripMenuItem checkAddressToolStripMenuItem;
  }
}