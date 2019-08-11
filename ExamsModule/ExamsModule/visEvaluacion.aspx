<%@ Page Language="C#" AutoEventWireup="true" CodeFile="visEvaluacion.aspx.cs" Inherits="visEvaluacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visualizar Evaluaciones</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/CapSug.css" rel="stylesheet" />
    <link href="Content/entrenamientoEval.css" rel="stylesheet"/>
    <link href="Content/jquery-confirm.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous"/>
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet"/>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-confirm.js"></script>
    <script src="Scripts/menuCeap.js"></script>
    <script src="Scripts/desplegarEvaluacion.js"></script>
    <script src="Scripts/visEvaluacion.js"></script>
    <script src="Scripts/accessCeap.js"></script>

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
                              <a class="nav-link btn-click" onclick="cerrar_sesion()">Salir</a>
                          </li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="container contenido">
                <div class="row inside">
                        <div class="col-8 menu">
                            <div class="row">
                                <div class="col-3 formu" id="file0" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(0)" >
                                    <div class="row rowDivision" style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_0">class_title</h2>
                                    </div>
                                    <div class="row" style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_0" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row" style="word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_0" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>

                                <div class="col-3 formu" id="file1" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(1)">
                                    <div class="row rowDivision" style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_1">class_title</h2>
                                    </div>
                                    <div class="row"  style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_1" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row"  style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_1" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>

                                <div class="col-3 formu" id="file2" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(2)">
                                    <div class="row rowDivision"  style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_2">class_title</h2>
                                    </div>
                                    <div class="row"  style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_2" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row"  style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_2" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <br />

                            <div class="row">
                                <div class="col-3 formu" id="file3" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(3)">
                                    <div class="row rowDivision"  style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_3">class_title</h2>
                                    </div>
                                    <div class="row"  style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_3" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row"  style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_3" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>
                                <div class="col-3 formu" id="file4" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(4)">
                                    <div class="row rowDivision"  style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_4">class_title</h2>
                                    </div>
                                    <div class="row"  style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_4" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row"  style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_4" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>
                                <div class="col-3 formu" id="file5" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(5)">
                                    <div class="row rowDivision"  style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_5">class_title</h2>
                                    </div>
                                    <div class="row" style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_5" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row" style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_5" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>
                            </div>
                            <br />
                            <br />
                            <br />

                            <div class="row rowDivision" style="padding-bottom:5vh">
                                <div class="col-3 formu" id="file6" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(6)">
                                    <div class="row rowDivision"  style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_6">class_title</h2>
                                    </div>
                                    <div class="row" style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_6" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row" style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_6" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>
                                <div class="col-3 formu" id="file7" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(7)">
                                    <div class="row rowDivision"  style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_7">class_title</h2>
                                    </div>
                                    <div class="row"  style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_7" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row"  style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_7" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>
                                <div class="col-3 formu" id="file8" style="background-color:white;  padding:4vh; cursor:pointer; height: 300px;" onclick="setSelected(8)">
                                    <div class="row rowDivision"  style="background-color:white; padding-bottom:3vh; word-break: break-all; word-wrap:break-word; height: 170px;">
                                        <h2 id="classTitle_8">class_title</h2>
                                    </div>
                                    <div class="row"  style="padding-top: 1.5vh; word-break: break-all; word-wrap:break-word; height: 50px;">
                                        <h5 id="instructor_8" style="font-style:italic">instructor</h5>
                                    </div>
                                    <div class="row"  style="word-break:break-all; word-wrap:break-word; height: 50px;">
                                        <h6 id="date_8" style="font-style:italic"><br />date</h6>
                                    </div>
                                </div>
                                <br />
                                <br />
                            </div>

                            <div class="row" id="second_button" style="padding-top:3vh; padding-bottom:5vh;">
                                <div class="col-2" style="margin:10px auto; height:6vh;">
                                </div>
                                <div class="col-3" style="margin:10px auto; height:6vh; align-items:center; display:flex; justify-content:center;">
                                    <input type="submit" class="btn btn-primary captura" id="previous" onclick="upDateValues(0, 1)" value="Previous/Anterior" />
                                </div>
                                <div class="col-2" style="margin:10px auto; height:6vh; text-align:center;">
                                    <span id="no_pages" style="line-height:6vh; text-align:center; font-weight:bold"></span>
                                </div>
                                <div class="col-3" style="margin:10px auto; height:6vh; align-items:center; display:flex; justify-content:center;">
                                    <input type="submit" class="btn btn-primary captura" id="next" onclick="upDateValues(1, 1)" value="Siguiente/Next" />
                                </div>
                                <div class="col-2" style="margin:10px auto; height:6vh;">
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
        </div>
    </form>
</body>
</html>
