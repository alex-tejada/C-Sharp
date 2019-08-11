<%@ Page Language="C#" AutoEventWireup="true" CodeFile="NewExam.aspx.cs" Inherits="NewExam" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New Exam</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/exam.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/jquery-confirm.css" rel="stylesheet" />
    <link href="http://hayageek.github.io/jQuery-Upload-File/4.0.11/uploadfile.css" rel="stylesheet"/>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="http://hayageek.github.io/jQuery-Upload-File/4.0.11/jquery.uploadfile.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script src="Scripts/newExam.js"></script>
</head>
<body>
     <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
               <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                   <span class="navbar-toggler-icon "></span>
               </button>
               <h1>New Exam</h1>
               <img src="Resources/logo%202%20esquinas.png" class="logoesquina" />
            </nav>
            <div class="collapse enc" id="navbarToggleExternalContent">
                <div class="p-4 bg-sugg">
                    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnMenu()">Main</a>
                      </li>
                        <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnToExams()">Exams</a>
                      </li>
                    </ul>
                </div>
            </div>
     </div><br /><br />
    <div class="container">
       <!--<div class="col-lg-12 col-md-9 col-sm-6 col-xs-4">-->
           <hr />
           <form class="" id="creationExamForm" onsubmit="event.preventDefault();event.stopPropagation();">
               <div class="form-row">
                   <div class="form-group col-lg-12 col-md-11 col-sm-10 col-xs-10">
                       <br /> <button id="guardarExamen" style="float:right;" class="btn btn-success"  onclick="verifyAllFields()">End and Save</button>
                       <div id="rules" class="" style="padding:5px;"> 
                            <span class="lead">Rules:</span> 
                            <ul>
                               <li>Questions should be at least 5 and a maximum of 15 into a five-multiple (e.g. 5,10,15).</li>
                               <li>Minimum 3 answers (Only in multiple answer).</li>
                               <li>Select at least 1 correct answer (Only in multiple answer).</li>   
                            </ul>
                       </div>
                       <div class="exam-tools shadow"> 
                          <br/>
                           <label for="language">Language:</label>
                           <select name="language" id="languageSelect" onchange="verifyExamTittleOnServer('examTittle');" class="form-control-sm form-check-inline">
                              <option value="ES" >Espa&ntilde;ol</option>
                              <option value="EN" >English</option>
                           </select>
                           <label for="area">Area:</label>
                           <select id="areaSelect" class="form-control-sm form-check-inline">
                              <option value="9" selected>Controlling</option>
                              <option value="10">Investments Machine and Equipment</option>
                              <option value="6">Logistics</option>
                              <option value="2">Production</option>
                              <option value="4">Packaging</option>
                              <option value="1">Quality Management</option>
                              <option value="5">Samples To Customer</option>
                              <option value="7">Shipping</option>
                              <option value="11">Plant Maintenance</option>
                              <option value="12">Product Data Management</option>
                              <option value="8">Purchasing</option>
                              <option value="3">Warehouse</option>
                           </select><br/><br/>
                      </div>
                       <input type="text" id="examTittle" onchange="validateTittleText(this.id); verifyExamTittleOnServer(this.id);" class="form-control form-control-lg" name="name" value="" placeholder="Exam title"/><div class='invalid-feedback'><label id="invalidTitle">Title already exist/Special characters are not allowed</label></div>
                   </div>
                   <br />
                   <hr/>
                   <br/>
               </div>
               <div class="form-row shadow" id="preguntas">
                    
               </div>
               <div style="padding:15px;" class="exam-tools shadow">
                  <button id="nuevaPregunta" class="btn btn-primary" ><label id="buttonAddQuestions">Add question </label></button> 
                  <div class="form-check form-check-inline"> 
                     <input type="radio" required checked class="form-check-input" name="tipoRespuesta" value="multiple" /><label id="radioMultiple"> Multiple answer </label>
                  </div>
                  <div class="form-check form-check-inline"> 
                    <input type="radio" required class="form-check-input" name="tipoRespuesta" value="ciertofalso"/><label id="radioTruefalse"> True/False </label>
                  </div>
               </div>
               <div class="modal" tabindex="-1" id="modalSaveChanges" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title"><label id="titleSave">Save </label></h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                        <p><label id="titleEndSave"> End and save examen? </label></p>
                      </div>
                      <div class="modal-footer">
                         <div id="loadingDiv" style="visibility:hidden;" class="spinner-grow spinner-grow-sm" role="status">
                           <span class="sr-only">Loading...</span>
                         </div>
                        <button type="button" id="buttonSaveChanges" class="btn btn-primary" onclick="checkValidation();"><label id="buttonSave">Save</label></button>
                      </div>
                    </div>
                  </div>
                </div>
               <div class="modal fade" id="modalErrorMessage" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                  <div class="modal-dialog modal-dialog-centered" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title" id="exampleModalCenterTitle">Error</h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                          <div style="text-align:center;">
                              <div>
                                  <img style="max-height:100px;max-width:100px;margin:0 auto;"  src="Resources/error.png" alt="Error icon" />
                              </div><br />
                              <p >Should fulfill all the fields correctly!</p>
                          </div>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">OK</button>
                      </div>
                    </div>
                  </div>
                </div>
               <div class="modal" id="modalLanguage" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                  <div class="modal-dialog modal-dialog-centered" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                      </div>
                      <div class="modal-body">
                          <div style="text-align:center;">
                            <p>Please, select the language for the exam</p>
                          </div>
                          <div class="d-flex justify-content-center">
                            <br />
                            <select id="languageSelect2" onchange="setLanguage()" class="form-control-sm form-check-inline">
                              <option selected value=" " > </option>
                              <option value="ES" >Espa&ntilde;ol</option>
                              <option value="EN" >English</option>
                           </select>
                          </div>
                      </div>
                    </div>
                  </div>
                </div>
           </form>
        </div>
</body>
</html>

