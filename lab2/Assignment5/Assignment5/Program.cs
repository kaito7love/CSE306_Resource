using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5
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
            // Create and show the second form (Form2) without blocking the main form
            Form2 secondForm = new Form2();
            secondForm.Show();

            // Start the application message loop with the main form (Form1)
            Application.Run(new Form1());
        }
    }
}
