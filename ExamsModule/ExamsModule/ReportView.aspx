<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportView.aspx.cs" Inherits="ReportView" %>

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
    <script src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script lang="javascript" src="Scripts/xlsx.full.min.js"></script>
    <script lang="javascript" src="Scripts/FileSaver.min.js"></script>
    <script src="Scripts/reportView.js"></script>
</head>
<body>
    <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
               <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                   <span class="navbar-toggler-icon "></span>
               </button>
                <h1>Grades</h1>
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
        <br />
        <hr />
        <div style="padding:10px;" class="shadow">
             <br/>
             <label for="exam">Exam:</label>
             <select name="exam" id="examSelect" style="max-width:200px;" class="form-control-sm form-check-inline">
                 <option value="0" selected>None</option>
             </select>
             <label for="exam">Username:</label>
             <select name="username"  id="usernameSelect" class="form-control-sm form-check-inline">
                  <option value="" selected>None</option>
             </select>
             <button id="filterButton" style="" class="btn btn-primary"  onclick="applyFilter()">Apply Filter</button>
            <div id="loadingDiv" style="visibility:hidden;float:right;" class="spinner-grow spinner-grow-sm" role="status">
                  <span class="sr-only">Loading...</span>
            </div>
            <button id="exportButton" style="display:none;" class="btn-success"  onclick="createWorkbook()">Export <img src="Resources/excel.png" alt="excel icon" /></button>
            <div id="noResults" style="visibility:hidden;">
                <p class="text-red">No results found</p>
            </div>
        </div>
        <br/>
        <div id="tableSection" class="shadow">

        </div>
    </div>
</body>
</html>
