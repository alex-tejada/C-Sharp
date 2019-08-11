
var questionsDataToCheck = []
var questionsData = [];
var JSONobjectGlobal = null;
var clockInterval = null;
var stopInterval = false;

$(document).ready(function ()
{
    var localUser = sessionStorage["usuario"];
    var examID = sessionStorage["id_examen"];
    requestAuthorization(localUser, examID);
});
function timer()
{
    var minutesLeft = 60;
    var seconds = 60;
    if (sessionStorage["minutes"] != null & sessionStorage["seconds"] != null)
    {
        minutesLeft = parseInt(sessionStorage["minutes"]);
        seconds = parseInt(sessionStorage["seconds"]);
    }
    setInterval(function ()
    {
        if (!(stopInterval))
        {
            seconds -= 1;
            if (seconds < 0) { minutesLeft -= 1; seconds = 60; }
            $("#timer").html("<p>" + minutesLeft + ":" + seconds + "</p>");
            setTimeLeft(minutesLeft, seconds);
            if (minutesLeft <= 0 & seconds <= 0)
            {
                stopInterval = true;
                timeOver();
            }
        }
    },
    1000);
}
function getTimeLeft()
{
    var localUser = sessionStorage["usuario"];
    var examID = sessionStorage["id_examen"];
    $.ajax({
        url: "WebService.asmx/getTimeleft",
        data: "{ 'id': '"+examID+"', 'username': '"+localUser+"'}",
        type: "post",
        contentType: "application/json",
        async: false,
        success: function (response)
        {
            if (response.d == "2")
            {
                sessionStorage["minutes"] = 60;
                sessionStorage["seconds"] = 60;
            }
            else
            {
                JSONobject = JSON.parse(response.d);
                sessionStorage["minutes"] = JSONobject.minutes;
                sessionStorage["seconds"] = JSONobject.seconds;
            }
            timer();
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function setTimeLeft(minutes,seconds)
{
    var localUser = sessionStorage["usuario"];
    var examID = sessionStorage["id_examen"];
    sessionStorage["minutes"] = minutes;
    sessionStorage["seconds"] = seconds;

    $.ajax({
        url: "WebService.asmx/setTimeleft",
        data: "{ 'id': '"+examID+"', 'username': '"+localUser+"', 'minutes': '"+minutes+"', 'seconds': '"+seconds+"'}",
        type: "post",
        contentType: "application/json",
        async: true,
        success: function (response)
        {
            
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function requestAuthorization(localUser, examID)
{
    $.ajax({
        url: "WebService.asmx/requestExamAuthorization",
        data: "{'id': '" + examID + "', 'username': '" + localUser + "'}",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response)
        {
            if (response.d == "1")
            {
                getTimeLeft();
                getExamData(examID);
                //requestAuthorizationRemoval(localUser, examID);
            }
            else
            {
                $('#modalAccessDenied').modal();
                setTimeout(function ()
                {
                    window.location.replace("AllowedExams.aspx");
                },
                4000);
            }
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function requestAuthorizationRemoval(localUser, examID)
{
    $.ajax({
        url: "WebService.asmx/requestExamAuthorizationRemoval",
        data: "{ 'id': '" + examID + "', 'username': '" + localUser + "' }",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
           
        },
        error: function (result) {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function getExamData(examID)
{
    var username = sessionStorage["usuarioProfesor"];
    $.ajax({
        url: "WebService.asmx/getExamData",
        data: "{ 'id': '" + examID + "', 'username': '" + username + "' }",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response)
        {
            appendExamDataToCheck(response.d);
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function appendExamDataToCheck(JSONstring)
{
    var JSONobject = JSON.parse(JSONstring);
    JSONobjectGlobal = JSONobject;
    var JSONarray = JSON.parse(JSONobject.JSONstring);
    questionsData = JSONarray;
    $("#examTittle").append("<h3>" + JSONobject.tittle+"</h3>");
    for (var i = 0; i < JSONarray.length; i++)
    {
        var questionCount = JSONarray[i].id;
        var questionData = appendNewQuestionText(questionCount, JSONarray[i].question, i + 1, JSONarray[i].image);
        $("#questions").append(questionData[0]);
        questionsDataToCheck.push(
            { 'questionID': questionData[2], 'multipleID': [], 'truefalseID': [] }
        );
        var flag = true;
        for (var j = 0; j < JSONarray[i].multiple.length; j++)
        {
            var radioID = appendRadioInputMultiple(questionData[1], JSONarray[i].multiple[j], j,flag);
            questionsDataToCheck[i].multipleID.push(radioID);
            flag = false;
        }
        if (JSONarray[i].truefalse.length > 0)
        {
            var truefalse = JSONarray[i].truefalse[0]; 
            var radioIDs = appendRadioInputTrueFalse(questionData[1],truefalse);
            questionsDataToCheck[i].truefalseID.push(radioIDs);
        }
    }
    $("#buttonOpenFinish").css("visibility", "visible");
}
function appendNewQuestionText(questionCount,text,number,image)
{
    var questionImage = "";
    if (image != "")
    {
        questionImage = "<br><img class='img-check' src='Exams/Images/" + image +"' title='Question Image' alt='Question Image' /><br>";
    }
    var questionDiv = "<div id='" + questionCount + "' class='form-group question'> <label for='question" + questionCount + "' id='questionText" + questionCount + "' value='" + text + "' class='question-text'>" + number + ". " + text + " </label><br>" + questionImage+"<br><br><div id='answers" + questionCount + "'></div></div><br><br><br><br><hr>";
    var questionNumID = String(questionCount);
    var questionID = "questionText" + String(questionCount);
    var questionData = [];
    questionData.push(questionDiv);
    questionData.push(questionNumID);
    questionData.push(questionID);
    return questionData;
    /*
      [0] question  
      [1] div ID
      [2] question ID
    */
}
function appendRadioInputMultiple(questionDivID, answerText, radioDivID, flag)
{
    var checkedProperty = "";
    var checkedState = "0";
    if (flag) { checkedProperty = "checked"; checkedState = "1"; }
    var radio = "<div class='form-check form-check-inline'> <input class='form-check-input' type='radio' " + checkedProperty + " onchange='setSelectedOptionMultiple(this.id);' selectedone='" + checkedState+"' name='answerName" + String(questionDivID) +"' id='answer" + String(questionDivID) + String(radioDivID) + "' value='" + answerText + "'> <label class='form-check-label' for='answerName" + String(questionDivID) + String(radioDivID) + "'> " + answerText + " </label></div>";
    $("#" + String(questionDivID)).append(radio);
    var radioID = "answer" + String(questionDivID) + String(radioDivID);
    return radioID;
}
function appendRadioInputTrueFalse(questionDivID, truefalse)
{
    var radioIDs = [];
    var radioTrue = "<div class='form-check form-check-inline'><input class='form-check-input' type='radio' onchange='setSelectedOptionRadio(this.id,\"answer" + String(questionDivID) + "1\");' checked selectedone='1' name='answerName" + String(questionDivID) + "' id='answer" + String(questionDivID) + "0' value='" + truefalse[0] + "'> <label class='form-check-label' for='answerName" + String(questionDivID) + "0'> " + truefalse[0] +"</label></div>";
    var radioFalse = "<div class='form-check form-check-inline'><input class='form-check-input' type='radio' onchange='setSelectedOptionRadio(this.id,\"answer" + String(questionDivID) + "0\");' selectedone='0' name='answerName" + String(questionDivID) + "' id='answer" + String(questionDivID) + "1' value='" + truefalse[1] + "'> <label class='form-check-label' for='answerName" + String(questionDivID) + "1'> " + truefalse[1] +" </label></div>";
    var radioFulliled =""+radioTrue + radioFalse;
    $("#" + String(questionDivID)).append(radioFulliled);
    radioIDs.push("answer" + String(questionDivID) + "0");
    radioIDs.push("answer" + String(questionDivID) + "1");
    return radioIDs;
}
function setSelectedOptionMultiple(id)
{
    var state = $("#" + id).attr("selectedone");
    if (String(state) == "0")
    {
        $("#" + id).attr("selectedone", "1");
        for (var i = 0; i < questionsDataToCheck.length; i++)
        {
            var index = questionsDataToCheck[i].multipleID.indexOf(id);
            if (index >= 0)
            {
                for (var j = 0; j < questionsDataToCheck[i].multipleID.length; j++)
                {
                    var brotherID = questionsDataToCheck[i].multipleID[j];
                    if (brotherID != id)
                    {
                        $("#" + brotherID).attr("selectedone", "0");
                    }
                }
                break;
            }
        }
    }
}
function setSelectedOptionRadio(id, brotherID)
{
    var state = $("#" + id).attr("selectedone");
    if (String(state) == "0")
    {
        $("#" + id).attr("selectedone", "1");
        $("#" + brotherID).attr("selectedone", "0");
    }
    else if (String(state) == "1")
    {
        $("#" + id).attr("selectedone", "0");
        $("#" + brotherID).attr("selectedone", "1");
    }
}
function timeOver()
{
    prepareDataToSend();
}
function prepareDataToSend()
{
    stopInterval = true;
    var dataChecked = checkResults();
    var Results = new Object();
    Results.username = sessionStorage["usuario"];
    Results.examTittle = JSONobjectGlobal.tittle;
    Results.path = JSONobjectGlobal.path;
    Results.id = JSONobjectGlobal.id;
    Results.totalQuestions = dataChecked[0];
    Results.correctAnswers = dataChecked[1];
    Results.score = dataChecked[2];
    sendCheckData(Results, dataChecked[2]);
}
function openModal()
{
    $("#modalFinishExam").modal();
}
function checkResults()
{
    var totalQuestions = questionsData.length;
    var correctAnswers = 0;
    for (var i = 0; i < questionsData.length; i++)
    {
        var question = $("#" + questionsDataToCheck[i].questionID).attr("value");
        if (questionsData[i].question == question)
        {
            for (var j = 0; j < questionsData[i].multiple.length; j++)
            {
                var answer = $("#" + questionsDataToCheck[i].multipleID[j]).val();
                var selected = $("#" + questionsDataToCheck[i].multipleID[j]).attr("selectedOne");
                var index = questionsData[i].multipleCorrectAnswers.indexOf(answer);
                if (index != -1 && selected==1)
                {
                    correctAnswers += 1;
                }
            }
            for (var j = 0; j < questionsDataToCheck[i].truefalseID.length; j++)
            {
                var answers = questionsDataToCheck[i].truefalseID[j];
                var id = answers[0];
                var answer = $("#" + id).val();
                var selected = $("#" + id).attr("selectedOne");
                var index = questionsData[i].truefalseCorrectAnswers.indexOf(answer);
                if (index != -1 && selected == 1)
                {
                    correctAnswers += 1;
                }
                id = answers[1];
                answer = $("#" + id).val();
                selected = $("#" + id).attr("selectedOne");
                index = questionsData[i].truefalseCorrectAnswers.indexOf(answer);
                if (index != -1 && selected == 1) {
                    correctAnswers += 1;
                }
            }
        }
    }
    var score = (correctAnswers / totalQuestions) * 10;
    var dataChecked = [];
    dataChecked.push(String(totalQuestions));
    dataChecked.push(String(correctAnswers));
    dataChecked.push(String(score));
    return dataChecked;
}
function sendCheckData(JSONobject,score)
{
    $("#buttonFinish").attr('disabled', 'disabled');
    $("#buttonOpenFinish").attr('disabled', 'disabled');
    $("#loadingDiv").css("visibility", "visible");

    var JSONstring = JSON.stringify(JSONobject);
    $.ajax({
        url: "WebService.asmx/setExamScore",
        data: "{ 'JSONstring': '" + JSONstring + "'}",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
            if (response.d == "1")
            {
               $("#score").html("Final score: "+score);
               $("#buttonFinish").css("visibility", "hidden");
               $("#buttonOpenFinish").attr("visibility", "hidden");
               $("#loadingDiv").css("visibility", "hidden");
               $("#modalFinishExam").modal('hide');
               $("#modalFinalScore").modal();
               setTimeout(function ()
               {
                 window.location.replace("AllowedExams.aspx");
               },
               4000);
            }
        },
        error: function (result)
        {
            $("#buttonFinish").attr('disabled', 'disabled');
            $("#loadingDiv").css("visibility", "hidden");
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function returnMenu() {
    window.location.replace("menuCeap.aspx");
}
function returnToAllowed()
{
    window.location.replace("AllowedExams.aspx");
}