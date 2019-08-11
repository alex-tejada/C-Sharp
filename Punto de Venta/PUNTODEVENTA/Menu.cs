using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PUNTODEVENTA
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        Inventario inv = new Inventario();
        public Ventas vs = new Ventas();
        Registro rg = new Registro();
        Reportes re = new Reportes();
        public Coneccion cn = new Coneccion();
        
        public string Verificar()
        {
           string usertype = lblUsertype.Text;

            if (usertype!="administrador")
            {
                inventarioToolStripMenuItem.Visible = false;
                reportesToolStripMenuItem.Visible = false;
                registroDeUsuarioToolStripMenuItem.Visible = false;
            }
            else
            {
                inventarioToolStripMenuItem.Visible= true;
                reportesToolStripMenuItem.Visible = true;
                registroDeUsuarioToolStripMenuItem.Visible= true;
            }
            return usertype;
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            vs.lblVendedor.Text = lblUser.Text;

            vs.lblUser.Text= lblUser.Text;
            vs.lblUsertype.Text = lblUsertype.Text;

            vs.Show();
            this.Close();
            
            
        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usertype= Verificar();

            if (usertype=="administrador")
            {
                inv.Show();
                inv.lblUser.Text = lblUser.Text;
                inv.lblUsertype.Text = lblUsertype.Text;
                this.Close();
            }
        }
        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usertype = Verificar();
            if (usertype=="administrador")
            {
                re.Show();
                re.lblUser.Text = lblUser.Text;
                re.lblUsertype.Text = lblUsertype.Text;
                this.Close();
            }
        }

        private void registroDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string usertype = Verificar();
            if (usertype=="administrador")
            {
                rg.Show();
                rg.lblUser.Text = lblUser.Text;
                rg.lblUsertype.Text = lblUsertype.Text;
                this.Close();
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }
    }
    }

