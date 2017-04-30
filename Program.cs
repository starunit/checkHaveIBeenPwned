//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Starunit Web Services">
//     Copyright (c) Starunit Web Services.
// </copyright>
//-----------------------------------------------------------------------
namespace checkHaveIBeenPwned
{
  using System;
  using System.Windows.Forms;

  /// <summary>
  /// Main Class Program
  /// </summary>
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FrmHibp());
    }
  }
}
