using DAL;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.InteropServices;

using DAL.Extensions;

namespace App_WinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(App.Initialize());
            App.Save();
        }
    }
}