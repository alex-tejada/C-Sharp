using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Globalization;
using System.Diagnostics;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Threading;
using System.Configuration;
using Newtonsoft.Json;
using System.Web.Script.Services;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Specialized;
/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
[System.Web.Script.Services.ScriptService()]
public class WebService  : System.Web.Services.WebService
{
    
    #region variables
        string[] result;
        string[][] resultado;
        string[][][] Data;
        string rootPath = HttpContext.Current.Request.PhysicalApplicationPath;
        SmtpClient Client = new SmtpClient();
        MailMessage Msg = new MailMessage();
        public static string Link  = "http://ju2vm119/sugerencias/";
    #endregion

        //Metodos para enviar correos

    #region login_Celaya


    [WebMethod]
    public bool loginCeaP(string account)
    {
        bool exists = false;
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT TOP (1) * FROM SS_UsuarioExamen WHERE NoReloj = '" + account + "'", variables.conn);
            SqlDataReader rd = variables.cmd.ExecuteReader();
            if (rd.HasRows)
            { exists = true; }
        }
        catch (Exception ex) { }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
        return exists;
    }

    //get_user_inf_CeaP
    [WebMethod]
    public string[] get_user_inf_CeaP(string account)
    {
        try
        {
            result = new string[4];
            //variables.badge_number = account;

            /*obtener datos*/
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT TOP (1) * FROM SS_UsuarioExamen WHERE NoReloj = '" + account + "'", variables.conn);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            while (reader.Read())
            {
                result[0] = reader["NoReloj"].ToString();
                result[1] = reader["Usuario"].ToString();
                result[2] = reader["Nombre"].ToString();
                result[3] = reader["Tipo"].ToString();
            }
            reader.Close();
        }
        catch (Exception ex)
        { }
        finally
        {
            variables.conn.Close();
            variables.cmd.Dispose();
        }
        return result;
    }

    #endregion

    #region encuestas


    [WebMethod]
    public bool add_survey(string noReloj, string fecha, string curso, string instructor, string preg_11, string preg_12, string preg_21, string preg_22, string preg_31, string preg_32, string preg_41, string preg_42, string preg_43, string preg_44, string preg_51, string preg_61, string preg_62, string preg_63)
    {
        //General status of procedure.
        bool succesfull = false;

        //Status of inserting anwers in database
        bool survey_answers = false;

        //Insertion of general information in database
        bool general_information = insert_servey_general_information(noReloj, fecha, curso, instructor);

        //If the previous one was succesfull, then the answers are stored in the database
        if (general_information) { string id_encuesta = get_id_survey(noReloj, fecha, curso, instructor); survey_answers = insert_survey_answers(id_encuesta, preg_11, preg_12, preg_21, preg_22, preg_31, preg_32, preg_41, preg_42, preg_43, preg_44, preg_51, preg_61, preg_62, preg_63); }

        //If the general information as well as the ansers were inserted succesfully in the database, the general status 'successfull' is changed to true.
        if (survey_answers && general_information) { succesfull = true; }

        return succesfull;
    }

    [WebMethod]
    public bool insert_servey_general_information(string noReloj, string fecha, string curso, string instructor)
    {
        //This function takes the general values of survey and insert them in a table called Encuestas. At the end it returns a variable that indicates if the operation was succesfull or not.
        bool flag = false;
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("INSERT INTO [RBSuggestionBox].[dbo].[SS_ENCUESTAS](NoReloj, Fecha, Curso, Instructor) VALUES('" + noReloj + "','" + fecha + "','" + curso + "','" + instructor + "');", variables.conn);
            variables.cmd.ExecuteNonQuery();

            flag = true;
        }
        catch (Exception ex) { throw new Exception(ex.Message); }
        finally
        {
            variables.conn.Close();
            variables.cmd.Dispose();
        }
        return flag;
    }

    [WebMethod]
    public bool insert_survey_answers(string id_encuesta, string preg_11, string preg_12, string preg_21, string preg_22, string preg_31, string preg_32, string preg_41, string preg_42, string preg_43, string preg_44, string preg_51, string preg_61, string preg_62, string preg_63)
    {
        //This function takes the answers and store them in the table EncuestasRespuestas. At the end it returns a variable that indicated if the operation was succesfull or not.
        bool flag = false;
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("INSERT INTO [RBSuggestionBox].[dbo].[SS_EncuestasRespuestas](Id_encuesta, preg_11, preg_12, preg_21, preg_22, preg_31, preg_32, preg_41, preg_42, preg_43, preg_44, preg_51, preg_61, preg_62, preg_63) VALUES('" + id_encuesta + "','" + preg_11 + "','" + preg_12 + "','" + preg_21 + "','" + preg_22 + "','" + preg_31 + "','" + preg_32 + "','" + preg_41 + "','" + preg_42 + "','" + preg_43 + "','" + preg_44 + "','" + preg_51 + "','" + preg_61 + "','" + preg_62 + "','" + preg_63 + "');", variables.conn);
            variables.cmd.ExecuteNonQuery();
            flag = true;
        }
        catch (Exception ex) { throw new Exception(ex.Message); }
        finally
        {
            variables.conn.Close();
            variables.cmd.Dispose();
        }
        return flag;
    }

    [WebMethod]
    public string get_id_survey(string noReloj, string fecha, string curso, string instructor)
    {
        //Once the general information of survey is added in the database, this function returns the id so it can be inserted in the table of answers. This is because the id is self-generated.
        string id = "";
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT Id_encuesta FROM [RBSuggestionBox].[dbo].[SS_ENCUESTAS] WHERE NoReloj = '" + noReloj + "' AND Fecha='" + fecha + "' AND Curso='" + curso + "' AND Instructor='" + instructor + "';", variables.conn);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader["Id_encuesta"].ToString();
                }
            }
        }
        catch (Exception ex) { }
        finally
        {
            variables.conn.Close();
            variables.cmd.Dispose();
        }

        return id;
    }
    
    [WebMethod]
    public string[][] get_evaluations()
    {
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT Id_encuesta, Fecha, Curso, Instructor FROM [RBSuggestionBox].[dbo].[SS_ENCUESTAS]", variables.conn);
            SqlDataAdapter adp = new SqlDataAdapter(variables.cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            resultado = new string[dt.Rows.Count][];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                resultado[i] = new string[4];
                resultado[i][0] = dt.Rows[i]["Id_encuesta"].ToString();
                resultado[i][1] = dt.Rows[i]["Fecha"].ToString().Split(' ')[0];
                resultado[i][2] = dt.Rows[i]["Curso"].ToString();
                resultado[i][3] = dt.Rows[i]["Instructor"].ToString();
            }
        }
        catch (Exception ex)
        {
            resultado = new string[1][];
            resultado[0] = new string[1];
            resultado[0][0] = ex.Message;
        }
        finally
        {
            variables.conn.Close();
            variables.cmd.Dispose();
        }
        return resultado;
    }

    [WebMethod]
    public string[] get_all_information_of_evaluations(string Id_encuesta)
    {
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT E.NoReloj AS NoReloj, E.Fecha AS Fecha, E.Curso AS Curso, E.Instructor AS Instructor, R.preg_11 AS p11, R.preg_12 AS p12, R.preg_21 AS p21, R.preg_22 AS p22, R.preg_31 AS p31, R.preg_32 AS p32, R.preg_41 AS p41, R.preg_42 AS p42, R.preg_43 AS p43, R.preg_44 AS p44, R.preg_51 AS p51, R.preg_61 AS p61, R.preg_62 AS p62, R.preg_63  AS p63 FROM [RBSuggestionBox].[dbo].[SS_ENCUESTAS] E JOIN [RBSuggestionBox].[dbo].[SS_ENCUESTASRESPUESTAS] R ON E.Id_encuesta = R.Id_encuesta AND E.Id_encuesta = " + Id_encuesta, variables.conn);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            result = new string[18];

            while (reader.Read())
            {
                result[0] = reader["NoReloj"].ToString();
                result[1] = reader["Fecha"].ToString().Split(' ')[0];
                result[2] = reader["Curso"].ToString();
                result[3] = reader["Instructor"].ToString();
                result[4] = reader["p11"].ToString();
                result[5] = reader["p12"].ToString();
                result[6] = reader["p21"].ToString();
                result[7] = reader["p22"].ToString();
                result[8] = reader["p31"].ToString();
                result[9] = reader["p32"].ToString();
                result[10] = reader["p41"].ToString();
                result[11] = reader["p42"].ToString();
                result[12] = reader["p43"].ToString();
                result[13] = reader["p44"].ToString();
                result[14] = reader["p51"].ToString();
                result[15] = reader["p61"].ToString();
                result[16] = reader["p62"].ToString();
                result[17] = reader["p63"].ToString();
            }
        }
        catch (Exception ex)
        {

        }
        finally
        {
            variables.conn.Close();
        }
        return result;
    }

    [WebMethod]
    public string[] get_exam_titles_for_combobox(string user)
    {
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT E.titulo FROM SS_Examen E INNER JOIN SS_Registro R ON E.id_examen = R.id_examen AND R.usuario='" + user + "'", variables.conn);
            SqlDataAdapter adp = new SqlDataAdapter(variables.cmd);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            result = new string[dt.Rows.Count];

            for(int i = 0; i < dt.Rows.Count; i++)
            {
                result[i] = dt.Rows[i].ToString();
            }

        }
        catch (Exception ex)
        {
            result = new string[1];
            result[0] = "";
        }
        return result;
    }

    #endregion

    #region examMethods
    [WebMethod]
    public string setExamData(string JSONstring, string examTittle, string area, string lang, string username, string flag)
    {
        try
        {
            /*dynamic JSONObject = JsonConvert.DeserializeObject(JSONstring);
            bool stopDataProcess = false;
            Regex rxQuestion = new Regex(@"[^\w¡!¿?.,$%#@\s]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex rxAnswer =  new Regex(@"[^\w,$%#@\s]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            Regex rxTittle = new Regex(@"[^\w\s]", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            MatchCollection matchesQuestion;
            MatchCollection matchesAnswer;
            MatchCollection matchesTittle = rxTittle.Matches(examTittle);

            if (matchesTittle.Count > 0)
            {
                stopDataProcess = true;
            }
            foreach (dynamic questions in JSONObject)
            {
                string question = questions.question;
                matchesQuestion = rxQuestion.Matches(question);
                if (matchesQuestion.Count > 0)
                {
                    stopDataProcess = true;
                }
                foreach (string item in questions.multiple)
                {
                    matchesAnswer = rxAnswer.Matches(item);
                    if (matchesAnswer.Count > 0)
                    {
                        stopDataProcess = true;
                        break;
                    }
                }
                if (stopDataProcess)
                {
                    break;
                }
            }
            
            if (stopDataProcess)
            {
                return "2";
            }*/
            string examTittleModified = getRegexTittleFiltered(examTittle);
            if (int.Parse(flag) == 0)
            {
                DateTime date = DateTime.Now.Date;
                variables.conn.Open();
                variables.cmd = new SqlCommand("INSERT INTO SS_Examen (usuario,titulo,direccion,area,idioma,fecha) VALUES(@usuario,@titulo,@direccion,@area,@idioma,@fecha);", variables.conn);
                variables.cmd.Parameters.AddWithValue("@usuario", username);
                variables.cmd.Parameters.AddWithValue("@titulo", examTittle);
                variables.cmd.Parameters.AddWithValue("@direccion", examTittleModified + lang);
                variables.cmd.Parameters.AddWithValue("@area", int.Parse(area));
                variables.cmd.Parameters.AddWithValue("@idioma", lang);
                variables.cmd.Parameters.AddWithValue("@fecha", date);
                int result = variables.cmd.ExecuteNonQuery();
                variables.conn.Close();
                if (result > 0)
                {
                    File.WriteAllText(rootPath + "//Exams//Files//" + examTittleModified + lang + ".json", JSONstring);
                    return "1";
                }
                else
                {
                    return "3";
                }
            }
            else
            {
                var idExam = flag;
                bool result = false;
                string query = "SELECT direccion FROM SS_Examen WHERE usuario=@usuario AND id_examen=@id_examen";
                if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
                variables.conn.Open();
                variables.cmd = new SqlCommand(query, variables.conn);
                variables.cmd.Parameters.AddWithValue("@usuario", username);
                variables.cmd.Parameters.AddWithValue("@id_examen", idExam);
                SqlDataReader reader = variables.cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        examTittle = reader["direccion"].ToString();
                    }
                    result = true;
                }
                reader.Close();
                variables.conn.Close();
                if (result)
                {
                    File.WriteAllText(rootPath + "//Exams//Files//" + examTittle + ".json", JSONstring);
                    return "1";
                }
                else
                {
                    return "2";
                }
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestExamTittle(string examTittle, string lang, string username)
    {
        try
        {
            examTittle = getRegexTittleFiltered(examTittle);
            var result = false;
            if (File.Exists(rootPath + "//Exams//Files//" + examTittle + lang + ".json"))
            {
                result = true;
            }
            if (result)
            {
                return "2";
            }
            else
            {
                return "1";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }

    }
    [WebMethod]
    public string getExamData(string id, string username)
    {
        try
        {
            var result = false;
            string JSONstring = "";
            //var examTittleModified = getRegexTittleFiltered(examTittle);
            string[] resultQuery = null;
            string query = "SELECT TOP (1) * FROM SS_Examen WHERE usuario=@usuario AND id_examen=@id_examen";
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand(query, variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
                while (reader.Read())
                {
                    resultQuery = new string[reader.FieldCount];
                    resultQuery[0] = reader["id_examen"].ToString();
                    resultQuery[1] = reader["titulo"].ToString();
                    resultQuery[2] = reader["direccion"].ToString();
                    resultQuery[3] = reader["area"].ToString();
                    resultQuery[4] = reader["idioma"].ToString();
                    resultQuery[5] = reader["fecha"].ToString();
                }
            }
            reader.Close();
            variables.conn.Close();
            if (File.Exists(rootPath + "//Exams//Files//" + resultQuery[2] + ".json"))
            {
                using (StreamReader file = File.OpenText(rootPath + "//Exams//Files//" + resultQuery[2] + ".json"))
                {
                    JSONstring = file.ReadToEnd();
                }
            }
            if (result)
            {
                ExamData ExamData = new ExamData();
                ExamData.id = resultQuery[0];
                ExamData.JSONstring = JSONstring;
                ExamData.tittle = resultQuery[1];
                ExamData.path = resultQuery[2];
                ExamData.area = resultQuery[3];
                ExamData.language = resultQuery[4];
                ExamData.date = DateTime.Parse(resultQuery[5]).ToShortDateString();
                string responseString = JsonConvert.SerializeObject(ExamData);
                return responseString;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    class ExamData
    {
        public string id;
        public string JSONstring;
        public string tittle;
        public string path;
        public string area;
        public string language;
        public string date;
    }
    [WebMethod]
    public string getExamsData(string username)
    {
        try
        {
            ExamData ExamData = null;
            List<ExamData> examsList = new List<ExamData>();
            string query = "SELECT * FROM SS_Examen WHERE usuario=@usuario ORDER BY titulo";
            variables.conn.Open();
            variables.cmd = new SqlCommand(query, variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ExamData = new ExamData();
                    ExamData.id = reader["id_examen"].ToString();
                    ExamData.tittle = reader["titulo"].ToString();
                    ExamData.path = reader["direccion"].ToString();
                    ExamData.area = reader["area"].ToString();
                    ExamData.language = reader["idioma"].ToString();
                    ExamData.date = DateTime.Parse(reader["fecha"].ToString()).ToShortDateString();
                    ExamData.JSONstring = "";
                    examsList.Add(ExamData);
                }
            }
            reader.Close();
            variables.conn.Close();
            if (examsList.Count > 0)
            {
                string responseString = JsonConvert.SerializeObject(examsList);
                return responseString;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    public string getRegexTittleFiltered(string examTittle)
    {
        Regex rxTittle = new Regex(@"[\s]", RegexOptions.Compiled | RegexOptions.IgnoreCase);
        string examTittleModified = rxTittle.Replace(examTittle, "_");
        return examTittleModified;
    }
    [WebMethod]
    public string setExamScore(string JSONstring)
    {
        try
        {
            dynamic JSONobject = JsonConvert.DeserializeObject(JSONstring);
            string username = JSONobject.username;
            string path = JSONobject.path;
            string totalQuestions = JSONobject.totalQuestions;
            string correctAnswers = JSONobject.correctAnswers;
            string score = JSONobject.score;
            string id = JSONobject.id;

            DateTime date = DateTime.Now.Date;

            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            string query = "INSERT INTO SS_Registro (usuario,direccion,totalPreguntas,aciertos,calificacion,fecha,id_examen) VALUES (@usuario,@direccion,@totalPreguntas,@aciertos,@calificacion,@fecha,@id_examen);";
            variables.conn.Open();
            variables.cmd = new SqlCommand(query, variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            variables.cmd.Parameters.AddWithValue("@direccion", path);
            variables.cmd.Parameters.AddWithValue("@totalPreguntas", totalQuestions);
            variables.cmd.Parameters.AddWithValue("@aciertos", correctAnswers);
            variables.cmd.Parameters.AddWithValue("@calificacion", score);
            variables.cmd.Parameters.AddWithValue("@fecha", date);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            int result = variables.cmd.ExecuteNonQuery();
            variables.conn.Close();
            if (File.Exists(rootPath + "//Exams//UserLog//time" + id + username + ".json"))
            {
                File.Delete(rootPath + "//Exams//UserLog//time" + id + username + ".json");

            }
            if (result > 0)
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestDeleteExam(string id, string username, string path)
    {
        try
        {
            variables.conn.Open();
            variables.cmd = new SqlCommand("DELETE TOP (1) FROM SS_Examen WHERE usuario=@usuario AND id_examen=@id_examen;", variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            int result = variables.cmd.ExecuteNonQuery();
            variables.conn.Close();

            if (result > 0)
            {
                string JSONstring = "";
                if (File.Exists(rootPath + "//Exams//Files//" + path + ".json"))
                {
                    using (StreamReader file = File.OpenText(rootPath + "//Exams//Files//" + path + ".json"))
                    {
                        JSONstring = file.ReadToEnd();
                    }
                    if (JSONstring != "")
                    {
                        deleteFilesWithin(JSONstring);
                    }
                    File.Delete(rootPath + "//Exams//Files//" + path + ".json");
                }
                return "1" ;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    protected void deleteFilesWithin(string JSONstring)
    {
        dynamic JSONObject = JsonConvert.DeserializeObject(JSONstring);
        foreach (dynamic question in JSONObject)
        {
            string file = question.image;
            if (file != "")
            {
                File.Delete(rootPath + "//Exams//Images//" + file);
            }
        }
    }
    [WebMethod]
    public string requestDeleteFiles(string JSONstring)
    {
        dynamic JSONObject = JsonConvert.DeserializeObject(JSONstring);
        foreach (dynamic Files in JSONObject)
        {
            string name = Files.image;
            if (name != "")
            {
                File.Delete(rootPath + "//Exams//Images//" + name);
            }
        }
        return "1";
    }
    [WebMethod]
    public string requestUsernamesAuthorized(string id)
    {
        try
        {
            bool result = false;
            List<string> usersList = new List<string>();
            string query = "SELECT DISTINCT usuario FROM SS_Autorizacion WHERE id_examen=@id_examen ORDER BY usuario";
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand(query, variables.conn);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usersList.Add(reader["usuario"].ToString());
                }
                result = true;
            }
            reader.Close();
            variables.conn.Close();
            if (result)
            {
                string responseString = JsonConvert.SerializeObject(usersList);
                return responseString;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestUsernamesUnauthorized(string id)
    {
        try
        {
            bool result = false;
            List<string> usersList = new List<string>();
            string query = "SELECT DISTINCT usuario FROM SS_UsuarioExamen ORDER BY usuario";
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand(query, variables.conn);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    usersList.Add(reader["usuario"].ToString());
                }
                result = true;
            }
            reader.Close();
            query = "SELECT DISTINCT usuario FROM SS_Autorizacion WHERE id_examen=@id_examen ORDER BY usuario";
            variables.cmd = new SqlCommand(query, variables.conn);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int index = usersList.IndexOf(reader["usuario"].ToString());
                    if (index >= 0) { usersList.RemoveAt(index); }
                }
            }
            reader.Close();
            variables.conn.Close();
            if (result)
            {
                string responseString = JsonConvert.SerializeObject(usersList);
                return responseString;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestUserAprobal(string id, string usernameToAuthorize, string username)
    {
        try
        {
            bool result = false;
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT * FROM SS_Autorizacion WHERE usuario=@usuario AND id_examen=@id_examen", variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", usernameToAuthorize);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
            }
            reader.Close();
            if (result)
            {
                return "2";
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                string date = dateTime.ToString("dd-MM-yyyy");
                string time = dateTime.ToString("T");
                string query = "INSERT INTO SS_Autorizacion (aprobador,usuario,id_examen,fecha,hora) VALUES (@aprobador,@usuario,@id_examen,@date,@hour)";
                variables.cmd = new SqlCommand(query, variables.conn);
                variables.cmd.Parameters.AddWithValue("@aprobador", username);
                variables.cmd.Parameters.AddWithValue("@usuario", usernameToAuthorize);
                variables.cmd.Parameters.AddWithValue("@id_examen", id);
                variables.cmd.Parameters.AddWithValue("@date", date);
                variables.cmd.Parameters.AddWithValue("@hour", time);
                int resultInsert = variables.cmd.ExecuteNonQuery();
                variables.conn.Close();
                if (resultInsert > 0)
                {
                    return "1";
                }
                else
                {
                    return "2";
                }
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestUserRemoval(string id, string username)
    {
        try
        {
            bool result = false;
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT * FROM SS_Autorizacion WHERE usuario=@usuario AND id_examen=@id_examen", variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
            }
            reader.Close();
            if (!result)
            {
                return "2";
            }
            else
            {
                DateTime dateTime = DateTime.Now;
                string date = dateTime.ToString("dd-MM-yyyy");
                string time = dateTime.ToString("T");
                string query = "DELETE FROM SS_Autorizacion WHERE usuario=@usuario AND id_examen=@id_examen";
                variables.cmd = new SqlCommand(query, variables.conn);
                variables.cmd.Parameters.AddWithValue("@usuario", username);
                variables.cmd.Parameters.AddWithValue("@id_examen", id);
                int resultDelete = variables.cmd.ExecuteNonQuery();
                variables.conn.Close();
                if (resultDelete > 0)
                {
                    return "1";
                }
                else
                {
                    return "2";
                }
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestExamAuthorization(string id, string username)
    {
        try
        {
            bool result = false;
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand("SELECT * FROM SS_Autorizacion WHERE usuario=@usuario AND id_examen=@id_examen", variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                result = true;
            }
            reader.Close();
            variables.conn.Close();
            if (result)
            {
                return "1";
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestExamAuthorizationRemoval(string id, string username)
    {
        try
        {
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand("DELETE FROM SS_Autorizacion WHERE usuario=@usuario AND id_examen=@id_examen", variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            variables.cmd.Parameters.AddWithValue("@id_examen", id);
            int resultDelete = variables.cmd.ExecuteNonQuery();
            variables.conn.Close();
            if (resultDelete > 0)
            {
                return "1";
            }
            else
            {
                return"2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string getTimeleft(string id, string username)
    {
        try
        {
            var result = false;
            if (File.Exists(rootPath + "//Exams//UserLog//time" + id + username + ".json"))
            {
                var JSONstring = "";
                using (StreamReader file = File.OpenText(rootPath + "//Exams//UserLog//time" + id + username + ".json"))
                {
                    JSONstring = file.ReadToEnd();
                    result = true;
                }
                if (result)
                {
                    return JSONstring;
                }
                else
                {
                    return "2";
                }
            }
            return "2";
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
    }
    [WebMethod]
    public string setTimeleft(string id, string username, string minutes, string seconds)
    {
        try
        {
            UserTime UserTime = new UserTime();
            UserTime.minutes = minutes;
            UserTime.seconds = seconds;
            string JSONstring = JsonConvert.SerializeObject(UserTime);
            File.WriteAllText(rootPath + "//Exams//UserLog//time" + id + username + ".json", JSONstring);
            return "1";
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
    }
    class UserTime
    {
        public string minutes;
        public string seconds;
    }
    [WebMethod]
    public string getAllowedExams(string username)
    {
        try
        {
            List<string> idList = new List<string>();
            List<ExamsDetails> examsList = new List<ExamsDetails>(); 
            string query = "SELECT id_examen FROM SS_Autorizacion WHERE usuario=@usuario";
            if (variables.conn.State == ConnectionState.Open) { variables.conn.Close(); }
            variables.conn.Open();
            variables.cmd = new SqlCommand(query, variables.conn);
            variables.cmd.Parameters.AddWithValue("@usuario", username);
            SqlDataReader reader = variables.cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idList.Add(reader["id_examen"].ToString());
                }
            }
            reader.Close();
            query = "SELECT * FROM SS_Examen ORDER BY id_examen";
            variables.cmd = new SqlCommand(query, variables.conn);
            reader = variables.cmd.ExecuteReader();
            ExamsDetails ExamsDetails = null;
            if (reader.HasRows && idList.Count > 0)
            { 
                while (reader.Read())
                {
                    int index = idList.IndexOf(reader["id_examen"].ToString());
                    if (index >= 0)
                    {
                        ExamsDetails = new ExamsDetails();
                        ExamsDetails.id = reader["id_examen"].ToString();
                        ExamsDetails.title = reader["titulo"].ToString();
                        ExamsDetails.area = reader["area"].ToString();
                        ExamsDetails.language = reader["idioma"].ToString();
                        ExamsDetails.manager = reader["usuario"].ToString();
                        examsList.Add(ExamsDetails);
                    }
                }
            }
            reader.Close();
            variables.conn.Close();
            if (examsList.Count > 0)
            {
                result = idList.ToArray();
                string responseString = JsonConvert.SerializeObject(examsList);
                return responseString;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    class ExamsDetails
    {
        public string id;
        public string title;
        public string area;
        public string language;
        public string manager;
    }
    [WebMethod]
    public string requestReportInstructor(string username, string option, string idExamOption, string usernameOption)
    {
        try
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            variables.conn.Open();
            string tableStmt = "DECLARE @TableResult TABLE(username varchar(MAX),grade varchar(10), id_exam int,title varchar(MAX),id_registry int,dateReg date); ";
            string functionStmt = "INSERT INTO @TableResult (username,grade,id_exam,title,id_registry,dateReg) (SELECT*FROM dbo.SS_ReportInstructor(@username,@option,@idExamOption)); ";
            string selectStmt = "SELECT*FROM @TableResult ORDER BY id_registry; ";
            if (usernameOption != "")
            {
                selectStmt = "SELECT*FROM @TableResult WHERE username='"+usernameOption+"' ORDER BY id_registry; ";
            }
            adapter.SelectCommand = new SqlCommand(tableStmt+functionStmt+selectStmt, variables.conn);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.SelectCommand.Parameters.AddWithValue("@option", int.Parse(option));
            adapter.SelectCommand.Parameters.AddWithValue("@idExamOption", int.Parse(idExamOption));

            adapter.Fill(dataTable);
            foreach (DataRow dr in dataTable.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dataTable.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            if (rows.Count > 0)
            {
                string response = JsonConvert.SerializeObject(rows);
                return response;
            }
            else
            {
                return "2" ;
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestUsernames(string username)
    {
        try
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            variables.conn.Open();

            string tableStmt = "DECLARE @TableResult TABLE(username varchar(15)); ";
            string functionStmt = "INSERT INTO @TableResult (username) (SELECT*FROM dbo.SS_GetUsernames(@username)); ";
            string selectStmt = "SELECT DISTINCT * FROM @TableResult ORDER BY username";
            adapter.SelectCommand = new SqlCommand(tableStmt + functionStmt + selectStmt, variables.conn);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dataTable.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            if (rows.Count > 0)
            {
                string response = JsonConvert.SerializeObject(rows);
                return response;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    [WebMethod]
    public string requestExams(string username)
    {
        try
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            Dictionary<string, object> row;
            variables.conn.Open();
            
            string selectStmt = "SELECT id_examen, titulo FROM SS_Examen ORDER BY titulo";
            adapter.SelectCommand = new SqlCommand(selectStmt, variables.conn);
            adapter.SelectCommand.Parameters.AddWithValue("@username", username);
            adapter.Fill(dataTable);

            foreach (DataRow dr in dataTable.Rows)
            {
                row = new Dictionary<string, object>();
                foreach (DataColumn col in dataTable.Columns)
                {
                    row.Add(col.ColumnName, dr[col]);
                }
                rows.Add(row);
            }
            if (rows.Count > 0)
            {
                string response = JsonConvert.SerializeObject(rows);
                return response;
            }
            else
            {
                return "2";
            }
        }
        catch (Exception e)
        {
            return e.Message.ToString();
        }
        finally { variables.conn.Close(); variables.cmd.Dispose(); }
    }
    #endregion
}