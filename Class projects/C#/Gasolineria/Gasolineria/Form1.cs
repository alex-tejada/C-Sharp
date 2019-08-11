using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gasolineria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int[] estacion = new int[7];
        public static double[] litros = new double[7];
        public static double[] importe = new double[7];
        public double precio;
        int pos = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (pos <= 6)
            {
                estacion[pos] = int.Parse(txtEstacion.Text);
                litros[pos] = double.Parse(txtLitros.Text);
                if (rbMagna.Checked)
                {
                    precio = 15.22;
                    importe[pos] = litros[pos] * precio;
                }
                else
                {
                    if (rbPremium.Checked)
                    {
                        precio = 17.50;
                        importe[pos] = litros[pos] * precio;
                    }
                }
                txtImporte.Text = importe[pos].ToString();
                pos++;
                txtEstacion.Clear();
                txtLitros.Clear();
            }
            if (pos == 7)
            {
                txtEstacion.Text = "Arreglo Completo";
                txtImporte.Text = "Arreglo Completo";
                txtLitros.Text = "Arreglo Completo";
            }
        }

        private void btnMostrarResultados_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();
            for (int i = 0; i <=6; i++)
            {
                lbResultado.Items.Add("La estacion: " + estacion[i] + " vendio: " +litros[i]+" litros "+" con un importe de: $" + importe[i] + "pesos");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lbResultado.Items.Clear();
            txtEstacion.Clear();
            txtImporte.Clear();
            txtLitros.Clear();
            txtEstacion.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
