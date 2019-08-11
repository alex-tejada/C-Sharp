
$(document).ready(function ()
{
    var username = sessionStorage["usuario"];
    var examID = sessionStorage["id_examen"];
    getExamData(username, examID);
});
function getExamData(username,examID)
{
    $.ajax({
        url: "WebService.asmx/getExamData",
        data: "{ 'id': '"+examID+"', 'username': '"+username+"' }",
        contentType: "application/json",
        type: "post",
        async: false,
        success: function (response)
        {
            appendExamDataToCheck(response.d);
        },
        error: function (result) {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function appendExamDataToCheck(JSONstring)
{
    var JSONobject = JSON.parse(JSONstring);
    var JSONarray = JSON.parse(JSONobject.JSONstring);
    questionsData = JSONarray;
    $("#examTittle").append("<h3>" + JSONobject.tittle + "</h3>");
    for (var i = 0; i < JSONarray.length; i++) {
        var questionCount = JSONarray[i].id;
        var questionData = appendNewQuestionText(questionCount, JSONarray[i].question, i + 1, JSONarray[i].image);
        $("#questions").append(questionData[0]);
        var flag = true;
        for (var j = 0; j < JSONarray[i].multiple.length; j++)
        {
            var radioID = appendRadioInputMultiple(questionData[1], JSONarray[i].multiple[j], j, flag);
            flag = false;
        }
        if (JSONarray[i].truefalse.length > 0)
        {
            var radioIDs = appendRadioInputTrueFalse(questionData[1], JSONarray[i].truefalse[0]);
        }
    }
}
function appendNewQuestionText(questionCount, text, number, image)
{
    var questionImage = "";
    if (image != "") {
        questionImage = "<br><img class='img-check' src='Exams/Images/" + image + "' title='Question Image' alt='Question Image' /><br>";
    }
    var questionDiv = "<div id='" + questionCount + "' class='form-group question'> <label for='question" + questionCount + "' id='questionText" + questionCount + "' value='" + text + "' class='question-text'>" + number + ". " + text + " </label>" + questionImage + "<br><br><div id='answers" + questionCount + "'></div></div><br><br><hr>";
    var questionNumID = String(questionCount);
    var questionID = "questionText" + String(questionCount);
    var questionData = [];
    questionData.push(questionDiv);
    questionData.push(questionNumID);
    questionData.push(questionID);
    return questionData;
}
function appendRadioInputMultiple(questionDivID, answerText, radioDivID, flag)
{
    var checkedProperty = "";
    if (flag) { checkedProperty = "checked"; }
    var radio = "<div class='form-check form-check-inline'> <input class='form-check-input' type='radio' " + checkedProperty + " name='answerName" + String(questionDivID) + "' id='answer" + String(questionDivID) + String(radioDivID) + "' value='" + answerText + "'> <label class='form-check-label' for='answerName" + String(questionDivID) + String(radioDivID) + "'> " + answerText + " </label></div>";
    $("#" + String(questionDivID)).append(radio);
    var radioID = "answer" + String(questionDivID) + String(radioDivID);
    return radioID;
}
function appendRadioInputTrueFalse(questionDivID, truefalse)
{
    var radioIDs = [];
    var radioTrue = "<div class='form-check form-check-inline'><input class='form-check-input' type='radio'  checked selectedone='1' name='answerName" + String(questionDivID) + "' id='answer" + String(questionDivID) + "0' value='cierto'> <label class='form-check-label' for='answerName" + String(questionDivID) + "0'> " + truefalse[0]+" </label></div>";
    var radioFalse = "<div class='form-check form-check-inline'><input class='form-check-input' type='radio' selectedone='0' name='answerName" + String(questionDivID) + "' id='answer" + String(questionDivID) + "1' value='falso'> <label class='form-check-label' for='answerName" + String(questionDivID) + "1'> " + truefalse[1] +"  </label></div>";
    var radioFulliled = "" + radioTrue + radioFalse;
    $("#" + String(questionDivID)).append(radioFulliled);
    radioIDs.push("answer" + String(questionDivID) + "0");
    radioIDs.push("answer" + String(questionDivID) + "1");
    return radioIDs;
}
