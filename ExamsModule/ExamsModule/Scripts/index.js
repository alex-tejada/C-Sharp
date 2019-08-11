$(document).ready(function () {
    //restriccion de sesion iniciada;
    var acc = sessionStorage['usuario'];
    if (acc != null)
    { window.location.href = 'menu.aspx'; }
    $("#user").focus();
});

function reset() {
    document.getElementById('user').value = "";
    document.getElementById('pass').value = "";
}

function enter(e)
{
    if (e.keyCode == 13)
    { login(); }
}

function existe()
{
    var valor = document.getElementById("user").value;
    if (valor.length == 8) {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/exist",
            data: "{'account':'" + valor + "'}",
            async: false,
            contentType: "application/json",
            datatype: "json",
            success: function (responseFromServer) {
                try
                {
                    if (responseFromServer.d != 0) 
                    { document.getElementById("pass").style.display = "block"; }

                    else
                    {
                        document.getElementById("pass").value = "";
                        document.getElementById("pass").style.display = "none";
                    }
                }
                catch (ex) { }
            }
        });
    }
    else
    {
        document.getElementById("pass").value = "";
        document.getElementById("pass").style.display = "none";
    }
}

function login()
{
    var cuenta = document.getElementById('user').value.toString();
    var contra = document.getElementById('pass').value.toString();
    var result = false;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/login",
            data: JSON.stringify({ account: cuenta, password: contra }),
            async: false,
            contentType: "application/json",
            datatype: "json",
            success: function (responseFromServer) {
                if (responseFromServer.d)
                {
                    $.ajax({
                        type: "POST",
                        url: "WebService.asmx/get_user_data",
                        data: "{'account':'" + cuenta + "'}",
                        contentType: "application/json",
                        async: false,
                        datatype: "json",
                        success: function (responseFromServer) {
                            var info = responseFromServer.d;
                            sessionStorage["nivel"] = info[3];
                            sessionStorage["NoEmp"] = info[0];
                            sessionStorage["dept"] = info[4];
                            sessionStorage["tipo"] = info[5];
                            sessionStorage["usuario"] = info[2];
                            sessionStorage["nombre"] = info[1];
                        }
                    });
                    result = responseFromServer.d;
                    if (sessionStorage["usuario"] != null)
                    { window.location.replace("menu.aspx"); }
                }   
            }
        });
        if (!result) {
            document.getElementById('notes').style.display = 'block';
        }
}