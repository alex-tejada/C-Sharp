$(document).ready(function () {
    //restriccion de sesion iniciada;
    /*var acc = sessionStorage["NoReloj"];
    if (acc != null)
    {
        window.location.href = 'menuCeap.aspx';
    }*/
    sessionStorage["NoReloj"] = null;
    sessionStorage["usuario"] = null;
    sessionStorage["nombre"] = null;
    sessionStorage["tipo"] = null;
    $("#user").focus();
});

function reset() {
    document.getElementById("user").innerHTML = "";
    //document.getElementById('pass').innerHTML = "";
}

function enter(e) {
    if (e.keyCode == 13) { login(); }
}


function login()
{
    var cuenta = document.getElementById("user").value.toString();
    sessionStorage["NoReloj"] = null;
    sessionStorage["usuario"] = null;
    sessionStorage["nombre"] = null;
    sessionStorage["tipo"] = null;

    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_user_inf_CeaP",
        data: "{'account':'" + cuenta + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer)
        {
            var info = responseFromServer.d;
            //result = responseFromServer.d;
            if (info[0] == cuenta)
            {
                sessionStorage["NoReloj"] = info[0];
                //sessionStorage["usuarioCeap"] = info[1];
                sessionStorage["usuario"] = info[1];
                sessionStorage["nombre"] = info[2];
                sessionStorage["tipo"] = info[3];
                window.location.replace("menuCeaP.aspx");
            }
            else
            {
                $.alert({
                    title: 'User log-on failed',
                    content: 'Please verify your Employee ID',
                    type: 'red'
                });
            }
        }
    });
    
}