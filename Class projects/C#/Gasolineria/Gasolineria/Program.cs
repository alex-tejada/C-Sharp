using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolineria
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Form1 ventana = new Form1();
            ventana.Text = "GASOLINERIA GRUPO ITIW31";
            Application.EnableVisualStyles();
            Application.Run(ventana);

        }
    }
}
