$(document).ready(function () {
    TodayDate('inicio');
    TodayDate('fin');
    GetGeneralReport();
    GetBIXReport();
    GetInRevisionReport();
    GetPendMore60();
    GetPenLess60();
    document.getElementById('loading').style.display = 'none';
});

/*Estadisticas Gen Methods*/
function GetGeneralReport() {
    var inicio = document.getElementById('inicio').value;
    var end = document.getElementById('fin').value;

    $.ajax({
        type: "POST",
        url: "WebService.asmx/GeneralReport",
        data: "{'Begin':'" + inicio + "', 'End':'" + end + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            document.getElementById('SugCap').innerHTML = result[0];
            document.getElementById('PromAsoc').innerHTML = result[1];
            document.getElementById('Participantes').innerHTML = result[2];
            document.getElementById('Aceptadas').innerHTML = result[3];
            document.getElementById('Cerradas').innerHTML = result[4];
            document.getElementById('Porcentaje').innerHTML = result[5];
            document.getElementById('ReduccionMesUS').innerHTML = result[6];
            document.getElementById('ReduccionAnUS').innerHTML = result[7];
            document.getElementById('ReduccionAnEU').innerHTML = result[8];
            document.getElementById('PromedioCierre').innerHTML = result[9];
            document.getElementById('bix').innerHTML = result[10];
        }
    });

    GetDeptReport();
}

function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}

function GetDeptReport()
{
    $('#DeptRep').empty();
    var inicio = document.getElementById('inicio').value;
    var fin = document.getElementById('fin').value;
    console.log(inicio, fin);
    $.ajax({
        type: "POST",
        url: "WebService.asmx/DeptReport",
        data: "{'Begin':'" + inicio + "', 'End':'" + fin + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            if(result.length>0)
            {
                console.log(result);
                for(var i = 0; i<result.length; i++)
                {
                    $('#DeptRep').append("<tr><td>" + result[i][0] + "</td><td onclick=\"Details('1', '" + result[i][0] + "')\">" + result[i][1] + "</td><td onclick=\"Details('2', '" + result[i][0] + "')\">" + result[i][2] + "</td><td onclick=\"Details('3', '" + result[i][0] + "')\">" + result[i][3] + "</td><td onclick=\"Details('4', '" + result[i][0] + "')\">" + result[i][4] + "</td><td onclick=\"Details('5', '" + result[i][0] + "')\">" + result[i][5] + "</td><td onclick=\"Details('6', '" + result[i][0] + "')\">" + result[i][6] + "</td><td onclick=\"Details('7', '" + result[i][0] + "')\">" + result[i][7] + "</td><td onclick=\"Details('8', '" + result[i][0] + "')\">" + result[i][8] + "</td><td>" + result[i][9] + "</td><td>" + result[i][10] + "</td><td>" + result[i][11] + "</td><td>" + result[i][12] + "</td><td>" + result[i][13] + "</td><td>" + result[i][14] + "</td><td>" + result[i][15] + "</td><td>" + result[i][16] + "</td></tr>");
                }
            }
        }
    });
}

function GetBIXReport()
{
    var inicio = document.getElementById('inicio').value;
    var end = document.getElementById('fin').value;
    $('#tbl_pendientes').empty();

    $.ajax({
        type: "POST",
        url: "WebService.asmx/ReportBIXDept",
        data: "{'Begin':'" + inicio + "', 'End':'" + end + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            try
            {
                if(result.length>0)
                {
                    for(var i = 0; i <result.length;i++)
                    {
                        $('#tbl_pendientes').append("<tr><td>"+result[i][0]+"</td><td>"+result[i][1]+"</td></tr>");
                    }
                }
            }
            catch (ex) {
                console.log(ex.message);
            }
        }
    });
}

