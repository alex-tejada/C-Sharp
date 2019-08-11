$(document).ready(function () {
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
    get_suggestions();  
});

function show_suggestion(id)
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_suggestion_id",
        data: "{'id':'" + id.toString() + "'}",
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer)
        {
            var info = responseFromServer.d;
            for (var i = 0; i < 16; i++) { if (info[i] == null) { info[i] = ""; } }
            var info = responseFromServer.d;
            document.getElementById('enfoque').innerHTML = info[3];
            document.getElementById('area').innerHTML = info[6];
            document.getElementById('planta').innerHTML = info[4];
            document.getElementById('estacion').innerHTML = info[7];
            document.getElementById('idsug').innerHTML = id;
            document.getElementById('statsug').innerHTML = info[14];
            document.getElementById('seccion').innerHTML = info[5];
            document.getElementById('dept').innerHTML = info[8];
            document.getElementById('redcosto').value = info[10];
            document.getElementById('correo').value = info[2];
            document.getElementById('problema').innerHTML = info[11];
            document.getElementById('propuesta').innerHTML = info[12];
            document.getElementById('mejoras').innerHTML = info[13];
            document.getElementById('CurrentID').value = id;
            document.getElementById('btnFile').disabled = false;
            if (info[14] == 'Implemented' || info[14] == 'Closed') { document.getElementById('EvidenciaImp').style.display = 'block'; }
            else { document.getElementById('EvidenciaImp').style.display = 'none'; }

        }
    });
}

function GetHist()
{
    $('#HistSug').modal('show');
    var id = document.getElementById('CurrentID').value;
    $.ajax({
    type: "POST",
    url: "WebService.asmx/SugHist",
    data: "{'ID': '"+id+"'}",
    contentType: "application/json",
    datatype: "json",
    success: function (responseFromServer) {
        try {
            $('#tbl_sughist').empty();
            var result = responseFromServer.d;
            if (result != null) {
                for (var i = 0; i < result.length; i++) {
                    $('#tbl_sughist').append('<tr class="tr"><td>' + result[i][0] + '</td><td>' + result[i][1] + '</td><td>' + result[i][2] + '</td><td>'+result[i][2]+'</td></tr>');
                }

            }
        }
        catch (ex) {
        }

    }
});
}

function get_suggestions() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_suggestions",
        contentType: "application/json",
        data: "{'Originator':'" + sessionStorage["NoEmp"] + "'}",
        datatype: "json",
        success: function (responseFromServer) {
            var info = responseFromServer.d;
            for (var i = 0; i < info.length; i++) {
                var temp = info[i].split(",");
                $("#info_sugerencias").append("<tr class='tr' onclick='show_suggestion(\"" + temp[0] + "\")'><td scope='row'>" + temp[0] + "</td><td>" + temp[1] + "</td><td>" + temp[2] + "</td></tr>");
            }
        }
    });
}


function EvidenciaImp() {
    if (document.getElementById('CurrentID').value != "" && document.getElementById('CurrentID').value != null) {
        sessionStorage["EstadoImp"] = 'Implemented';
        sessionStorage["Page"] = 'MisSug.aspx';
        sessionStorage["FolioImp"] = document.getElementById('CurrentID').value;
        window.location.href = 'EvidenciaImp.aspx';
    }
}