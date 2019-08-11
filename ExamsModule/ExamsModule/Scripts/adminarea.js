$(document).ready(function () {
    if (sessionStorage["nivel"] < "C")
    { window.location.href = "menu.aspx"; }

    GetData();
});


function GetData() {
    var option = document.getElementById('tipo').value;
    var estado;
    //seleccion de datos
    if (option == 'Nuevas Ideas') {
        estado = 'New Idea';
    }
    else if (option == 'Ideas Implementadas') {
        estado = 'Implemented';
    }
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetAdminSug",
        data: JSON.stringify({ State: estado, Dept: sessionStorage["dept"] }),
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            result = responseFromServer.d;
            $('#info_sugerencias').empty();
            if (result != null) {
                for (var i = 0; i < result.length; i++) {
                    $("#info_sugerencias").append("<tr class='tr' onclick='show_suggestion(\"" + result[i][0] + "\")'><td>" + result[i][0] + "</td><td>" + result[i][1] + "</td><td>" + result[i][2] + "</td><td>" + result[i][3] + "</td></tr>");
                }
            }
        }
    });
}


function reset() {
    document.getElementById('folio').innerHTML = null;
    document.getElementById('origen').innerHTML = null;
    document.getElementById('originador').innerHTML = null;
    document.getElementById('correo').value = null;
    document.getElementById('enfoque').innerHTML = null;
    document.getElementById('planta').innerHTML = null;
    document.getElementById('area').innerHTML = null;
    document.getElementById('estacion').innerHTML = null;
    document.getElementById('seccion').innerHTML = null;
    document.getElementById('dept').innerHTML = null;
    document.getElementById('redcosto').value = null;
    document.getElementById('problema').innerHTML = null;
    document.getElementById('propuesta').innerHTML = null;
    document.getElementById('mejoras').innerHTML = null;
    document.getElementById('estado').innerHTML = null;
    document.getElementById('implementador').value = null;
    document.getElementById('originador').value = null;
    document.getElementById('CurrentID').value = null;
    document.getElementById('bonificacion').value = null;
    document.getElementById('PctOrig').value = null;
    document.getElementById('PctImp').value = null;
    document.getElementById('LabelOriginador').innerHTML = null;
    document.getElementById("btnFile").disabled = true;
    document.getElementById("btnAprobar").removeEventListener("click", ShowFilterSelect);
    document.getElementById("btnAprobarImp").removeEventListener("click", ShowFilterSelectImp);
    document.getElementById("btnRedirect").removeEventListener("click", ShowRedirect);
    document.getElementById("btnRechazar").removeEventListener("click", ShowCancel);

    
}

function show_suggestion(id) {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetAdminSugID",
        data: "{'ID':'" + id + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            result = responseFromServer.d;
            if (result != null) {
                document.getElementById('folio').innerHTML = result[0];
                document.getElementById('origen').innerHTML = result[1];
                document.getElementById('originador').innerHTML = result[18];
                document.getElementById('LabelOriginador').innerHTML = result[18];
                document.getElementById('correo').value = result[3];
                document.getElementById('enfoque').innerHTML = result[5];
                document.getElementById('planta').innerHTML = result[6];
                document.getElementById('area').innerHTML = result[7];
                document.getElementById('estacion').innerHTML = result[9];
                document.getElementById('seccion').innerHTML = result[8];
                document.getElementById('dept').innerHTML = result[10];
                document.getElementById('redcosto').value = result[12];
                document.getElementById('problema').innerHTML = result[13];
                document.getElementById('propuesta').innerHTML = result[14];
                document.getElementById('mejoras').innerHTML = result[15];
                document.getElementById('estado').innerHTML = result[16];
                document.getElementById('implementador').value = result[17];
                document.getElementById('originador').value = result[18];
                document.getElementById('bonificacion').value = result[19];
                document.getElementById('CurrentID').value = id;
                document.getElementById('PctOrig').value = (result[19] / 100) * document.getElementById('BonoOrig').value;
                document.getElementById('PctImp').value = (result[19] / 100) * document.getElementById('BonoImp').value;
                document.getElementById('btnFile').disabled = false;
                document.getElementById("btnAprobar").addEventListener("click", ShowFilterSelect);
                document.getElementById("btnAprobarImp").addEventListener("click", ShowFilterSelectImp);
                document.getElementById("btnRedirect").addEventListener("click", ShowRedirect);
                document.getElementById("btnRechazar").addEventListener("click", ShowCancel);
                if (result[16] == 'Implemented') { document.getElementById('BtnEvidencia').style.display = 'block'; }
                else {
                    document.getElementById('BtnEvidencia').style.display = 'none';
                }
            }

        }       
    });


}

function Option_Changed() {
    var option = document.getElementById('tipo').value;

    //cambios en pantalla
    if (option == 'Nuevas Ideas') {
        document.getElementById('btnRedirect').style.display = "block";
        document.getElementById('btnRechazar').style.display = "block";
        document.getElementById('div-IdeasImplementadas').style.display = "none";
        document.getElementById('btnAprobarImp').style.display = "none";
        document.getElementById('btnAprobar').style.display = "block";
    }
    else if (option == 'Ideas Implementadas') {
        document.getElementById('btnRedirect').style.display = "none";
        document.getElementById('btnRechazar').style.display = "none";
        document.getElementById('div-IdeasImplementadas').style.display = "flex";
        document.getElementById('btnAprobarImp').style.display = "block";
        document.getElementById('btnAprobar').style.display = "none";
    }
    reset();
    GetData();
}

