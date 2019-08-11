using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaDeViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAdultos.Clear();
            txtDestinos.Clear();
            txtNinos.Clear();
            txtImporte.Clear();
            lbDestinos.Focus();
        }

        private void lbDestinos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDestinos.Text = lbDestinos.SelectedItem.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double a = 0, n = 0, ip = 0, pa = 0, pn = 0;

            switch (txtDestinos.Text)
            {
                case "Aguascalientes":
                    pa = 745.50;
                    pn = 500.80;

                    break;
                case "Guadalarajara":
                    pa = 985.10;
                    pn = 625.10;

                    break;
                case "Mexico":
                    pa = 2000.30;
                    pn = 1300.10;

                    break;
                default:
                    break;
            }
            a = double.Parse(txtAdultos.Text);
            n = double.Parse(txtNinos.Text);
            ip = (a * pa) + (n * pn);
            txtImporte.Text = "$" + ip.ToString();
            txtImporte.Text = ip.ToString("C");
        }
    }
}
