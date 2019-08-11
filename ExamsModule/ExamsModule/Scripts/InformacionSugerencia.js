$(document).ready(function () {
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
    get_suggestions();

});

function SuggestionInfoId() {
    var id = document.getElementById('IdSug').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetSugId",
        data: "{'Id':'" + id.toString() + "'}",
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            document.getElementById('enfoque').innerHTML = result[0];
            document.getElementById('planta').innerHTML = result[1];
            document.getElementById('area').innerHTML = result[2];
            document.getElementById('estacion').innerHTML = result[3];
            document.getElementById('seccion').innerHTML = result[4];
            document.getElementById('dept').innerHTML = result[5];
            document.getElementById('redcosto').value = result[6];
            document.getElementById('correo').value = result[7];
            document.getElementById('problema').innerHTML = result[8];
            document.getElementById('propuesta').innerHTML = result[9];
            document.getElementById('mejoras').innerHTML = result[10];
            document.getElementById('statsug').innerHTML = result[11];
            document.getElementById('teamleader').innerHTML = result[12];
            document.getElementById('implementador').innerHTML = result[13];
            document.getElementById('originador').innerHTML = result[14];
            if (result[11] == 'Implemented' || result[11] == 'Closed') { document.getElementById('EvidenciaImp').style.display = 'block'; }
            else { document.getElementById('EvidenciaImp').style.display = 'none'; }
            if (result[15] != null && result[15] != '') { document.getElementById('btnFile').disabled = false; document.getElementById('CurrentID').value = result[15]; }
            else { document.getElementById('btnFile').disabled = true; document.getElementById('CurrentID').value = ''; }
        }
    });
}

function isNumber(evt) {
    var codigo = (evt.which) ? evt.which : event.keyCode;
    if ((codigo > 47 && codigo < 58) || (codigo == 46 || codigo == 8)) { return true; }

    return false;
}


function EvidenciaImp() {
    if (document.getElementById('CurrentID').value != "" && document.getElementById('CurrentID').value != null) {
        sessionStorage["EstadoImp"] = 'Implemented';
        sessionStorage["Page"] = 'InformacionSugerencia.aspx';
        sessionStorage["FolioImp"] = document.getElementById('CurrentID').value;
        window.location.href = 'EvidenciaImp.aspx';
    }
}