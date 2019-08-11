var query="";
var plant = "";
var focus = "";
var area = "";
var dept = "";
var status = "";
var depResp = "";
var filtro = "";
var originador = "";
var implementador = "";
var ahorro = "";
$(document).ready(function () {
    TodayDate('desde');
    TodayDate('hasta');
    GetMethod('get_plant', '#planta'); //getplant
    GetMethod('get_focus', '#enfoque'); //getfocus
    GetMethod('get_area', '#area'); //getarea
    GetMethod('get_status', '#estado'); //getstatus
    GetMethod('get_dept_originador', '#depto'); //getdeptorig
    GetMethod('get_department', '#departamento'); //getdeptoresp
    GetMethod('get_implementer', '#implementador'); //getImp
    GetMethod('get_filtroDept', '#filtro-dept'); //getfiltrodept
    GetNames();
    get_info();
});



function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}


function GetNames()
{
    var size = 0;
    var temp = '';
    var split;
    do
    {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/get_names",
            data:"{'Name':'"+temp+"'}",
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer)
            {
                try
                {
                    var result = responseFromServer.d;
                    if(result != null)
                    {
                        console.log(result);
                        size = result.length;
                        for (var i = 0; i < result.length; i++)
                        { $('#originador').append("<option id = '" + result[i] + "'>" + result[i] + "</option>"); }

                        if(size > 999)
                        { temp = result[999]; }
                    }
                }
                catch (ex) { }
            }

        });

    } while (size > 999);
}

function GetMethod(fun, id)
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/"+fun,
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            for (var i = 0; i < result.length; i++) {
                $(id).append("<option id = '" + result[i] + "'>" + result[i] + "</option>");
            }  
        }
    });
}

function check_changed(id_check, id_combo, OptionCheckBox) {
    if (document.getElementById(id_check).checked == true)//cambio el estado a check
    {
        switch (OptionCheckBox) {
            case 1: //plant
                plant = " AND Planta = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 2: //focus
                focus = " AND Enfoque = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 3:
                area = " AND Categoria = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 4:
                status = " AND Estado = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 5:
                dept = " AND AreaOriginador = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 6:
                originador = "AND Originador = (SELECT BadgeNumber FROM Employees WHERE NAME = '" + document.getElementById(id_combo).value + "') ";
                break;
            case 7:
                depResp = " AND AreaImplementadora = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 8:
                implementador = " AND Implementador = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 9:
                filtro = " AND TeamLeader = '" + document.getElementById(id_combo).value + "' ";
                break;
            case 10:
                ahorro = " AND CostoReducido > 0.00"
                break;
        }
        document.getElementById(id_combo).disabled = false;
    }
    else // check no aplica
    {
        switch (OptionCheckBox) {
            case 1: //plant
                plant = "";
                break;
            case 2: //focus
                focus = "";
                break;
            case 3:
                area = "";
                break;
            case 4:
                status = "";
                break;
            case 5:
                dept = "";
                break;
            case 6:
                originador = "";
                break;
            case 7:
                depResp = "";
                break;
            case 8:
                implementador = "";
                break;
            case 9:
                filtro = "";
                break;
            case 10:
                ahorro = "";
                break;
        }
        document.getElementById(id_combo).disabled = true;
    }
    get_info();
}

function select_changed(OptionSelect, id_combo)
{
    switch (OptionSelect)
    {
        case 1: //plant
            plant = " AND Planta = '" + document.getElementById(id_combo).value + "' ";
            break;
        case 2: //focus
            focus = " AND Enfoque = '" + document.getElementById(id_combo).value + "' ";
            break;
        case 3:
            area = " AND Categoria = '" + document.getElementById(id_combo).value + "' ";
            break;
        case 4:
            status = " AND Estado = '" + document.getElementById(id_combo).value + "' "; 
            break;
        case 5:
            dept = " AND AreaOriginador = '" + document.getElementById(id_combo).value + "' ";
            break;
        case 6:
            originador = "AND Originador = (SELECT BadgeNumber FROM Employees WHERE NAME = '" + document.getElementById(id_combo).value + "') ";
            break;
        case 7:
            depResp = " AND AreaImplementadora = '" + document.getElementById(id_combo).value + "' ";
            break;
        case 8:
            implementador = " AND Implementador = '" + document.getElementById(id_combo).value + "' ";
            break;
        case 9:
            filtro = " AND TeamLeader = '" + document.getElementById(id_combo).value + "' ";
            break;
    }
    get_info();
}

function get_info() // hacer que  entre al web service las veces necesarias hasta que se consuman todos los recursos
{


    var desde = document.getElementById('desde').value;
    var hasta = document.getElementById('hasta').value;
    var size = 0;
    var temp = 0;
    var query = plant + focus + status + area + dept + depResp + filtro + originador + implementador + ahorro;

    $('#tbl_benefits').empty();
    do
    {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/GetSuggestions",
            data: JSON.stringify({begin:desde, end:hasta, Query:query, temp_id: temp}),            
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer) {
                try
                {
                    var result = responseFromServer.d;
                    if (result.length>0)
                    {                        
                        size = result.length;
                        for (var i = 0; i < size; i++)
                        { $('#tbl_benefits').append("<tr><td>" + result[i][0] + "</td><td>" + result[i][1] + "</td><td>" + result[i][2] + "</td><td>" + result[i][3] + "</td><td>" + result[i][4] + "</td><td>" + result[i][5] + "</td><td>" + result[i][6] + "</td><td>" + result[i][7] + "</td><td>" + result[i][8] + "</td><td>" + result[i][9] + "</td><td>" + result[i][10] + "</td><td>" + result[i][11] + "</td><td>" + result[i][12] + "</td><td>" + result[i][13] + "</td><td>" + result[i][14] + "</td><td>" + result[i][15] + "</td><td>" + result[i][16] + "</td></tr>"); }
                        if (size > 99) { temp = result[99][0]; }
                    }
                    else
                    {

                    }
                }
                catch (ex) { }
            }
        });
    } while (size > 99);

}

function sendReport() {

    var Correo = document.getElementById('correo').value;
    var temp = Correo.split('@');
    if (temp[1].toLowerCase() == 'us.bosch.com')
    {
        var desde = document.getElementById('desde').value;
        var hasta = document.getElementById('hasta').value;
        var query = plant + focus + status + area + dept + depResp + filtro + originador + implementador + ahorro;

        $.ajax({
            type: "POST",
            url: "WebService.asmx/Open_filtered_excel",
            data: JSON.stringify({ begin: desde, end: hasta, Query: query, Email: Correo }),
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer) {
                if (responseFromServer.d == 'Success')
                {
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

