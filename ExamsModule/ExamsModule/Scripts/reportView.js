
$(document).ready(function ()
{
    requestInstructorUsernames();
    requestInstructorExams();
    requestReportForInstr(0,0,'');//Option, IdExam, Username
});
function applyFilter()
{
    $("#loadingDiv").css("visibility", "visible");
    var option = 0;
    var username = $("#usernameSelect").val();
    var examId = $("#examSelect").val();
    if (examId != 0) { option = 1; }
    requestReportForInstr(option, examId, username);
}
function requestReportForInstr(option, idExamOption, usernameOption)
{
    var username = sessionStorage["usuario"];
    $.ajax({
        url: "WebService.asmx/requestReportInstructor",
        data: "{ 'username': '" + username + "', 'option': '" + option + "', 'idExamOption': '" + idExamOption + "', 'usernameOption':'" + usernameOption + "'}",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response)
        {
            $("#noResults").css("visibility", "hidden");
            if (response.d == "2")
            {
                $("#loadingDiv").css("visibility", "hidden");
                $("#noResults").css("visibility", "visible");
            }
            else
            {
                $("#loadingDiv").css("visibility", "hidden");
                setDataAlignment(response.d);
            }
        },
        error: function (result)
        {
            $("#loadingDiv").css("visibility", "hidden");
            $("#noResults").css("visibility", "hidden");
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function setDataAlignment(JSONstring)
{
    var userList = [];
    var rowList = [];
    var columnIds = [];
    var columnPair = [];
    var JSONarray = JSON.parse(JSONstring);
    for (var i = 0; i < JSONarray.length; i++)
    {
        var username = JSONarray[i].username;
        var index = userList.indexOf(username);
        var columnIndex = columnIds.indexOf(JSONarray[i].id_exam);
        if (!(columnIndex > -1))
        {
            columnIds.push(JSONarray[i].id_exam);
            columnPair.push({ 'id_exam': JSONarray[i].id_exam, 'title': JSONarray[i].title });
        }
        if (index > -1)
        {
               var tempArray = rowList[index];
               var foundResult = false;
               for (var k = 0; k < tempArray.grades.length; k++)
               {
                    if (tempArray.grades[k].id_exam == JSONarray[i].id_exam)
                    {
                        tempArray.grades[k].grade = JSONarray[i].grade;
                        foundResult = true;
                        break;
                    }
               }
               if (!foundResult)
               {
                  tempArray.grades.push({ "grade": JSONarray[i].grade, "id_exam": JSONarray[i].id_exam, "title": JSONarray[i].title });
               }
            rowList[index] = tempArray;
        }
        else
        {
            userList.push(username);
            rowList.push({ 'username': username, 'grades': [{ "grade": JSONarray[i].grade, "id_exam": JSONarray[i].id_exam, "title": JSONarray[i].title }] });
        }
    }
    userList = null;
    columnIds = null;
    buildTable(rowList, columnPair);
}
function buildTable(rowList, columnPair)
{
    var table = document.createElement("table");
    table.classList.add('table');
    table.setAttribute('id','grades');
    table.classList.add('table-sm');
    table.classList.add('table-hover');
    var tHead = table.createTHead();
    var row = tHead.insertRow(0);
    var th = row.insertCell(0);
    th.innerHTML = "Username";
    th.setAttribute('scope', 'col');
    th.setAttribute('columnnumber', 0);
    th.setAttribute('scope', 'col');
    var columnIds = [];
    var yAxisAverage = [];
    for (var i = 0; i < columnPair.length; i++)
    {
        th = null;
        columnIds.push({ 'columnNumber': i + 1, 'id': columnPair[i].id_exam });
        th = row.insertCell(i + 1);
        th.setAttribute('columnnumber', i + 1)
        th.setAttribute('scope', 'col');
        th.setAttribute('id', String(columnPair[i].id_exam));
        th.innerHTML = "<div style='max-width:100px' class='set-overflow-x' >" + String(columnPair[i].title) + "</div>";
        lastCol = i + 1;
        yAxisAverage.push({ 'id': columnPair[i].id_exam, 'count':0, 'total':0});
    }
    var cellsCount = row.cells.length;
    th = row.insertCell(cellsCount);
    th.innerHTML = "Average";
    th.setAttribute('scope', 'col');
    th.setAttribute('columnnumber', cellsCount);
    columnPair = null;
    row = null;
    yAxisAverage.push({ 'id': -1, 'count': 0, 'total': 0 });

    var tBody = table.createTBody();
    for (var i = 0; i < rowList.length; i++)
    {
        var rowsCount = table.rows.length - 1;
        row = tBody.insertRow(rowsCount);
        var cellsCount = row.cells.length;
        var td = row.insertCell(cellsCount);
        td.innerHTML = String(rowList[i].username);
        td.setAttribute('columnnumber', i)
        var grades = rowList[i].grades;
        var xAxisData = [];
        for (var k = 0; k < columnIds.length; k++)
        {
            td = null;
            cellsCount = row.cells.length;
            td = row.insertCell(cellsCount);
            td.setAttribute('columnnumber', i + 1);
            td.innerHTML = "<div class='text-grey'>NA</div>";
            for (var j = 0; j < grades.length; j++)
            {
                if (yAxisAverage[k].id == grades[j].id_exam)
                {
                    yAxisAverage[k].total += parseInt(grades[j].grade);
                    yAxisAverage[k].count += 1;
                }
                if (columnIds[k].id == grades[j].id_exam)
                {
                    var div = "<div class='text-green'>";
                    if (parseInt(grades[j].grade) < 8)
                    {
                        div = "<div class='text-red'>";
                    }
                    td.innerHTML = div + grades[j].grade + "</div>";
                    xAxisData.push(grades[j].grade);
                    break;
                }
            }
        }
        td = null;
        cellsCount = row.cells.length;
        td = row.insertCell(cellsCount);
        td.setAttribute('columnnumber', cellsCount);
        var xAverage = 0;
        for (var k = 0; k < xAxisData.length; k++)
        {
            xAverage += parseInt(xAxisData[k]);
        }
        td.innerHTML = "<div class='text-blue' > " + Math.round(xAverage / xAxisData.length) + " </div>";
        yAxisAverage[yAxisAverage.length - 1].count += 1;
        yAxisAverage[yAxisAverage.length - 1].total += Math.round(xAverage / xAxisData.length);
    }

    td = null;
    rowsCount = table.rows.length - 1;
    row = tBody.insertRow(rowsCount);
    cellsCount = row.cells.length;
    td = row.insertCell(cellsCount);
    td.innerHTML = "General Average";
    td.setAttribute('columnnumber', cellsCount);

    for (var k = 0; k < yAxisAverage.length; k++)
    {
        cellsCount = row.cells.length;
        td = row.insertCell(cellsCount);
        if (yAxisAverage[k].total == 0)
        {
            td.innerHTML = "<div class='text-grey'> NA </div>";
        }
        else
        {
            td.innerHTML = "<div class='text-blue'> " + Math.round(yAxisAverage[k].total / yAxisAverage[k].count) + " </div>";
        }
        td.setAttribute('columnnumber', cellsCount);
    }

    var div = document.getElementById('tableSection');
    div.innerHTML = '';
    div.appendChild(table);
    $("#exportButton").css("display", "inline-block");
}
function requestInstructorUsernames()
{
    var username = sessionStorage["usuario"];
    $.ajax({
        url: "WebService.asmx/requestUsernames",
        data: "{ 'username': '" + username + "'}",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response)
        {
            if (response.d == "2") {

            }
            else
            {
                fillUsernames(response.d);
            }
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function fillUsernames(JSONstring)
{
    var JSONarray = JSON.parse(JSONstring);
    var dropdown = $("#usernameSelect");
    for (var i = 0; i < JSONarray.length; i++)
    {
        dropdown.append($("<option />").val(JSONarray[i].username).text(JSONarray[i].username));
    }
}
function requestInstructorExams()
{
    var username = sessionStorage["usuario"];
    $.ajax({
        url: "WebService.asmx/requestExams",
        data: "{ 'username': '" + username + "' }",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response) {
            
            if (response.d == "2") {

            }
            else {
                fillExams(response.d);
            }
        },
        error: function (result) {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function fillExams(JSONstring)
{
    
    var JSONarray = JSON.parse(JSONstring);
    var dropdown = $("#examSelect");
    for (var i = 0; i < JSONarray.length; i++) {
        dropdown.append($("<option />").val(JSONarray[i].id_examen).text(JSONarray[i].titulo));
    }
}
function returnMenu()
{
    window.location.replace("menuCeap.aspx");
}
function createWorkbook()
{
    var table = document.getElementById("grades");
    var rowCount = table.rows.length;
    if (rowCount>0)
    {
        var table = document.getElementById('grades');
        var wb = XLSX.utils.table_to_book(table, { sheet: "Grades" });
        var dataArray = XLSX.write(wb, { bookType: 'xlsx', type: 'binary' });
        saveAs(new Blob([s2ab(dataArray)], { type: "application/octet-stream" }), 'report.xlsx');
    }
}
function s2ab(s)
{
    var buf = new ArrayBuffer(s.length);
    var view = new Uint8Array(buf);
    for (var i = 0; i < s.length; i++) view[i] = s.charCodeAt(i) & 0xFF;
    return buf;
}