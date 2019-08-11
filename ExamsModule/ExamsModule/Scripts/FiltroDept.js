$(document).ready(function () {
    if (sessionStorage["nivel"] < "B")
    { window.location.href = "menu.aspx"; }
    GetData();  
    GetImp();
    GetAreaImp();
    TodayDate('ftentativa');
});

function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}

function GetData()
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetFilterSug",
        data: JSON.stringify({ TeamLeader: sessionStorage["NoEmp"] }),
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            result = responseFromServer.d;
            $('#info_sugerencias').empty();
            if (result != null) {
                for (var i = 0; i < result.length; i++) {
                    $("#info_sugerencias").append("<tr class='tr' onclick='show_suggestion(\"" + result[i][0] + "\")'><td>" + result[i][0] + "</td><td>" + result[i][1] + "</td></tr>");
                }
            }

        }
    });
}

function GetAreaImp()
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_department",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            $('#redireccionar').empty();
            if (result != null) {
                for(var i = 0; i < result.length; i++)
                { $("#redireccionar").append("<option>"+result[i]+"</option>"); }
            }
        }
    });
}

function GetImp()
{
    var size = 0;
    var temp = '';
    var split;
    do {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/get_names",
            data: "{'Name':'" + temp + "'}",
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer) {
                try {
                    var result = responseFromServer.d;
                    if (result != null) {
                        console.log(result);
                        size = result.length;
                        for (var i = 0; i < result.length; i++)
                        { $('#implementador').append("<option>" + result[i] + "</option>"); }

                        if (size > 999)
                        { temp = result[999]; }
                    }
                }
                catch (ex) { }
            }

        });

    } while (size > 999);
}

function show_suggestion(id)
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetFilterSugID",
        data: "{'ID':'" + id + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            result = responseFromServer.d;
            if (result != null) {
                document.getElementById('CurrentID').value = result[0];
                document.getElementById('folio').innerHTML = result[0];
                document.getElementById('origen').innerHTML = result[1];
                document.getElementById('LabelOriginador').innerHTML = result[2];
                document.getElementById('correo').value = result[3];
                document.getElementById('enfoque').innerHTML = result[5];
                document.getElementById('planta').innerHTML = result[6];
                document.getElementById('area').innerHTML = result[7];
                document.getElementById('estacion').innerHTML = result[9];
                document.getElementById('seccion').innerHTML = result[8];
                document.getElementById('departamento').innerHTML = result[10];
                document.getElementById('redcosto').value = result[12];
                document.getElementById('problema').innerHTML = result[13];
                document.getElementById('propuesta').innerHTML = result[14];
                document.getElementById('mejoras').innerHTML = result[15];
                document.getElementById('estado').innerHTML = result[16];
                document.getElementById("btnFile").disabled = false;
                document.getElementById("btnAceptar").addEventListener("click", Aceptar);
                document.getElementById("btnRedireccionar").addEventListener("click", ShowRedirect);
                document.getElementById("btnRechazar").addEventListener("click", ShowCancel);
            }

        }
    });
    document.getElementById('checkImplementador').checked = true;
    ImplementadorCheck();
}

function ImplementadorCheck()
{
    if (document.getElementById('checkImplementador').checked == true)
    {
        document.getElementById('checkRedireccionar').checked = false;
        document.getElementById('implementador').disabled = false;
        document.getElementById('ftentativa').disabled = false;
        document.getElementById('redireccionar').disabled = true;
        document.getElementById('btnAceptar').style.display = "block";
        document.getElementById('btnRedireccionar').style.display = "none";
    }

}

function RedireccionarCheck()
{
    if (document.getElementById('checkRedireccionar').checked == true)
    {
        document.getElementById('checkImplementador').checked = false;
        document.getElementById('implementador').disabled = true;
        document.getElementById('ftentativa').disabled = true;
        document.getElementById('redireccionar').disabled = false;
        document.getElementById('btnAceptar').style.display = "none";
        document.getElementById('btnRedireccionar').style.display = "block";
    }
}

function Aceptar()
{
    var Implementador = document.getElementById('implementador').value;
    var id = document.getElementById('folio').innerHTML;
    var fecha = document.getElementById('ftentativa').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/AceptSugFilter",
        data:"{'ID':'"+id+"', 'date':'"+fecha+"', 'Imp':'"+Implementador+"'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            if (responseFromServer.d) {
                $.alert({
                    title: 'Sugerencia Aceptada',
                    content: 'La Sugerencia ha sido aceptada Correctamente',
                    type: 'blue',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }
        }
    });
    SendAceptMail();
    SendImplementorMail();
    reset();
    GetData();
}

