    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="menuCeap.aspx.cs" Inherits="menuCeap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CeaP</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/CapSug.css" rel="stylesheet" />
    <link href="Content/jquery-confirm.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous"/>
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet"/>

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-confirm.js"></script>
    <!-- <script src="Scripts/access.js"></script> -->
    <script src="Scripts/accessCeap.js"></script>
    <script src="Scripts/menuCeap.js"></script>
</head>
<body>
    


    <form id="form1" runat="server">
    <div>
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
                          <a class="nav-link btn-click" onclick="cerrar_sesion()">Exit</a>
                      </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container contenido">
            <div class="row inside">
                <div class="col-8 menu">
                    <div class="row" style="height:5vh; color:white; font-weight:bold; font-size:large">
                        <div class="col-11" style="text-align:center; vertical-align:central; background-color:#005691; margin: 10px auto">
                            <span style="line-height:5vh">Exams</span>
                        </div>
                        <div class="col-1">

                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <div class="col" id="ansEx">
                            <a onclick="window.location.replace('AllowedExams.aspx');"><img src="Resources/answerExam.png" class="btns" /></a>
                        </div>

                        <div class="col" id ="myEx">
                            <a onclick="window.location.replace('ViewExams.aspx');"><img src="Resources/myExams.png" class="btns" /></a>
                        </div>

                        <div class="col" id="myG">
                            <a href="ReportView.aspx"><img src="Resources/myGrades.png" class="btns" /></a>
                        </div>
                    </div>
                    <br />
                    <br />
                    <br />
                    <div class="row" style="height:5vh; color:white; font-weight:bold; font-size:large">
                        <div class="col-11" style="text-align:center; vertical-align:central; background-color:#005691; margin: 10px auto">
                            <span style="line-height:5vh">Training Evaluations</span>
                        </div>
                        <div class="col-1">

                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <div class="col" id="anEv">
                            <a href="Evaluacion.aspx" ><img src="Resources/answerEvaluation.png" class="btns" /></a>
                        </div>
                        <div class="col" id="visEv">
                            <a href="visEvaluacion.aspx"><img src="Resources/viewEvaluations.png" class="btns" /></a>
                        </div>
                        <div class="col">

                        </div>
                    </div>
                </div>

                <div class="col-4 menu2">
                    <div class="row">
                        <div class="col">
                            <div class="row">
                                <div class="col">
                                    <b>User:</b><br />
                                    <label class="bg-sugg-cuenta" id="user" style="font-weight:normal">User</label><br /><br />
                                </div>
                            </div>
                            
                            <div class="row">
                                <div class="col">
                                    <br />
                                    <br />                                    
                                </div>
                            </div>
                            
                        </div>
                        <div class="col">
                            <img src="Resources/icono%20usuario.png" class="user" />
                        </div>
                    </div>
                    <div class="row div-logo">
                        <div class="col-12">
                            <img src="Resources/devlab.png" class="logo"/>
                        </div>
                    </div>
                </div>
           
            

        </div>
    </div>
    </form>
</body>
</html>