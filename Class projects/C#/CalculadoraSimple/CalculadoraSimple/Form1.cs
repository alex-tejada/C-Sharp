using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSimple
{
    public partial class Form1 : Form
    {
        double num1, num2, result;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDato1.Text = "";
            txtDato2.Text = "";
            txtResult.Text = "";
            txtDato1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            num1 = double.Parse(txtDato1.Text);
            num2 = double.Parse(txtDato2.Text);
            result = num1 - num2;
            txtResult.Text = "El resultado es: " + result.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            num1 = double.Parse(txtDato1.Text);
            num2 = double.Parse(txtDato2.Text);
            result = num1 * num2;
            txtResult.Text = "El resultado es: " + result.ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            num1 = double.Parse(txtDato1.Text);
            num2 = double.Parse(txtDato2.Text);
            result = num1 / num2;
            txtResult.Text = "El resultado es: " + result.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            num1 = double.Parse(txtDato1.Text);
            num2 = double.Parse(txtDato2.Text);
            result = num1 + num2;
            txtResult.Text = "El resultado es: "+result.ToString();
        }

    }
}
