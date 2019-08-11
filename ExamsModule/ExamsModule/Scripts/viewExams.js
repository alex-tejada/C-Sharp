
var dataArray = [];
var examIDForAuth = -1;

$(document).ready(function ()
{
    var username = sessionStorage["usuario"];
    getExamsData(username);
});
function getExamsData(username)
{
    $.ajax({
        url: "WebService.asmx/getExamsData",
        data: "{ 'username':'" + username + "'}",
        type: "POST",
        contentType: "application/json",
        success: function (response)
        {
            if (response.d == "2" | response.d == "")
            {
                $("#tableBody").html("");
            }
            else
            {
                setDataToTable(response.d);
            }
        },
        error: function (result)
        {
            console.log(result.status + ' ' + result.statusText + ' ' + result.error);
        }
    });
}
function addDeleteFunction(id)
{
    $("#deleteAcceptButton").off('click');  
    $("#deleteAcceptButton").prop('onclick', null);
    $("#deleteAcceptButton").on('click', {id:id}, requestDelete);
}
function requestDelete(event)
{
    $("#deleteAcceptButton").attr("disabled", "disabled");
    var examID = dataArray[event.data.id].id;
    var examPath = dataArray[event.data.id].path;
    var username = sessionStorage["usuario"];
    $.ajax({
        url: "WebService.asmx/requestDeleteExam",
        data: "{ 'id': '"+examID+"', 'username': '"+username+"', 'path': '"+examPath+"' }",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response)
        {
            if (response.d == "1")
            {
                $('#deleteExamModal').modal('hide')
                $("#deleteAcceptButton").removeAttr("disabled");
                getExamsData(username);
            }
            else
            {
                
            }
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function addEditFunction(id)
{
    $("#editAcceptButton").off('click');  
    $("#editAcceptButton").prop('onclick', null);
    $("#editAcceptButton").on('click', { id: id }, setEditParamters);
}
function setEditParamters(event)
{
    var examID = dataArray[event.data.id].id;
    sessionStorage["id_examen"] = examID;
    window.open("EditExam.aspx");
    $('#editExamModal').modal('hide')
}
function openNewExamCreation()
{
    window.open("NewExam.aspx");
    $('#newExamModal').modal('hide')
}
function setPreviewParamters(id)
{
    var examID = dataArray[id].id;
    sessionStorage["id_examen"] = examID;
    window.open("PreviewExam.aspx");
}
function setAuthParams(id)
{
    var examID = dataArray[id].id;
    sessionStorage["id_examen"] = examID;
    requestUsers(dataArray[id].id, 0);
    requestUsers(dataArray[id].id, 1);
}
function setDataToTable(JSONstring)
{
    var JSONarray = JSON.parse(JSONstring);
    dataArray = JSONarray;
    $("#tableBody").html("");
    for (var i = 0; i < JSONarray.length; i++)
    {
        var idCol = "<th scope='col' id='index'>" + (i+1)+ "</th>";
        var titleCol = "<td style='max-width:220px;padding-left:10px;'><div  class='set-overflow-x'> "+JSONarray[i].tittle+"</div></td>";
        var areaCol = "<td>" + getAreaName(JSONarray[i].area) + "</td>";
        var langCol = "<td>" + JSONarray[i].language + "</td>";
        var dateCol = "<td>" + JSONarray[i].date + "</td>";
        var buttonEdit = "<td style='margin:0 auto'> <button type='button' class='btn-sm btn-primary' style='float:right'  data-toggle='modal' data-target='#editExamModal' onclick='addEditFunction(" + i +")'><img src='Resources/edit.ico' alt='edit' title='Edit' /></button></td>";
        var buttonDel = "<td> <button type='button' class='btn-sm btn-danger' style='float:right'  data-toggle='modal' data-target='#deleteExamModal' onclick='addDeleteFunction(" + i +")'><img src='Resources/delete.png' alt='delete' title='Delete' /></button></td>";
        var buttonUser = "<td> <button type='button' class='btn-sm btn-success' style='float:right'  data-toggle='modal' data-target='#newUserExamModal' onclick='setAuthParams(" + i +")'><img src='Resources/user.png' alt='autorization' title='Autorization'/></button></td>";
        var buttonPreview = "<td> <button type='button' class='btn-sm btn-warning' style='float:right' onclick='setPreviewParamters("+i+")'><img src='Resources/preview.png' alt='preview' title='Preview' /></button></td>";
        var row = "<tr class='text-center'>" + idCol + titleCol + areaCol + langCol + dateCol + buttonPreview + buttonEdit + buttonUser + buttonDel +  " <tr>";
        $("#tableBody").append(row);
    }
}
function requestUsers(id, option)
{
    var url = "";
    if (option == 1)
    {
        url = "WebService.asmx/requestUsernamesAuthorized";
    }
    else
    {
        url = "WebService.asmx/requestUsernamesUnauthorized";
    }
    clearBody(option);
    $.ajax({
        url: url,
        data: "{ 'id':'" + id + "'}",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response)
        {
            if (!(response.d== 2))
            {
              setSearchResultsToTable(response.d,option);
            }
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function clearBody(option)
{
    if (option == 1)
    {
        $("#tableAuthorizedBody").html("");
    }
    else
    {
        $("#tableResultsBody").html("");
    }
}
function setSearchResultsToTable(JSONstring, option)
{
    var JSONarray = JSON.parse(JSONstring);
    $("#tableAuthorized").css("visibility", "visible");
    $("#tableResults").css("visibility", "visible");
    if (option == 1)
    {
        $("#tableAuthorizedBody").html("");
        for (var i = 0; i < JSONarray.length; i++)
        {
            var nameCol = "<td> " + JSONarray[i] + "</td>";
            var buttonAccept = "<td> <button type='button' id='buttonUnauth" + i +"' class='btn-sm btn-danger' style='float:right' onclick='requestUserDelAuth(\"" + JSONarray[i] + "\",this.id)'><img src='Resources/deleteuser.png' alt='unauthorize' title='Unauthorize' /></button></td>";
            var row = "<tr>" + nameCol + buttonAccept + " <tr>";
            $("#tableAuthorizedBody").append(row);
        }
    }
    else
    {
        $("#tableResultsBody").html("");
        for (var i = 0; i < JSONarray.length; i++)
        {
            var nameCol = "<td> " + JSONarray[i] + "</td>";
            var buttonAccept = "<td> <button type='button' id='buttonAuth"+i+"' class='btn-sm btn-primary' style='float:right' onclick='requestUserAuth(\"" + JSONarray[i] + "\",this.id)'><img src='Resources/user.png' alt='authorize' title='Authorize' /></button></td>";
            var row = "<tr>" + nameCol + buttonAccept + " <tr>";
            $("#tableResultsBody").append(row);
        }
    }
}
function requestUserAuth(usernameToAuthorize,buttonId)
{
    $("#" + buttonId).attr('disabled', 'disabled');
    var username = sessionStorage["usuario"];
    var id = sessionStorage["id_examen"];

    $.ajax({
        url: "WebService.asmx/requestUserAprobal",
        data: "{ 'id':'" + id + "', 'usernameToAuthorize':'" + usernameToAuthorize + "', 'username':'" + username + "'}",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
            requestUsers(id, 1);
            requestUsers(id, 0);
        },
        error: function (result)
        {
            $("#" + buttonId).removeAttr("disabled");
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function requestUserDelAuth(usernameToAuthorize, buttonId)
{
    $("#" + buttonId).attr('disabled', 'disabled');
    var id = sessionStorage["id_examen"];
    $.ajax({
        url: "WebService.asmx/requestUserRemoval",
        data: "{ 'id': '" + id + "', 'username': '" + usernameToAuthorize + "'}",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
            requestUsers(id, 0);
            requestUsers(id, 1);
        },
        error: function (result) {
            $("#" + buttonId).removeAttr("disabled");
            alert(result.status + ' ' + result.statusText);
        }
    });
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