function SendAceptMail()
{
    var Email = document.getElementById('correo').value;
    if (Email != null && Email != '') {
        //Aproval Mail Method

        var id = document.getElementById('CurrentID').value;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/SendAprobMail",
            data: "{'MailAddress':'" + Email + "', 'ID': '" + id + "', 'Name':'" + sessionStorage["nombre"] + "', 'Option': 2}",
            async: false,
            contentType: "application/json",
            datatype: "json",
            success: function (responseFromServer) {
                if (responseFromServer.d) {
                    $.alert({
                        title: '',
                        content: 'Correo enviado al Originador',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
            }
        });
    }
}

function SendImplementorMail()
{
        //Implementor Mail Method
    var id = document.getElementById('CurrentID').value;
    var Imp = document.getElementById('implementador').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/SendImplementorMail",
        data: "{ 'ID': '" + id + "', 'Implementor':'" + Imp + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            if (responseFromServer.d) {
                $.alert({
                    title: '',
                    content: 'Correo enviado al Implementador',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }
        }
    });
}

function Rechazo() {
    var id = document.getElementById('folio').innerHTML;
    var Razon = document.getElementById('rechazo').value;
    console.log(id, Razon);
    $.ajax({
        type: "POST",
        url: "WebService.asmx/RejectSuggestionFilt",
        data: "{ 'ID':'" + id + "', 'Reason':'" + Razon + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            try {
                if (responseFromServer.d) {
                    $.alert({
                        title: 'Sugerencia Rechazada',
                        content: 'La sugerencia ha sido Rechazada',
                        type: 'orange',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
            }
            catch (ex) { }

        }
    });
    $('#Rechazar').modal('hide');
    SendRejectMail();
    GetData();
    reset();
}

function ShowCancel() {
    document.getElementById('rechazo').value = "";
    $('#Rechazar').modal('show');
}

function SendRejectMail()
{
    var Email = document.getElementById('correo').value;
    if (Email != null && Email != '')
    {
        //Aproval Mail Method

        var id = document.getElementById('CurrentID').value;
        var Reason = document.getElementById('rechazo').value;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/SendRejectMail",
            data: "{'MailAddress':'" + Email + "', 'ID': '" + id + "', 'Name':'" + sessionStorage["nombre"] + "','Reason':'" + Reason + "', 'Option': 2}",
            async: false,
            contentType: "application/json",
            datatype: "json",
            success: function (responseFromServer) {
                if (responseFromServer.d) {
                    $.alert({
                        title: '',
                        content: 'Correo enviado al Originador',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
            }
        });
    }
}

function Redirect() {
    var id = document.getElementById('folio').innerHTML;
    var Razon = document.getElementById('redireccion').value;
    var Area = document.getElementById('redireccionar').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/RedirectSuggesstionFilt",
        data: "{ 'ID':'" + id + "', 'AreaImp':'" + Area + "', 'Reason':'" + Razon + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            if (responseFromServer.d) {
                $.alert({
                    title: 'Sugerencia Redireccionada',
                    content: 'Sugerencia redireccionada a Departamento ' + Area,
                    type: 'blue',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }
        }
    });
    $('#ModRedireccionar').modal('hide');
    SendRedirectMail();
    GetData();
    reset();
}

function ShowRedirect()
{
    document.getElementById('redireccion').value = "";
    $('#ModRedireccionar').modal('show');
}

function SendRedirectMail()
{
    var id = document.getElementById('CurrentID').value;
    var Filtro = document.getElementById('implementador').value;
    var razon = document.getElementById('redireccion').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/SendRedirectMail",
        data: "{ 'ID': '" + id + "', 'TeamLeader':'" + Filtro + "', 'Reason':'"+razon+"'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            if (responseFromServer.d) {
                $.alert({
                    title: '',
                    content: 'Correo enviado al Administrador de Area',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }
        }
    });
}

function reset()
{
    document.getElementById('CurrentID').value = null;
    document.getElementById('folio').innerHTML = null;
    document.getElementById('origen').innerHTML = null;
    document.getElementById('correo').value = null;
    document.getElementById('enfoque').innerHTML = null;
    document.getElementById('planta').innerHTML = null;
    document.getElementById('area').innerHTML = null;
    document.getElementById('estacion').innerHTML = null;
    document.getElementById('seccion').innerHTML = null;
    document.getElementById('departamento').innerHTML = null;
    document.getElementById('redcosto').value = null;
    document.getElementById('problema').innerHTML = null;
    document.getElementById('propuesta').innerHTML = null;
    document.getElementById('mejoras').innerHTML = null;
    document.getElementById('estado').innerHTML = null;
    document.getElementById("btnFile").disabled = true;
    document.getElementById("btnAceptar").removeEventListener("click", Aceptar);
    document.getElementById("btnRedireccionar").removeEventListener("click", ShowRedirect);
    document.getElementById("btnRechazar").removeEventListener("click", ShowCancel);

}