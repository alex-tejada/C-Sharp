    <%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sugerencias</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/jquery-confirm.css" rel="stylesheet" />
    <link href="Content/index.css" rel="stylesheet" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-confirm.js"></script>
    <script src="Scripts/index.js"></script>
</head>
<body>
    <form id="form1">
        <div class="container fcontainer">
            <div class="row upper">
                <div class="col-9"></div>
                <div class="col-3 cdlab">
                    <img src="Resources/devlab.png" class="dlab" />
                </div>
            </div>
            <div class="logo">
            </div>
            <div class="row lower">
                <div class="col-3"></div>
                <div class="col-6 login" id="divlogin">
                    <div class="row">
                        <div class="col-12">
                            <h1><b>LOGIN</b></h1>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <input type="text" placeholder="Username" id="user" onkeyup="existe()" class="inputsug" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12">
                            <input type="password" placeholder="Password" id="pass" onkeyup="enter(event)" class="inputsug" style="display:none;"  />
                        </div>
                        <label id="notes" style="">Usuario/Contraseña incorrecto(s)</label>
                    </div>
                    <div class="row">
                        <div class="col-6">                            
                            <input type="button" class="btn btn-primary btn-lg entrar"  id="ENTRAR" value="ENTRAR" onclick="login()"/>
                        </div>
                        <div class="col-6">
                            <button type="button" class="btn btn-primary btn-lg cancelar" onclick="reset()"  id="cancelar">CANCELAR</button>
                        </div>
                    </div>
                </div>

                <div class="col-3"></div>
            </div>
            <div class="row footer">
                <div class="col-12">
                    <center><p style="font-size: 1.3rem; margin-top: 0.5rem "><b>v2.0 Copyright &copy; <%: DateTime.Now.Year %> - JuP1/ICO DevLab. <span id="rights"></span></b></p></center>
                </div>
            </div>
        </div>
    </form>   
</body>
</html>
