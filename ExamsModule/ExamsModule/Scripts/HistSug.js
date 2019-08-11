$(document).ready(function () {
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
    TodayDate('desde');
    TodayDate('hasta');
});

function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}

function check_states()
{
    var no_reloj = document.getElementById('noemp').value;
    var fecha_desde = document.getElementById('desde').value;
    var fecha_hasta = document.getElementById('hasta').value;
    if (no_reloj.length == 8) {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/filter_info",
            data: "{'badgeNo': '" + no_reloj + "','begin':'" + fecha_desde + "','end':'" + fecha_hasta + "'}",
            contentType: "application/json",
            datatype: "json",
            success: function (responseFromServer) {
                var temp = responseFromServer.d;
                console.log(temp);
                if (temp[0] > 0) {
                    document.getElementById('desde').disabled = false;
                    document.getElementById('hasta').disabled = false;
                    document.getElementById('NewIdea').innerHTML = temp[1];
                    document.getElementById('InRevision').innerHTML = temp[2];
                    document.getElementById('InProcess').innerHTML = temp[3];
                    document.getElementById('Implemented').innerHTML = temp[4];
                    document.getElementById('Total').innerHTML = temp[5];
                }
                else {
                    document.getElementById('desde').disabled = true;
                    document.getElementById('hasta').disabled = true;
                }
            }
        });
    }
    else {
        document.getElementById('desde').disabled = true;
        document.getElementById('hasta').disabled = true;
        document.getElementById('NewIdea').innerHTML = "0";
        document.getElementById('InRevision').innerHTML = "0";
        document.getElementById('InProcess').innerHTML = "0";
        document.getElementById('Implemented').innerHTML = "0";
        document.getElementById('Total').innerHTML = "0";
    }
}