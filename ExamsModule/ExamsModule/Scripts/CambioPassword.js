$(document).ready(function () {
    if (sessionStorage["nivel"] < "B")
    { window.location.href = "menu.aspx"; }
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
});


function ChangePassword(){
    var Pass = document.getElementById('NewPassword').value;
    var PassRep = document.getElementById('NewPasswordRep').value;
    if(Pass == PassRep)
    {
        var OldPass = document.getElementById('OldPassword').value;
        var confirmed = false;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/UpdatePassword",
            data: "{'OldPass': '" + OldPass + "', 'NewPass':'" + Pass + "', 'BadgeNumber':'" + sessionStorage["NoEmp"] + "', 'Level':'" + sessionStorage["nivel"] + "'}",
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer)
            {
                try
                {
                    var result = responseFromServer.d;
                    if(result)
                    {
                        $.alert({
                            title: "Actualización de Contraseña",
                            type: "blue",
                            content: "La Contraseña ha sido actualizada",
                            columnClass: 'col-md-6 col-md-offset-3'
                        });
                    }
                    else
                    {
                        $.alert({
                            title: "Actualización de Contraseña",
                            type: "red",
                            content: "Error al actualizar la Contraseña, verifique la Contraseña Anterior",
                            columnClass: 'col-md-6 col-md-offset-3'
                        });
                    }
                }
                catch(ex)
                {

                }
            }
            // podriamos confirmar la contraseña dentro del W.S 
            // y si esta confirmada se procede al cabmio y se retorna true   

        });
    }
    else
    { //RESALTAR los dos campos que no coinciden
        $.alert({
            title: "Error!",
            type:"red",
            content: " no coinciden, ingrese los datos nuevamente",
            columnClass: 'col-md-6 col-md-offset-3'
        });
        //alert jquery password confirms does not match
    }
    reset();
}



function cancel()
{
    window.history.back();
}


function reset()
{

    document.getElementById('OldPassword').value = document.getElementById('NewPassword').value = document.getElementById('NewPasswordRep').value = '';
}