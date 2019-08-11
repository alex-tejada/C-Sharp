using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PUNTODEVENTA
{
    public class Coneccion
    {
        public MySqlConnection con;
        public MySqlDataReader dr;
        public MySqlCommand cmd;
        

        public void Abrir()
        {
            con = new MySqlConnection("server=localhost; database=puntoventa; Uid=root; pwd=;");
            con.Open();
        }
        public void Cerrar()
        {
            con.Close();
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
