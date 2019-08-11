
$(document).ready(function ()
{
    var examID = sessionStorage["id_examen"];
    var username = sessionStorage["usuario"];
    getExamData(examID,username);
});
function getExamData(examID, username)
{
    $.ajax({
        url: "WebService.asmx/getExamData",
        data: "{ 'id': '"+examID+"', 'username': '"+username+"' }",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
            if (response.d == "2")
            {

            }
            else
            {
                appendExamData(response.d);
            }
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function checkValidationEdit()
{
    verifyAllFields();
    if (validTittle && validQuestion && validAnswer)
    {
        $("#loadingDiv").css("visibility", "visible");
        $("#buttonSaveChanges").attr('disabled', 'disabled');
        retriveallInformation(1);
    }
}
function appendExamData(JSONstring)
{
    var JSONobject = JSON.parse(JSONstring);
    var JSONarray = JSON.parse(JSONobject.JSONstring);
    $("#examTittle").val(JSONobject.tittle);
    $("#languageSelect").val(JSONobject.language);
    $("#areaSelect").val(JSONobject.area);
    validateTittleText('examTittle');
    for (var i = 0; i < JSONarray.length; i++)
    {
        var preguntasCount = JSONarray[i].id;
        var radioValue = "ciertofalso";
        if (JSONarray[i].multiple.length > 0)
        {
            radioValue = "multiple";
        }
        var selectedOptions = getSelectedQuestionOptions(radioValue, preguntasCount)
        var newDiv = getNewDivElement(preguntasCount, selectedOptions);
        $("#preguntas").append(newDiv);
        var preguntaID = getQuestionID(preguntasCount);

        preguntasDirectory.push(
            { 'preguntaID': preguntaID, 'multipleID': [], 'ciertofalsoID': [] }
        );
        $("#" + String(preguntasDirectory[i].preguntaID)).find("input[type=text][name=preguntaTexto]").val(JSONarray[i].question);
        validateQuestionText("preguntaTexto" + preguntasCount);
        if (selectedOptions[2] == 1)
        {
            for (var i = 0; i < preguntasDirectory.length; i++)
            {
                if (preguntasDirectory[i].preguntaID == preguntaID)
                {
                    preguntasDirectory[i].ciertofalsoID.push("respuesta" + String(preguntasCount) + "CF");
                    break;
                }
            }
            var truefalseAnswer = "0";
            var brotherNum = 1;
            if (JSONarray[i].truefalseCorrectAnswers[0] == "falso")
            {
                truefalseAnswer = "1";
                brotherNum = 0;
            }
            var elementID = "radioTF" + String(preguntasCount) + truefalseAnswer;
            if (truefalseAnswer == "0")
            {
                $("#" + elementID).prop('checked', true);
                $("#" + "radioTF" + String(preguntasCount) + String(brotherNum)).prop('checked', false);
            }
            else
            {
                $("#" + elementID).prop('checked', false);
                $("#" + "radioTF" + String(preguntasCount) + String(brotherNum)).prop('checked', true);
            }
            addAnswerAttrTrueFalse(elementID, preguntasCount, brotherNum);
        }
        for (var j = 0; j < JSONarray[i].multiple.length; j++)
        {
            appendMultiple(preguntasCount);
            var respuestaID = "answerInput" + String(preguntasCount) + String(j);
            $("#" + respuestaID).val(JSONarray[i].multiple[j]);

            for (var k = 0; k < JSONarray[i].multipleCorrectAnswers.length; k++)
            {
                if (JSONarray[i].multiple[j] == JSONarray[i].multipleCorrectAnswers[k])
                {
                    $("#" + respuestaID).attr("correct", "1");
                    $("#" + "checkbox" + String(preguntasCount) + String(j)).prop('checked', true);
                }
            }
            validateAnswerText(respuestaID);
        }
        if (JSONarray[i].image != "")
        {
            appendImage(preguntasCount, "Exams/Images/"+JSONarray[i].image, JSONarray[i].image);
        }
    }
}
function appendImage(preguntasCount, path, name)
{
    $("#preview" + String(preguntasCount)).attr("src", path);
    for (var i = 0; i < preguntasDirectory.length; i++)
    {
        if (preguntasDirectory[i].preguntaID.includes(String(preguntasCount)))
        {
            preguntasDirectory[i].image = 1;
        }
    }
    ImageData.push({ "id": preguntasCount, "image": name });
    $("#previewDiv" + String(preguntasCount)).css("visibility", "visible");
}
