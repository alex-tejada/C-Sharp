$(document).ready(function () {
        document.getElementById("user").innerHTML = sessionStorage["nombre"];
        document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
        document.getElementById("basociado").value = sessionStorage["nombre"];
});

function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}

function ShowBeneficios()
{
    TodayDate('Fecha_inicio');
    TodayDate('Fecha_fin');
    $('#beneficios').modal('show');
    beneficios();
}

function beneficios()
{
    var inicio = document.getElementById("Fecha_inicio").value.toString();
    var fin = document.getElementById("Fecha_fin").value.toString();

    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_benefits",
        data: JSON.stringify({ fechaDesde: inicio, fechaHasta: fin, NoReloj: sessionStorage['NoEmp']}),
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            document.getElementById("btotal").value = result;
        }
    });
}