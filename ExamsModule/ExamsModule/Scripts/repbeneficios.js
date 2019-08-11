$(document).ready(function () {
    if (sessionStorage["nivel"] < "C")
    { window.location.href = "menu.aspx"; }
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
    TodayDate('desde');
    TodayDate('hasta');
    get_all_benefits
});

function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}

function get_all_benefits()
{
    var fecha_inicio = document.getElementById('desde').value;
    var fecha_fin = document.getElementById('hasta').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_benefit_report",
        data: JSON.stringify({ begin: fecha_inicio, end: fecha_fin}),
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            try
            {
                $('#tbl_benefits').empty();
                var result = responseFromServer.d;
                if (result != null)
                {
                    for(var i = 0;i<result.length;i++)
                    {
                        var temp = result[i].split('-');
                        $('#tbl_benefits').append('<tr><td>'+temp[0]+'</td><td>'+temp[1]+'</td><td>'+temp[2]+'</td><td>'+temp[3]+'</td></tr>');
                    }
                }
            }
            catch(ex)
            {

            }
        }
    });
}

function sendReport() {


    var Correo = document.getElementById('correo').value;
    var temp = Correo.split('@');
    if (temp[1].toLowerCase() == 'us.bosch.com')
    {
        var fecha_desde = document.getElementById('desde').value;
        var fecha_hasta = document.getElementById('hasta').value;
        $.ajax({
            type: "POST",
            url: "WebService.asmx/Open_report_excel",
            data: "{'begin': '" + fecha_desde + "' , 'end': '" + fecha_hasta + "', 'Email':'" + Correo + "'}",
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer) {
                if (responseFromServer.d == 'Success') {
                    $.alert({
                        title: 'REPORTE',
                        content: 'Reporte Enviado',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
                else
                {
                    console.log(responseFromServer.d);
                }
            }
        });
        $('#EmailModal').modal('hide');
    }
    else
    {
        $.alert({
            title: 'REPORTE',
            type: 'orange',
            content: 'El correo ingresado no es una cuenta de correo Bosch, por favor ingrese una Cuenta de Correo Bosch',
            columnClass: 'col-md-6 col-md-offset-3'
        });
    }

}

function get_excel()
{

    document.getElementById('correo').value = '';
    $('#EmailModal').modal('show');



}