function ScrollChanged(IdSelected, IdNotSelected) {
    var scroll = document.getElementById(IdSelected).value;
    document.getElementById(IdNotSelected).value = 100 - scroll;
    var premio = document.getElementById('bonificacion').value;
    document.getElementById('PctOrig').value = premio * document.getElementById('BonoOrig').value / 100;
    document.getElementById('PctImp').value = premio * document.getElementById('BonoImp').value / 100;
}

function ShowFilterSelect() {
    var id = document.getElementById('CurrentID').value;
    $('#filtros').modal('show');
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetInfoAreaAdmin",
        data: "{'ID':'" + id + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            if (result != null) {
                for (var i = 0; i < result.length; i++) {
                    $('#AreaFiltro').append("<option>" + result[i] + "</option>");
                }
                GetFilters();
            }
        }
    });
}

function GetFilters() {
    var Area = document.getElementById('AreaFiltro').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetFiltersAreaAdmin",
        data: "{'Dept':'" + Area + "', 'DeptResp': '" + sessionStorage["dept"] + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            result = responseFromServer.d;
            $('#FiltroDept').empty();
            if (result != null) {
                for (var i = 0; i < result.length; i++) {
                    $('#FiltroDept').append("<option>" + result[i] + "</option>");
                }
            }
        }
    });
}

function Aceptar() {
    var id = document.getElementById('CurrentID').value;
    var Area = document.getElementById('AreaFiltro').value;
    var Filtro = document.getElementById('FiltroDept').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/AcceptSuggestion",
        data: "{'Area':'" + Area + "', 'TeamLeader': '" + Filtro + "', 'ID':'" + id + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            if (responseFromServer.d) {
                $.alert({
                    title: 'Sugerencia Aceptada',
                    content: 'La sugerencia ha sido Aceptada correctamente',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }
        }
    });
    $('#filtros').modal('hide');
    SendAprovMail();
    GetData();
    reset();
}

function SendAprovMail()
{
    var Email = document.getElementById('correo').value;
    if(Email != null && Email !='')
    {
        //Aproval Mail Method

        var id = document.getElementById('CurrentID').value;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/SendAprobMail",
            data: "{'MailAddress':'" + Email + "', 'ID': '" + id + "', 'Name':'" + sessionStorage["nombre"] + "', 'Option': 1}",
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

function Redirect()
{
    var id = document.getElementById('CurrentID').value;
    var Area = document.getElementById('AreaRed').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/RedirectSuggesstion",
        data: "{ 'ID':'" + id + "', 'AreaImp':'"+Area+"'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            if (responseFromServer.d) {
                $.alert({
                    title: 'Sugerencia Redireccionada',
                    content: 'Sugerencia redireccionada a Departamento '+Area,
                    type: 'blue',
                    columnClass: 'col-md-6 col-md-offset-3'
                });

            }
        }
    });
    $('#Redireccionar').modal('hide');
    GetData();
    reset();
}

function ShowRedirect()
{
    $('#Redireccionar').modal('show');
    //ajax para llenar el area de redireecion
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_department",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            if (result != null) {
                for (var i = 0; i < result.length; i++)
                { $('#AreaRed').append("<option id='" + result[i] + "'>" + result[i] + "</option>"); }
                
            }
        }
    });
}

function ShowCancel()
{
    document.getElementById('rechazo').value = "";
    $('#Rechazar').modal('show');
}

function Rechazo()
{
    var id = document.getElementById('CurrentID').value;
    var Razon = document.getElementById('rechazo').value;
    console.log(id, Razon);
    $.ajax({
        type: "POST",
        url: "WebService.asmx/RejectSuggestion",
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
            catch(ex){}
            
        }
    });
    $('#Rechazar').modal('hide');
    SendRejectMail();
    GetData();
    reset();
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
            data: "{'MailAddress':'" + Email + "', 'ID': '" + id + "', 'Name':'" + sessionStorage["nombre"] + "','Reason':'"+Reason+"', 'Option': 1}",
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

function AceptImp() {
    var DinOrig = document.getElementById('PctOrig').value;
    var DinImp = document.getElementById('PctImp').value;
    var PctOrig = document.getElementById('BonoOrig').value / 100;
    var PctImp = document.getElementById('BonoImp').value / 100;
    var id = document.getElementById('CurrentID').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/InsertBenefit",
        data: "{'PctOrig':" + PctOrig + ", 'PctImp':" + PctImp + ", 'ID':'" + id + "'}",
        async: false,
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            if (responseFromServer.d) {
                $.alert({
                    title: 'Sugerencia Cerrada',
                    content: 'Sugerencia cerrada Correctamente',
                    type: 'blue',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }

        }
    });
    SendAprovImpMail();
    reset();
    GetData();

}

function SendAprovImpMail()
{
    var Email = document.getElementById('correo').value;
    if (Email != null && Email != '') {
        //Aproval Mail Method

        var id = document.getElementById('CurrentID').value;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/SendAprobMail",
            data: "{'MailAddress':'" + Email + "', 'ID': '" + id + "', 'Name':'" + sessionStorage["nombre"] + "', 'Option': 3}",
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

function EvidenciaImp()
{
    if (document.getElementById('folio').innerHTML != "" && document.getElementById('folio').innerHTML != null)
    {
        sessionStorage["EstadoImp"] = 'Implemented';
        sessionStorage["Page"] = 'AdminArea.aspx';
        sessionStorage["FolioImp"] = document.getElementById('folio').innerHTML;
        window.location.href = 'EvidenciaImp.aspx';
    }
}

function ShowFilterSelectImp() {
    $.confirm({
        title: 'Bonificación',
        type: 'orange',
        content: "¿Está seguro de que la bonificación es correcta tanto para Originador como para Implementador?",
        columnClass: 'col-md-6 col-md-offset-3',
        buttons: {
            confirm: function () {
                AceptImp();
            },
            cancel: function () {

            }
        }
    });
}