function GetInRevisionReport()
{
    $('#tbl_revision').empty();

    $.ajax({
        type: "POST",
        url: "WebService.asmx/ReportInRevision",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            try {
                if (result.length > 0) {
                    for (var i = 0; i < result.length; i++) {
                        $('#tbl_revision').append("<tr><td>" + result[i][0] + "</td><td onclick=\"Details('9', '" + result[i][0] + "')\">" + result[i][1] + "</td></tr>");
                    }
                }
            }
            catch (ex) {
                console.log(ex.message);
            }
        }
    });
}

function GetPendMore60()
{
    $('#tbl_revisar').empty();

    $.ajax({
        type: "POST",
        url: "WebService.asmx/ReportPendMay60",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            try {
                if (result.length > 0) {
                    for (var i = 0; i < result.length; i++) {
                        $('#tbl_revisar').append("<tr><td>" + result[i][0] + "</td><td onclick=\"Details('10', '" + result[i][0] + "')\">" + result[i][1] + "</td></tr>");
                    }
                }
            }
            catch (ex) {
                console.log(ex.message);
            }
        }
    });
}

function GetPenLess60()
{
    $('#tbl_revisar2').empty();

    $.ajax({
        type: "POST",
        url: "WebService.asmx/ReportPendMen60",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            try {
                if (result.length > 0) {
                    for (var i = 0; i < result.length; i++) {
                        $('#tbl_revisar2').append("<tr><td>" + result[i][0] + "</td><td onclick=\"Details('11', '" + result[i][0] + "')\">" + result[i][1] + "</td></tr>");
                    }
                }
            }
            catch (ex) {
                console.log(ex.message);
            }
        }
    });
}

/*Events*/

function Update() {
    document.getElementById('loading').style.display = 'block';
    GetGeneralReport();
    GetBIXReport();
    GetInRevisionReport();
    GetPendMore60();
    GetPenLess60();
    document.getElementById('loading').style.display = 'none';
}

function Option_Changed() {
    var op = document.getElementById('tipo').value;
    if (op == 'Pagina 1') {
        document.getElementById('Page1').style.display = 'block';
        document.getElementById('Page2').style.display = 'none';
    }
    else {
        document.getElementById('Page1').style.display = 'none';
        document.getElementById('Page2').style.display = 'block';
    }
}

function Details(option, dept) {
    var inicio = document.getElementById('inicio').value;
    var fin = document.getElementById('fin').value;

    var Title = '';
    switch (option) {
        case '1':
            Title = 'Sugerencias Capturadas';
            break;
        case '2':
            Title = 'Ideas Aceptadas';
            break;
        case '3':
            Title = 'Ideas Recibidas de Otros Deptos';
            break;
        case '4':
            Title = 'Ideas Recibidas del Mismo Depto';
            break;
        case '5':
            Title = 'New Ideas';
            break;
        case '6':
            Title = 'En Revisión';
            break;
        case '7':
            Title = 'En Processo de Implementación';
            break;
        case '8':
            Title = 'Implementadas';
            break;
        case '9':
            Title = 'En Revisión';
            break;
        case '10':
            Title = 'En Revisión / En Proceso > 30 Días';
            break;
        case '11':
            Title = 'En Revisión / En Proceso <= 30 Días';
            break;
    }

    $.ajax({
        type: "POST",
        url: "WebService.asmx/FilteredReport",
        data: "{'Begin':'" + inicio + "', 'End':'" + fin + "', 'Dept':'" + dept + "', 'Option':'" + option + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            $('#tbl_details').empty();
            document.getElementById('FilterTitle').innerHTML = Title + ' - ' + dept;
            if (result != null) {
                for (var i = 0; i < result.length; i++) {
                    var temp = result[i].split(',');
                    $('#tbl_details').append("<tr><td>" + temp[0] + "</td><td>" + temp[1] + "</td><td>" + temp[2] + "</td></tr>");
                }

            }
        }
    });
    $('#FlitroReporte').modal('show');
    //la opcion la puedo usar para el query que quiero ejecutar y el departamento es para filtrar por ese departamento
}