using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PUNTODEVENTA
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        Coneccion cn = new Coneccion();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtRegistrarContra.Text != "" && txtRegistrarContraConfi.Text != "" && txtRegistrarNombre.Text != "" && txtRegistrarUsertype.Text != "")
            {
                lblErrorConfir.Visible = false;
                lblErrorContra.Visible = false;
                lblErrorUsertype.Visible = false;
                lblErrorUsuario.Visible = false;
                if (txtRegistrarUsertype.Text == "empleado" || txtRegistrarUsertype.Text == "administrador")
                {
                    lblErrorUsertype.Visible = false;
                    if (txtRegistrarNombre.Text != "")
                    {
                        lblErrorUsuario.Visible = false;
                        if (txtRegistrarContra.Text == txtRegistrarContraConfi.Text)
                        {
                            lblErrorConfir.Visible = false;
                            lblErrorContra.Visible = false;
                            string query = "INSERT INTO usuario(username,password,usertype) VALUES('" + txtRegistrarNombre.Text + "','" + txtRegistrarContra.Text + "','" + txtRegistrarUsertype.Text + "')";
                            try
                            {
                                cn.Abrir();
                                cn.Mov(query);
                                cn.Cerrar();

                                MessageBox.Show("Usuario registrado\nNombre de Usuario: " + txtRegistrarNombre.Text + "\nContraseña: " + txtRegistrarContra.Text);

                                txtRegistrarContra.Text = "";
                                txtRegistrarContraConfi.Text = "";
                                txtRegistrarNombre.Text = "";
                                txtRegistrarUsertype.Text = "";

                                lblErrorConfir.Visible = false;
                                lblErrorContra.Visible = false;
                                lblErrorUsertype.Visible = false;
                                lblErrorUsuario.Visible = false;

                            }
                            catch (Exception x)
                            {
                                cn.Cerrar();
                                MessageBox.Show("Error: " + x.ToString());
                            }
                            
                        }
                        else
                        {
                            lblErrorConfir.Visible = true;
                            lblErrorContra.Visible = true;
                            MessageBox.Show("Las contraseñas no coinciden");
                        }
                        
                    }
                    else
                    {
                        lblErrorUsuario.Visible = true;
                        MessageBox.Show("Capture el nombre de Usuario");
                    }
                     
                    
                }
                else
                {
                    lblErrorUsertype.Visible = true;
                    MessageBox.Show("Elija el tipo de usuario correcto: 'administrador' o 'empleado'");
                }
            }
            else
            {
                lblErrorConfir.Visible = true;
                lblErrorContra.Visible = true;
                lblErrorUsertype.Visible = true;
                lblErrorUsuario.Visible = true;
                MessageBox.Show("Capture todos los campos");
            }
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            mn.Show();
            mn.lblUser.Text = lblUser.Text;
            mn.lblUsertype.Text = lblUsertype.Text;
            this.Close();
        }
    }
}
