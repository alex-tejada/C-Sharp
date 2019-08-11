using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class ServerConfig : Form
    {
        ServerInfo serverInfo=new ServerInfo();
        Conexion con = new Conexion();
        Thread threadConexion;

        public ServerConfig()
        {
            InitializeComponent();
        }

        public void readData()
        {
            string tempValue = "";
            string[] serverCredentials = serverInfo.readJSON();

            //10.10.10.10
            if (serverCredentials[0] != "")
            {
                tempValue = serverCredentials[0];

                numericUpDown1.Value = Convert.ToInt32(tempValue.Substring(0, tempValue.IndexOf('.')));

                tempValue = tempValue.Substring(tempValue.IndexOf(".") + 1);
                numericUpDown2.Value = Convert.ToInt32(tempValue.Substring(0, tempValue.IndexOf('.')));

                tempValue = tempValue.Substring(tempValue.IndexOf(".") + 1);
                numericUpDown3.Value = Convert.ToInt32(tempValue.Substring(0, tempValue.IndexOf('.')));

                tempValue = tempValue.Substring(tempValue.IndexOf(".") + 1);
                numericUpDown4.Value = Convert.ToInt32(tempValue.Substring(0, tempValue.Length));
            }
            if (serverCredentials[1] != "")
            {
                textBox_username.Text = serverCredentials[1];
            }
            if (serverCredentials[2] != "")
            {
                textBox_password.Text = serverCredentials[2];
            }
        }

        public void threadConexionManage()
        {
            try
            {
                string ip = numericUpDown1.Value.ToString() + '.' +
                numericUpDown2.Value.ToString() + '.' +
                numericUpDown3.Value.ToString() + '.' +
                numericUpDown4.Value.ToString();

                con.Abrir(ip, textBox_username.Text, textBox_password.Text);
                con.Cerrar();
                MessageBox.Show("¡Conectado!");
            }
            catch (Exception x)
            {
                MessageBox.Show("Sin Conexion:\n\n"+x.Message.ToString());
            }
            threadConexion = null;
        }
           
        private void button_guardar_Click(object sender, EventArgs e)
        {
            string ip = numericUpDown1.Value.ToString()+'.'+
                numericUpDown2.Value.ToString()+'.'+
                numericUpDown3.Value.ToString()+'.'+
                numericUpDown4.Value.ToString();
            
            if (textBox_password.Text != "" &&
                textBox_username.Text != "")
            {
                serverInfo.writeJSON(ip, textBox_username.Text, textBox_password.Text);
            }
            else
            {
                MessageBox.Show("Capture todos los campos.");
            }
        }

        private void button_recuperar_Click(object sender, EventArgs e)
        {
            
        }

        private void ServerConfig_Load(object sender, EventArgs e)
        {
            try
            {
                this.Icon = Icon.ExtractAssociatedIcon("Models/logoicon.ico");
                readData();
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x.Message.ToString());
            }
        }

        private void textBox_ip_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            threadConexion = new Thread(new ThreadStart(threadConexionManage));
            threadConexion.IsBackground = true;
            threadConexion.Start();
        }
    }
}
