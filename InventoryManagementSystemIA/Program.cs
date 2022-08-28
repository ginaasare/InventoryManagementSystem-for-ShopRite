using System;
using System.Windows.Forms;

namespace InventoryManagementSystemIA
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Attendants());//this loads the splash screen when the application runs
        }
    }
}
