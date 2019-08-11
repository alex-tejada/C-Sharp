
var preguntasDirectory = [];
var ImageData = [];
var validQuestion = false;
var validAnswer = false;
var validTittle = false;
var multipleCount = 0;
var truefalseCount = 0;

$(document).ready(function ()
{
    $("#nuevaPregunta").click(function ()
    {
        var radioValue = $("input[name='tipoRespuesta']:checked").val();
        setNewQuestion(radioValue);
    });
    $("#modalLanguage").modal();
});
function setNewQuestion(radioValue)
{
    var preguntasCount = 0;
    preguntasCount = verifyNewQuestion();
    if (preguntasCount >= 0)
    {
        var selectedOptions = getSelectedQuestionOptions(radioValue, preguntasCount)
        var newDiv = getNewDivElement(preguntasCount, selectedOptions);
        $("#preguntas").append(newDiv);
        var preguntaID = getQuestionID(preguntasCount);
        preguntasDirectory.push(
            { 'preguntaID': preguntaID, 'multipleID': [], 'ciertofalsoID': [], 'image': 0 }
        );
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
        }
    }
}
function getSelectedQuestionOptions(radioOption, preguntasCount)
{
    if (radioOption == "multiple")
    {
        multipleCount += 1;
        var imagePreview = "<div id='previewDiv" + preguntasCount + "' style='visibility:hidden;width:40px;height:40px;display:inline-block;position:relative;'><img style='width:40px;height:40px;' id='preview" + preguntasCount + "' name='preview' width='40px' height='40px' src=''/><img id='previewDel" + preguntasCount + "' style='width:25px;height:25px;float:right;cursor:pointer;position:absolute;bottom:1px;' title='Remove' src='Resources/deleteImg.png' onclick='deletePreview(" + preguntasCount + ")' /></div>";
        var addedHTML = "<button  id='nuevaRespuestaMult" + preguntasCount + "' onclick='appendMultiple(" + preguntasCount + ")' class='btn-primary'><img src='Resources/append.png' alt='Append' / > </button >";
        var buttonInsertImage = "<button id='trigger" + preguntasCount + "' onclick='triggerInputFile(" + preguntasCount + ")' class='btn-success'><img src='Resources/imagesel.png' title='' alt='' / ></button ><input id='file-input" + preguntasCount + "' accept='image/*' type='file' onchange='fileFilter(this.id," + preguntasCount + ")' style='display: none;' /> "+imagePreview;
        var buttondeleteQuestion = "<button onclick='deleteQuestion(" + preguntasCount + ",0)' class='btn-danger'><img src='Resources/delete.png' title='Delete' alt='Delete' / ></button > " + addedHTML +" "+ buttonInsertImage ;
        multipleStock = 1;
        var ciertofalso = 0;
        var selectedOptions = [];
        selectedOptions.push(addedHTML);
        selectedOptions.push(buttondeleteQuestion);
        selectedOptions.push(ciertofalso);
        selectedOptions.push(buttonInsertImage);
        return selectedOptions;
    }
    else
    {
        var language = $("#languageSelect").val();
        truefalseCount += 1;
        var imagePreview = "<div id='previewDiv" + preguntasCount + "' style='visibility:hidden;width:40px;height:40px;display:inline-block;position:relative;'><img style='width:40px;height:40px;' id='preview" + preguntasCount + "' name='preview' width='40px' height='40px' src=''/><img id='previewDel" + preguntasCount + "' style='width:25px;height:25px;float:right;cursor:pointer;position:absolute;bottom:1px;' title='Remove' src='Resources/deleteImg.png' onclick='deletePreview(" + preguntasCount + ")' /></div>";
        var buttonInsertImage = "<button id='trigger" + preguntasCount + "' onclick='triggerInputFile(" + preguntasCount + ")' class='btn-success'><img src='Resources/imagesel.png' title='' alt='' / ></button ><input id='file-input" + preguntasCount + "' accept='image/*' type='file' onchange='fileFilter(this.id," + preguntasCount + ")' style='display: none;' /> ";
        var addedHTML = appendTrueFalse(preguntasCount,language);
        var buttondeleteQuestion = "<button onclick='deleteQuestion(" + preguntasCount + ",1)' class='btn-danger'><img src='Resources/delete.png' title='Delete' alt='Delete' / ></button> " + buttonInsertImage + " " + imagePreview + "<br><br>"+addedHTML;
        var ciertofalso = 1;
        var selectedOptions = [];
        selectedOptions.push(addedHTML);
        selectedOptions.push(buttondeleteQuestion);
        selectedOptions.push(ciertofalso);
        selectedOptions.push(buttonInsertImage);
        return selectedOptions;
    }
}
function getNewDivElement(preguntasCount,selectedOptions)
{
    var htmlAppend = selectedOptions[1];
    var newDiv = "<div id='pregunta" + preguntasCount + "' class='form-group col-lg-11 col-md-10 col-sm-10 col-xs-10'> <br> <input type='text' class='form-control' name='preguntaTexto' required onchange='validateQuestionText(this.id)'  id='preguntaTexto" + preguntasCount + "' placeholder='Question'/> <br>" + htmlAppend + " <br><div id='nuevaRespuesta" + preguntasCount + "'><br></div><br><hr></div> ";
    return newDiv;
}
function deletePreview(preguntasCount)
{
    var fileInput = document.getElementById("file-input"+preguntasCount);
    replaceElement(fileInput);
    $("#preview" + String(preguntasCount)).src = '';
    $("#previewDiv" + String(preguntasCount)).css("visibility", "hidden");
    for (var i = 0; i < preguntasDirectory.length; i++)
    {
        if (preguntasDirectory[i].preguntaID.includes(String(preguntasCount)))
        {
            preguntasDirectory[i].image = 0;
            break;
        }
    }
    if (ImageData.length > 0)
    {
        for (var i = 0; i < ImageData.length; i++)
        {
            if (preguntasCount == ImageData[i].id)
            {
                ImageData[i].id = -1;
                break;
            }
        }
    }
}
function triggerInputFile(preguntasCount)
{
    $('#file-input' + String(preguntasCount)).trigger('click');
}
function fileFilter(id, preguntasCount)
{
    var filter = true;
    var fileInput = document.getElementById(id);
    var count = fileInput.files.length;
    var size = Math.ceil((fileInput.files[0].size / 1024));
    if (count > 1)
    {
        //More than 1
        filter = false;
    }
    if (size>(1024*2))
    {
        //Too big
        filter = false;
    }
    if (!$('#' + String(id)).hasExtension(['.jpg', '.png', '.gif']))
    {
        //Invalid file
        filter = false;
    }
    if (filter)
    {
        
        for (var i = 0; i < preguntasDirectory.length; i++)
        {
            if (preguntasDirectory[i].preguntaID.includes(String(preguntasCount)))
            {
                preguntasDirectory[i].image = 1;
                break;
            }
        }
        var fileReader = new FileReader();
        fileReader.onload = function ()
        {
            $("#previewDiv" + String(preguntasCount)).css("visibility", "visible");
            document.getElementById("preview" + String(preguntasCount)).src = fileReader.result;
        }
        fileReader.readAsDataURL(fileInput.files[0]);
    }
    else
    {
        replaceElement(fileInput);
        //Detach File
        $('#modalErrorImage').modal();
        for (var i = 0; i < preguntasDirectory.length; i++)
        {
            if (preguntasDirectory[i].preguntaID.includes(String(preguntasCount)))
            {
                preguntasDirectory[i].image = 0;
                break;
            }
        }
        $("#previewDiv" + String(preguntasCount)).css("visibility", "hidden");
    }
}
function replaceElement(element)
{
    var newElement = document.createElement('input');
    for (i = 0; i < element.attributes.length; i++)
    {
        if (element.attributes[i].name != "value" && element.attributes[i].name != "src")
        {
            newElement.setAttribute(element.attributes[i].name, element.attributes[i].value); 
        }
    }
    element.parentNode.replaceChild(newElement, element);
}
$.fn.hasExtension = function (exts)
{
    return (new RegExp('(' + exts.join('|').replace(/\./g, '\\.') + ')$')).test($(this).val());
}
function getExtension(filename)
{
    return filename.split('.').pop();
}
function getQuestionID(preguntasCount)
{
    return 'pregunta' + String(preguntasCount);
}
function verifyNewQuestion()
{
    var limit = 15;
    var count = 0;
    var temporalArray = [];
    var preguntaID = 'pregunta' + String(count);
    if (preguntasDirectory.length < limit)
    {
        for (var i = 0; i < preguntasDirectory.length; i++)
        {
            temporalArray.push(preguntasDirectory[i].preguntaID);
        }
        for (var i = 0; i < temporalArray.length; i++)
        {
            var index = temporalArray.indexOf(preguntaID);
            if (index < 0)
            {

                break;
            }
            count++;
            preguntaID = 'pregunta' + String(count);
        }
        return count;
     }
    return -1;
}
function appendMultiple(preguntaNum)
{
    var count = 0
    var limit = 5;
    var respuestaID = String(preguntaNum) + String(count);
    if (preguntasDirectory[preguntaNum].multipleID.length < limit)
    {
        for (var i = 0; i < preguntasDirectory[preguntaNum].multipleID.length; i++)
        {
            var index = preguntasDirectory[preguntaNum].multipleID.indexOf(respuestaID);
            if (index<0)
            {
                break;
            }
            count++;
            respuestaID = String(preguntaNum) + String(count);
        }
        respuestaID = String(preguntaNum) + count;
        preguntasDirectory[preguntaNum].multipleID.push(respuestaID);
        $("#nuevaRespuesta" + preguntaNum).append("<div id='respuesta" + respuestaID + "' class='answer-spot'> <input type='text' onchange='validateAnswerText(this.id)' correct='0' id='answerInput" + respuestaID +"' class='form-control' required placeholder='Answer' name='respuesta'></div>");
        $("#respuesta" + respuestaID).append("<div class='form-check form-check-inline'><input type='checkbox' id='checkbox" + respuestaID +  "'  class='form-check-input' name='respuestaCorrecta" + preguntaNum+"'' onchange='addAnswerAttr(" + preguntaNum + ",\"" + count + "\",0)' value='respuesta'>Correct Answer</div>");
        $("#respuesta" + respuestaID).append("<button onclick='removeMultiple(" + preguntaNum + ",\"" + count + "\")' class='btn-danger'><img src='Resources/delete.png' alt='Delete' title='Delete' / ></button><br><br>");
        
    }
}
function removeMultiple(preguntaNum, countValue)
{
    var respuestaID = String(preguntaNum) + countValue;
    $("#respuesta" + respuestaID).remove();
    $("#respuesta" + respuestaID).remove();
    var index = preguntasDirectory[preguntaNum].multipleID.indexOf(respuestaID);
    preguntasDirectory[preguntaNum].multipleID.splice(index, 1);
}
function addAnswerAttr(preguntaNum,count,option)
{
    if (option == 0)
    {
        var questionID = "answerInput" + String(preguntaNum) + "" + String(count);
        var state = $('#' + questionID).attr("correct");
        
        if (String(state) == "0")
        {
            $('#' + String(questionID)).attr("correct", "1");
        }
        else
        {
            $('#' + String(questionID)).attr("correct", "0");
        }
    }
}
function addAnswerAttrTrueFalse(elementID,preguntaNum,brotherNum)
{
    elementID = "#" + elementID;
    var state = $(elementID).attr("correct");
    var brotherID = "#radioTF" + String(preguntaNum) + String(brotherNum);
    if (String(state) == "0")
    {
        $(elementID).attr("correct", "1");
        $(brotherID).attr("correct", "0");
    }
    else
    {
        $(elementID).attr("correct", "0");
        $(brotherID).attr("correct", "1");
    }
}
function appendTrueFalse(preguntasCount,language)
{
    var True = "";
    var False = "";
    if (language == "EN") { True = "True"; False = "False"; }
    else if (language == "ES") { True = "Cierto"; False = "Falso"; }
    var radio = "<input type='radio' id='radioTF" + String(preguntasCount) + "0' class='form-check-input' required name='respuestaCorrectaCF" + String(preguntasCount) + "' correct='0' onchange='addAnswerAttrTrueFalse(this.id," + String(preguntasCount) + ",1)' value='"+True+"' /> "+True+" <input type='radio' id='radioTF" + String(preguntasCount) + "1' class='form-check-input' required correct='1' onchange='addAnswerAttrTrueFalse(this.id," + String(preguntasCount) + ",0)' checked name='respuestaCorrectaCF" + String(preguntasCount) + "' value='"+False+"' />"+False;
    var div = "<div id='respuesta" + preguntasCount +"CF' class='form-check form-check-inline'> "+radio+" </div>";
    return div;
}
function deleteQuestion(preguntaNum,option)
{
    var preguntaID = "pregunta" + String(preguntaNum);
    $("#" + preguntaID).remove();
    var index = 0;
    for (var i = 0; i <preguntasDirectory.length; i++) 
    {
        if (preguntasDirectory[i].preguntaID.includes(preguntaID))
        {
            index = i;
        }
    }
    preguntasDirectory.splice(index, 1);
    if (option == 0)
    {
        multipleCount -= 1;
    }
    else if (option == 1)
    {
        truefalseCount -= 1;
    }
}
function reloadAllVariables()
{
    preguntasDirectory = [];
    validQuestion = false;
    validAnswer = false;
    validTittle = false;
    ImageData = [];
    multipleCount = 0;
    truefalseCount = 0;
}
function checkValidation()
{
    verifyAllFields();
    if (validTittle && validQuestion && validAnswer)
    {
        $("#loadingDiv").css("visibility", "visible");
        $("#buttonSaveChanges").attr('disabled', 'disabled');
        retriveallInformation(0);
    }
}
function verifyAllFields()
{
    setInvalidForRules(false);
    if (multipleCount == 0)
    {
        validAnswer = true;
    }
    for (var i = 0; i < preguntasDirectory.length; i++)
    {
        var id = $("#" + String(preguntasDirectory[i].preguntaID)).find("input[type=text][name=preguntaTexto]").attr("id");
        validateQuestionText(id);
        var validateMultiple = [];
        for (var j = 0; j < preguntasDirectory[i].multipleID.length; j++)
        {
            var id = "answerInput" + String(preguntasDirectory[i].multipleID[j]);
            validateAnswerText(id);
            var answerID = "answerInput" + preguntasDirectory[i].multipleID[j];
            var value = $("#" + answerID).attr("correct");
            validateMultiple.push(String(value));
        }
        if (!(validateMultiple.indexOf("1") >= 0) && preguntasDirectory[i].multipleID.length>0 )
        {
            validQuestion = false;
            setInvalidForRules(true);
            //Invalid for correct selected
            break;
        }
        if (multipleCount > 0 && preguntasDirectory[i].multipleID.length > 0)
        {
            if (preguntasDirectory[i].multipleID.length < 3)
            {
                validQuestion = false;
                setInvalidForRules(true);
                //Invalid for multiple amount
                break;
            }
        }
        if (validTittle == false | validQuestion == false | validAnswer == false)
        {
            break;
        }
    }
    if (preguntasDirectory.length % 5 != 0 | !(preguntasDirectory.length > 0))
    {
        validQuestion = false;
        setInvalidForRules(true);
        //Question amount
    }
    if (validTittle && validQuestion && validAnswer)
    {
        $("#modalSaveChanges").modal();
    }
    else
    {
        $("#modalErrorMessage").modal();
    }
}
function retriveallInformation(flag)
{
    var JSONarray = [];
    var imageUpload = false;
    var formData = new FormData();
    for (var i = 0; i < preguntasDirectory.length; i++)
    {
        var Question = new Object();
        var multiple = [];
        var multipleCorrectAnswers = [];
        var truefalse = [];
        var truefalseCorrectAnswers = [];
        var question = $("#" + String(preguntasDirectory[i].preguntaID)).find("input[type=text][name=preguntaTexto]").val();
        Question.id = i;
        Question.question = question;
        Question.image = "";
        for (var j = 0; j < preguntasDirectory[i].multipleID.length; j++)
        {
            var multipleAns = $("#answerInput" + String(preguntasDirectory[i].multipleID[j])).val();
            multiple.push(multipleAns);
            var answer = "";
            var answerID = "answerInput" + preguntasDirectory[i].multipleID[j];
            var value = $("#" + answerID).attr("correct");
            if (value == "1")
            {
                answer = $("#" + answerID).val();
            }
            multipleCorrectAnswers.push(answer);
        }
        for (var j = 0; j < preguntasDirectory[i].ciertofalsoID.length; j++)
        {
            var language = $("#languageSelect").val();
            var True = "";
            var False = "";
            if (language == "EN") { True = "True"; False = "False"; }
            else if (language == "ES") { True = "Cierto"; False = "Falso"; }
            var answers = $("#" + String(preguntasDirectory[i].ciertofalsoID[j])).find("input[correct=1][type=radio]:checked").val();
            truefalse.push([True, False]);
            truefalseCorrectAnswers.push(answers);
        }
        if (preguntasDirectory[i].image == 1)
        {
            var id = $("#" + String(preguntasDirectory[i].preguntaID)).find("input[type=file]").attr("id");
            var element = document.getElementById(id);
            if (element.files.length > 0)
            {
                var ext = getExtension(element.files[0].name);
                var name = getUniqueID() + "." + ext;
                var blob = element.files[0].slice(0, element.files[0].size, 'image/'+ext);
                var file = new File([blob], name, { type: 'image/' + ext });
                formData.append(name, file);
                Question.image = name;
                imageUpload = true;
            }
            else if (ImageData.length > 0)
            {
                var preguntasCount = preguntasDirectory[i].preguntaID.substring(preguntasDirectory[i].preguntaID.indexOf("a") + 1, preguntasDirectory[i].preguntaID.length);
                for (var j = 0; j < ImageData.length; j++)
                {
                    if (ImageData[j].id == preguntasCount)
                    {
                        Question.image = ImageData[j].image;
                        ImageData.splice(j, 1);
                        break;
                    }
                }
            }
        }
        Question.multiple = multiple;
        Question.multipleCorrectAnswers = multipleCorrectAnswers;
        Question.truefalse = truefalse;
        Question.truefalseCorrectAnswers = truefalseCorrectAnswers;
        JSONarray.push(Question);
    }
    if (imageUpload)
    {
        uploadImages(formData, JSONarray, flag);
    }
    else
    {
       var examTittle = $("#examTittle").val();
       var username = sessionStorage["usuario"];
       var language = $("#languageSelect").val();
       var area = $("#areaSelect").val();
       sendDataToServer(JSON.stringify(JSONarray), examTittle, username, language, area, flag, "buttonSaveChanges");
    }
}
function getUniqueID()
{
    return '_' + Math.random().toString(36).substr(2, 9);
}
function uploadImages(formData, JSONarray, flag)
{
    $.ajax({
        type: "POST",
        url: "Handler.ashx/ProcessRequest",
        contentType: false,
        cache: false,
        processData: false,
        data: formData,
        async: true,
        success: function (response)
        {
            var examTittle = $("#examTittle").val();
            var username = sessionStorage["usuario"];
            var language = $("#languageSelect").val();
            var area = $("#areaSelect").val();
            
            if (String(response) == "1")
            {
                sendDataToServer(JSON.stringify(JSONarray), examTittle, username, language, area, flag, "buttonSaveChanges");
            }
            else if (String(response) == "2")
            {
                sendDataToServer(JSON.stringify(JSONarray), examTittle, username, language, area, flag, "buttonSaveChanges");
            }
            /*else
            {
                var newJSONarray = replaceImageValues(JSONarray, data.text());
                sendDataToServer(JSON.stringify(newJSONarray), examTittle, username, language, area, flag, "buttonSaveChanges");
            }*/
        },
        error: function (result)
        {
            console.log(result.status + ' ' + result.statusText);
        },
    });
}
function replaceImageValues(JSONarray, response)
{
    var responseJSONarray = JSON.parse(response);
    for (var i = 0; i < responseJSONarray.length; i++)
    {
        for (var j = 0; j < JSONarray.length; j++)
        {
            var index = JSONarray[i].image.indexOf(responseJSONarray[i].name);
            if (index >= 0)
            {
                JSONarray[i].image = responseJSONarray[i].nameChanged;
                break;
            }
        }
    }
    return JSONarray;
}
function validateQuestionText(id)
{
    var text = $("#" + String(id)).val();
    const regexp = /[^\w\s]/;//REGULAR EXPRESSION
    var result = regexp.test(text);
    result = false;
    if (!result && text != "")
    {
        validQuestion = true;
        $("#" + String(id)).removeClass("is-invalid");
    }
    else
    {
        validQuestion = false;
        $("#" + String(id)).addClass("is-invalid");
    }
}
function validateTittleText(id)
{
    var text = $("#" + String(id)).val();
    const regexp = /[^\w\s]/;//REGULAR EXPRESSION
    const result = regexp.test(text);

    if (!result && text != "")
    {
        validTittle = true;
        $("#" + String(id)).removeClass("is-invalid");
    }
    else
    {
        validTittle = false;
        $("#" + String(id)).addClass("is-invalid");
    }
}
function validateAnswerText(id)
{
    var text = $("#" + String(id)).val();
    const regexp = /[^\w\s]/;//REGULAR EXPRESSION
    var result = regexp.test(text);
    result = false;
    if (!result && text != "")
    {
        validAnswer = true;
        $("#" + String(id)).removeClass("is-invalid");
    }
    else
    {
        validAnswer = false;
        $("#" + String(id)).addClass("is-invalid");
    }
}
function setInvalidForRules(flag)
{
    if (flag)
    {
        $("#rules").addClass("panel-warning");
    }
    else
    {
        $("#rules").removeClass("panel-warning");
    }
}
function sendDataToServer(JSONstring,examTittle,username,language,area,flag,buttonID)
{
    if (flag == 1)
    {
        flag =sessionStorage["id_examen"];
    }
    $.ajax({
        url: "WebService.asmx/setExamData",
        data: "{ 'JSONstring': '"+JSONstring+"', 'examTittle': '"+examTittle+"', 'area': '"+area+"', 'lang': '"+language+"', 'username': '"+username+"', 'flag': '"+flag+"' }",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
            if (response.d == "1" & ImageData.length > 0)
            {
                requestDeleteFile(JSON.stringify(ImageData));
            }
            setTimeout(function ()
            {
                $("#loadingDiv").css("visibility", "hidden");
                $("#" + buttonID).removeAttr("disabled");
                if (response.d == "1")
                {
                   reloadAllVariables()
                   location.reload();
                }
            },
            2000);
        },
        error: function (result)
        {
            $("#loadingDiv").css("visibility", "hidden");
            $("#" + buttonID).removeAttr("disabled");
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function verifyExamTittleOnServer(id)
{
    validTittle = false;
    var examTittle = $("#" + String(id)).val();
    var language = $("#languageSelect").val();
    var username = sessionStorage["usuario"];
    $.ajax({
        url: "WebService.asmx/requestExamTittle",
        data: "{'examTittle': '" + examTittle + "', 'lang': '" + language + "', 'username': '" + username + "'}",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
            if (response.d == "2")
            {
                validTittle = false;
                $("#" + String(id)).addClass("is-invalid");
            }
            else
            {
                validateTittleText(id);
            }
        },
        error: function (result)
        {
            alert(result.status + ' ' + result.statusText);
        }
    });
}
function requestDeleteFile(JSONstring)
{
    $.ajax({
        url: "WebService.asmx/requestDeleteFiles",
        data: "{ 'JSONstring': '"+JSONstring+"' }",
        contentType: "application/json",
        type: "post",
        async: true,
        success: function (response)
        {
            
        },
        error: function (result)
        {
            
        }
    });
}
function returnToExams() {
    window.location.replace("ViewExams.aspx");
}
function returnMenu() {
    window.location.replace("menuCeap.aspx");
}
function setLanguage()
{
    $("#languageSelect").attr("disabled", "disabled");
    $("#languageSelect").val($("#languageSelect2").val());
    $("#modalLanguage").modal('hide');
}