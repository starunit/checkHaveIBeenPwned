//-----------------------------------------------------------------------
// <copyright file="AboutBox.cs" company="Starunit Web Services">
//     Copyright (c) Starunit Web Services.
// </copyright>
//-----------------------------------------------------------------------

namespace checkHaveIBeenPwned
{
  using System;
  using System.Reflection;
  using System.Windows.Forms;
  using Properties;
  // ReSharper disable once InconsistentNaming

  /// <summary>
  /// another doc
  /// </summary>
  partial class frmHIBP_About : Form
  {
    /// <summary>
    /// Initializes a new instance of the frmHIBP_About class
    /// </summary>
    public frmHIBP_About()
    {
      InitializeComponent();
      //Text = string.Format("About {0}", AssemblyTitle);
      lblProductName.Text = AssemblyProduct;
      lblVersion.Text = string.Format("Version {0}", AssemblyVersion);
      lblCopyright.Text = AssemblyCopyright;
      lblCompanyName.Text = AssemblyCompany;
      txtDescription.Text = AssemblyDescription;
    }

    #region Assembly Attribute Accessors

    //private string AssemblyTitle
    //{
    //  get
    //  {
    //    object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
    //    if (attributes.Length > 0)
    //    {
    //      AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
    //      if (titleAttribute.Title != string.Empty)
    //      {
    //        return titleAttribute.Title;
    //      }
    //    }

    //    return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
    //  }
    //}

    private string AssemblyVersion
    {
      get
      {
        return Assembly.GetExecutingAssembly().GetName().Version.ToString();
      }
    }

    private string AssemblyDescription
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
        if (attributes.Length == 0)
        {
          return string.Empty;
        }

        return ((AssemblyDescriptionAttribute)attributes[0]).Description;
      }
    }

    private string AssemblyProduct
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
        if (attributes.Length == 0)
        {
          return string.Empty;
        }

        return ((AssemblyProductAttribute)attributes[0]).Product;
      }
    }

    private string AssemblyCopyright
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
        if (attributes.Length == 0)
        {
          return string.Empty;
        }

        return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
      }
    }

    private string AssemblyCompany
    {
      get
      {
        object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
        if (attributes.Length == 0)
        {
          return string.Empty;
        }

        return ((AssemblyCompanyAttribute)attributes[0]).Company;
      }
    }
    #endregion

    /// <summary>
    /// the OK Button
    /// </summary>
    /// <param name="sender">the object that called</param>
    /// <param name="e">Event Arguments</param>
    private void okButton_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmHIBP_About_Load(object sender, EventArgs e)
    {
      txtDescription.Text = Resources.txtDescription;
    }
  }
}
