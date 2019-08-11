using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace App1
{
    class Conexion
    {
        public MySqlConnection con;
        public MySqlDataReader dr;
        public MySqlCommand cmd;
        public string server = "",user="",password="";

        public void Abrir(string server,string user,string password)
        {
            if (con==null)
            {
                con = new MySqlConnection("server=" + server + "; database=scanandchecker; Uid=" + user + "; pwd=" + password + ";");
                con.Open();
                this.server = server;
                this.user = user;
                this.password = password;
            }
            else if (con.State == System.Data.ConnectionState.Closed)
            {
                con = new MySqlConnection("server=" + server + "; database=scanandchecker; Uid=" + user + "; pwd=" + password + ";");
                con.Open();
                this.server = server;
                this.user = user;
                this.password = password;
            }
            else
            {
                
            }
        }
        public void quickOpen()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con = new MySqlConnection("server=" + this.server + "; database=scanandchecker; Uid=" + this.user + "; pwd=" + this.password + ";");
                con.Open();
            }
        }

        public DataTable requestForTable(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query,con);
            DataTable table = new DataTable();
            table.Load(cmd.ExecuteReader());
            return table;
        }

        public void openAndTry()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con = new MySqlConnection("server=" + this.server + "; database=scanandchecker; Uid=" + this.user + "; pwd=" + this.password + ";");
                con.Open();
                con.Close();
            }
        }
        public void Cerrar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void Mov(string query)
        {
            cmd = new MySqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }
        public void Consulta(string query)
        {
            cmd = new MySqlCommand(query, con);
            dr = cmd.ExecuteReader();
        }
    }
}
