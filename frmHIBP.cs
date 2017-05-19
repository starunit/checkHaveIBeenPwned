//-----------------------------------------------------------------------
// <copyright file="frmHIBP.cs" company="Starunit Web Services">
//     Copyright (c) Starunit Web Services.
// </copyright>
//-----------------------------------------------------------------------
namespace checkHaveIBeenPwned
{
  using System;
  using System.Net;
  using System.Windows.Forms;

  /// <summary>
  /// Main form for to ping Troy Hunt's Have I Been Pwned site
  /// </summary>
  /// <seealso cref="System.Windows.Forms.Form" />
  public partial class FrmHibp : Form
  {
    /// <summary>
    /// Initializes a new instance of the FrmHibp class
    /// </summary>
    public FrmHibp()
    {
      InitializeComponent();
    }

    /// <summary>
    /// close the form: 
    /// </summary>
    /// <param name="sender">the clicked object</param>
    /// <param name="e">additional arguments</param>
    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    /// <summary>
    /// Form Load
    /// </summary>
    /// <param name="sender">the clicked object</param>
    /// <param name="e">additional arguments</param>
    private void frmHIBP_Load(object sender, EventArgs e)
    {
      LoadAddresses();
    } 
 
    /// <summary>
    /// Pull addresses from the settings file and load them into the list box
    /// </summary>
    private void LoadAddresses()
    {
      // get list of addresses and load to lstAddresses
      foreach (string t in Properties.Settings.Default.AddressList.Split(';'))
      {
        if (t.Length > 0)
        {
          lstAddresses.Items.Add(t);
        }
      }
    }

    /// <summary>
    /// Add a new address to the list box, and then build and save the updated list
    /// </summary>
    /// <param name="sender">the clicked object</param>
    /// <param name="e">additional arguments</param>
    private void btnAddNew_Click(object sender, EventArgs e)
    {
      // build a list of current addresses, concatenate new address, save to settings           
      string bufferAddresses = string.Empty;

      if (txtNewAddress.Text.Length > 0)
      {
        lstAddresses.Items.Add(txtNewAddress.Text);
      }

      foreach (string t in lstAddresses.Items)
      {
        if (t.Length > 0)
        {
          bufferAddresses += t + ";";
        }
      }

      try
      {
        Properties.Settings.Default.AddressList = bufferAddresses;
        Properties.Settings.Default.Save();
      }
      catch (Exception gg)
      {
        MessageBox.Show(@"The new address was not saved: " + Environment.NewLine + gg.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    /// <summary>
    /// remove an address, and then build and save the updated list
    /// </summary>
    /// <param name="sender">the clicked object</param>
    /// <param name="e">additional arguments</param>
    private void btnRemove_Click(object sender, EventArgs e)
    {
      string bufferAddresses = string.Empty;

      try
      {
        lstAddresses.Items.Remove(lstAddresses.SelectedItem.ToString());
      }
      catch (Exception)
      {
        // ignored
      }

      foreach (string t in lstAddresses.Items)
      {
        if (t.Length > 0)
        {
          bufferAddresses += t + ";";
        }
      }

      try
      {
        Properties.Settings.Default.AddressList = bufferAddresses;
        Properties.Settings.Default.Save();
      }
      catch (Exception gg)
      {
        MessageBox.Show(@"The address was not removed properly:" + Environment.NewLine + gg.Message, @"Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    /// <summary>
    /// When an item is selected, this is called to go out and query the haveibeenpwned.com site
    /// (Thanks Troy Hunt!)
    /// </summary>
    /// <param name="sender">the clicked object</param>
    /// <param name="e">additional arguments</param>
    private void lstAddresses_SelectedIndexChanged(object sender, EventArgs e)
    {
      ServicePointManager.Expect100Continue = true;
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
      string ua = Properties.Settings.Default.ua;
      string content = string.Empty;
      txtResults.Text = string.Empty;

      if (lstAddresses.SelectedItem == null)
      {
        content = string.Empty;
      }
      else
      {
        try
        {
          if (lstAddresses.SelectedItem.ToString().Length > 0)
          {
            // ReSharper disable once InconsistentNaming
            string myURL = Properties.Settings.Default.HIBP_URL + lstAddresses.SelectedItem;
            WebClient syncClient = new WebClient();
            syncClient.Headers.Add("user-agent", ua);
            content = syncClient.DownloadString(myURL);
            content = content.Replace("[{", string.Empty);
            content = content.Replace("}]", string.Empty);
            content = content.Replace("\",\"", "\"" + Environment.NewLine + "\"");
            content = content.Replace(",\"", "\"" + Environment.NewLine + "\"");
          }
        }
        catch (Exception myException)
        {
          content = myException.Message;
          if (content.IndexOf("404", StringComparison.CurrentCulture) > 0)
          {
            content = lstAddresses.SelectedItem + ": No breach found";
          }
          else if (content.IndexOf("429", StringComparison.CurrentCulture) > 0)
          {
            content = "Slow down: you have to wait a couple of seconds between requests";
          }
        }
      }

      txtResults.Text = content;
    }

    /// <summary>
    /// Exit from the Menu
    /// </summary>
    /// <param name="sender">the clicked object</param>
    /// <param name="e">additional arguments</param>
    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    /// <summary>
    /// Show the About Box
    /// </summary>
    /// <param name="sender">the clicked object</param>
    /// <param name="e">additional arguments</param>
    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmHIBP_About myAbout = new frmHIBP_About();
      myAbout.Show();
    }
  }
}
