using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
/// <summary>
/// Summary description for Class1
/// </summary>
public class variables
{
    
        public static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["cs"].ConnectionString);
        public static SqlCommand cmd = new SqlCommand();

    #region account variables
        /*Departamento, no reloj, nombre, usuario, password, tipo, nivel*/

        public static string user = null;
        public static string badge_number = null;
        public static string name = null;
        public static string department = null;
        public static string email = null;
        public static string acces_lev = null;
        public static string type = null;
        
    #endregion 
        public static void close_session()
        {user = badge_number = name = department = email  = acces_lev = type = null;}
}