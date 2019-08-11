using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewExam : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
           uploadImages();
           return;
        }
    }

    void uploadImages()
    {
        try
        {
            string rootPath = Request.PhysicalApplicationPath;
            bool fileSaved = false;
            FileUpload fileUpload = new FileUpload();
            string path = rootPath + "//Exams//Images//";
            NameValueCollection nvc = Request.Form;
            System.Diagnostics.Debug.WriteLine("Count: "+nvc.Count);
            foreach (String key in nvc.Keys)
            {
                System.Diagnostics.Debug.WriteLine(nvc[key]);
            }
        }
        catch (Exception ex)
        {
            System.Diagnostics.Debug.WriteLine(ex.Message.ToString());
            //Response.Write("<script language='JavaScript'>console.log('" + ex.Message + "')</script>");
        }
        finally
        {
            
        }
    }
}