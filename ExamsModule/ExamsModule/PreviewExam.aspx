<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PreviewExam.aspx.cs" Inherits="PreviewExam" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id="titlePreviewExam">Preview</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/exam.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/jquery-confirm.css" rel="stylesheet" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script src="Scripts/newExam.js"></script>
    <script src="Scripts/previewExam.js"></script>
</head>
<body>
    <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
               <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                   <span class="navbar-toggler-icon "></span>
               </button>
               <img src="Resources/logo%202%20esquinas.png" class="logoesquina" />
            </nav>
            <div class="collapse enc" id="navbarToggleExternalContent">
                <div class="p-4 bg-sugg">
                    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnMenu()">Main</a>
                      </li>
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnToExams()">Exams</a>
                      </li>
                    </ul>
                </div>
            </div>
     </div><br /><br />
    <div class="row section-main">
       <div class="col-lg-12 col-md-9 col-sm-6 col-xs-4">
           <h1 id="examTittle"> </h1> 
           <hr />
           <form class="container" id="creationExamForm" onsubmit="event.preventDefault();event.stopPropagation();">
               <div class="form-row">
                    <div class="form-group col-lg-10 col-md-6">
                     </div>
               </div>
               <div class="form-row shadow" id="questions">
                    
               </div>
           </form>
        </div>
    </div>
</body>    
</html>

