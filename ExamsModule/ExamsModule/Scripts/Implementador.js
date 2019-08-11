$(document).ready(function () {
    reset();
    GetData(); 
});

function GetData() {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/GetImpSug",
            data: JSON.stringify({ Implementor: sessionStorage["NoEmp"] }),
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

function show_suggestion(id) {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetImpSugID",
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
                document.getElementById('btnFile').disabled = false;
                document.getElementById("btnAceptar").addEventListener("click", Aceptar);
                document.getElementById("btnRechazar").addEventListener("click", ShowCancel);
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
        url: "WebService.asmx/RejectSuggestionImp",
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
    SendRejectEmail();
    GetData();
    reset();
}

function SendRejectEmail()
{
    var Email = document.getElementById('correo').value;
    if (Email != null && Email != '') {
        //Aproval Mail Method

        var id = document.getElementById('CurrentID').value;
        var Reason = document.getElementById('rechazo').value;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/SendRejectMail",
            data: "{'MailAddress':'" + Email + "', 'ID': '" + id + "', 'Name':'" + sessionStorage["nombre"] + "','Reason':'" + Reason + "', 'Option': 3}",
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

function ShowCancel() {
    document.getElementById('rechazo').value = "";
    $('#Rechazar').modal('show');
}

function reset() {
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
    document.getElementById('btnFile').disabled = true;
    document.getElementById("btnAceptar").removeEventListener("click", Aceptar);
    document.getElementById("btnRechazar").removeEventListener("click", ShowCancel);
}

function Aceptar()
{
    if (document.getElementById('folio').innerHTML != "" && document.getElementById('folio').innerHTML != null)
    {
        sessionStorage["EstadoImp"] = 'In Process';
        sessionStorage["Page"] = 'Implementador.aspx';
        sessionStorage["FolioImp"] = document.getElementById('folio').innerHTML;
        window.location.href = 'EvidenciaImp.aspx';
    }

}