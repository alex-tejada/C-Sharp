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
    public partial class Form1 : Form
    {
        Menu mn = new Menu();
        Coneccion cn = new Coneccion();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            /*
            mn.Show();
            this.Hide();
            mn.lblUser.Text = "admin";
            mn.lblUsertype.Text = "administrador";
            */

            if (txtPass.Text != "" && txtUser.Text != "")
            {
                string query = "SELECT username, usertype, password FROM usuario WHERE username='" + txtUser.Text + "' AND password='" + txtPass.Text + "'";
                try
                {
                    cn.Abrir();
                    cn.Consulta(query);

                    if (cn.dr.HasRows)
                    {
                        while (cn.dr.Read())
                        {
                            mn.lblUser.Text = cn.dr.GetString(0);
                            mn.lblUsertype.Text = cn.dr.GetString(1);
                        }
                        mn.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("USUARIO o CONTRASEÑA incorrectos");
                    }

                    cn.dr.Close();
                    cn.Cerrar();
                }
                catch (Exception x)
                {
                    cn.Cerrar();
                    MessageBox.Show("Error: " + x.ToString());
                }
            }
            else
            {
                MessageBox.Show("Capture todos los campos");
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
