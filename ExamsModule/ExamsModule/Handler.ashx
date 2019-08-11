<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;

public class Handler : IHttpHandler {

    public void ProcessRequest(HttpContext context)
    {
        if (context.Request.Files.Count > 0)
        {
            try
            {
                string rootPath = context.Request.PhysicalApplicationPath;
                string path = rootPath + "//Exams//Images//";
                HttpFileCollection files = context.Request.Files;
                
                for (int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];
                    file.SaveAs(path + file.FileName);
                }
                context.Response.Write("1");
            }
            catch (Exception e)
            {
                context.Response.Write("2");
            }
        }
    }

    public bool IsReusable {
        get {
            return false;
        }
    }

}