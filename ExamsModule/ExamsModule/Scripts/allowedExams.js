
var dataArray = [];

$(document).ready(function ()
{
    var username = sessionStorage["usuario"];
    getAllowedExams(username);
});
function getAllowedExams(username)
{
    $.ajax({
        url: "WebService.asmx/getAllowedExams",
        data: "{ 'username':'" +username+ "'}",
        type: "post",
        contentType: "application/json",
        async: true,
        success: function (response)
        {
            if (!(response.d == "2"))
            {
                setDataToTable(response.d);
            }
            else
            {
                $("#tableBody").html("");
            }
        },
        error: function (result) {
            debugger;
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function setOpenExamParams(id)
{
    sessionStorage["id_examen"] = dataArray[id].id;
    sessionStorage["usuarioProfesor"] = dataArray[id].manager;
}
function setDataToTable(JSONstring)
{
    var JSONarray = JSON.parse(JSONstring);
    dataArray = JSONarray;
    $("#tableBody").html("");
    for (var i = 0; i < JSONarray.length; i++)
    {
        var idCol = "<th scope='col' id='index'>" + (i + 1) + "</th>";
        var titleCol = "<td> " + JSONarray[i].title + "</td>";
        var areaCol = "<td>" + getAreaName(JSONarray[i].area) + "</td>";
        var langCol = "<td>" + JSONarray[i].language + "</td>";
        var managerCol = "<td>" + JSONarray[i].manager + "</td>";
        var button = "<td><button type='button' class='btn-sm btn-success' style='float:right'  data-toggle='modal' data-target='#modalOpenExam' onclick='setOpenExamParams(" + i +")'><img src='Resources/begin.png' alt='begin' title='begin'/></button></td>";
        var row = "<tr class='text-center'>" + idCol + titleCol + areaCol + langCol + managerCol + button +" <tr>";
        $("#tableBody").append(row);
    }
}
function openExam()
{
    if (sessionStorage["id_examen"] != null & sessionStorage["usuario"] != null & sessionStorage["usuarioProfesor"]!= null)
    {
        window.open("CheckExam.aspx");
        location.reload();
    }
}
function getAreaName(code)
{
    code = parseInt(code);
    switch (code)
    {
        case 1:
            return "Quality Management";
            break;
        case 2:
            return "Production";
            break;
        case 3:
            return "Warehouse";
            break;
        case 4:
            return "Packaging";
            break;
        case 5:
            return "Samples To Customer";
            break;
        case 6:
            return "Logistics";
            break;
        case 7:
            return "Shipping";
            break;
        case 8:
            return "Purchasing";
            break;
        case 9:
            return "Controlling";
            break;
        case 10:
            return "Investments Machine and Equipment";
            break;
        case 11:
            return "Plant Maintenance";
            break;
        case 12:
            return "Product Data Management";
            break;
        default:
            return "NA";
            break;
    }
}
function returnMenu() {
    window.location.replace("menuCeap.aspx");
}