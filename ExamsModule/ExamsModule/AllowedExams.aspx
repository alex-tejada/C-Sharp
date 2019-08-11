<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AllowedExams.aspx.cs" Inherits="AllowedExams" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id='titleViewExams'>Exams</title>
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
    <script src="Scripts/allowedExams.js"></script>
</head>
<body>
    <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
               <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                   <span class="navbar-toggler-icon "></span>
               </button>
                <h1>Available exams</h1>
               <img src="Resources/logo%202%20esquinas.png" class="logoesquina" />
            </nav>
            <div class="collapse enc" id="navbarToggleExternalContent">
                <div class="p-4 bg-sugg">
                    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnMenu()">Main</a>
                      </li>
                    </ul>
                </div>
            </div>
     </div><br /><br />
    <div class="container">
        <br/>
        <table class="table table-sm" style="text-align:center;">
          <thead class="">
            <tr>
              <th scope="col">#</th>
              <th scope="col"><label id='tableTitle'>Title</label></th>
              <th scope="col"><label id='tableArea'>Area</label></th>
              <th scope="col"><label id='tableLanguage'>Language</label></th>
              <th scope="col"><label id='tableManager'>Instructor</label></th>
              <th scope="col"></th>
            </tr>
          </thead>
          <tbody id="tableBody">

          </tbody>
        </table>
        <div class="modal" tabindex="-1" id="modalOpenExam" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title"><label id="openExamTitle">Begin Exam</label></h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                          <div style="text-align:center;">
                              <img style="max-height:100px;max-width:100px;margin:0 auto;"  src="Resources/attention.png" alt="Attention advise" />
                          </div><br />
                          <h6>Important</h6>
                          <ul>
                              <li>Once you have accessed the exam you will not be able to re-enter until the instructor approves it again</li>
                              <li>Time limit is to 60 minutes</li>
                              <li>Make sure have internet connection</li>
                          </ul> 
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-primary" onclick="openExam();"> <label id="openExamConfirm"> Continue with exam</label></button>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal"><label id="modalCancel"> Close</label></button>
                      </div>
                    </div>
                  </div>
                </div>
    </div>
</body>
</html>
