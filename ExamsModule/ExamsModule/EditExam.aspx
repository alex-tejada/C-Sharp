<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditExam.aspx.cs" Inherits="EditExam" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id='titleEditExam'>Edit Exam</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/exam.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/jquery-confirm.css" rel="stylesheet" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" type="text/css" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <link href="http://hayageek.github.io/jQuery-Upload-File/4.0.11/uploadfile.css" rel="stylesheet"/>
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js"></script>
    <script src="http://hayageek.github.io/jQuery-Upload-File/4.0.11/jquery.uploadfile.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script src="Scripts/newExam.js"></script> 
    <script src="Scripts/editExam.js"></script>
    </head>
<body>
    <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
               <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                   <span class="navbar-toggler-icon "></span>
               </button>
                <h1>Edit Exam</h1>
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
       <div class="col-lg-12 col-md-9 col-sm-6 col-xs-4">
           <br />
           <hr />
           <form class="" id="creationExamForm" onsubmit="event.preventDefault();event.stopPropagation();">
               <div class="form-row">
                    <div class="form-group col-lg-12 col-md-11 col-sm-10 col-xs-10">
                       <br /> 
                       <button id="guardarExamen" style="float:right;" class="btn btn-success"  onclick="verifyAllFields()">Save</button>
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
                           <select disabled name="language"  id="languageSelect" class="form-control-sm form-check-inline">
                              <option value="ES" selected>Espa&ntilde;ol</option>
                              <option value="EN" >English</option>
                           </select>
                           <label for="area">Area:</label>
                           <select disabled name="area" id="areaSelect" class="form-control-sm form-check-inline">
                              <option value="1" selected>Quality Management</option>
                              <option value="2" >Production</option>
                              <option value="3" >Warehouse</option>
                              <option value="4" >Packaging</option>
                              <option value="5" >Samples To Customer</option>
                              <option value="6" >Logistics</option>
                              <option value="7" >Shipping</option>
                              <option value="8" >Purchasing</option>
                              <option value="9" >Controlling</option>
                              <option value="10" >Investments Machine and Equipment</option>
                              <option value="11" >Plant Maintenance</option>
                              <option value="12" >Product Data Management</option>
                           </select> <br /> <br />
                      </div>
                   <input type="text" id="examTittle" readonly onchange="" class="form-control form-control-lg" name="name" value="" placeholder="Exam title"/><div class='invalid-feedback'>Special characters aren't allowed</div>
                   </div>
                   <br/>
                   <hr/>
                   <br/>
               </div>
               <div class="form-row shadow" id="preguntas">
                    
               </div>
               <div class="exam-tools shadow">
                   <button id="nuevaPregunta" class="btn btn-primary" >Add question</button> 
                          <div class="form-check form-check-inline"> 
                          <input type="radio" required checked class="form-check-input" name="tipoRespuesta" value="multiple"/> Multiple answer
                   </div>
                   <div class="form-check form-check-inline"> 
                      <input type="radio" required class="form-check-input" name="tipoRespuesta" value="ciertofalso"/> True/False
                   </div>
                   <br/>
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
                        <p><label id="titleEndSave">End and save exam? </label></p>
                      </div>
                      <div class="modal-footer">
                         <div id="loadingDiv" style="visibility:hidden;" class="spinner-grow spinner-grow-sm" role="status">
                           <span class="sr-only">Loading...</span>
                         </div>
                        <button type="button" id="buttonSaveChanges" class="btn btn-primary" onclick="checkValidationEdit();"><label id="buttonSave">Save</label></button>
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
                              <p ><label id="messageError">Should fulfill all the fields correctly!</label></p>
                          </div>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                      </div>
                    </div>
                  </div>
                </div>
               <div class="modal" id="modalErrorImage" tabindex="-1" role="dialog" aria-labelledby="exampleModalCenterTitle" aria-hidden="true">
                  <div class="modal-dialog modal-dialog-centered" role="document">
                    <div class="modal-content">
                      <div class="modal-header panel-warning">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                          <div style="text-align:center;">
                            <h5>Error with file selection</h5>
                            <div>
                                <img style="max-height:80px;max-width:80px;margin:0 auto;"  src="Resources/error.png" alt="Error icon" />
                            </div>
                          </div>
                          <div class="d-flex justify-content-center">
                            <ul>
                                <li>Maximum size: 1 MB</li>
                                <li>Allowed file types: jpg, gif, png</li>
                                <li>Duplicate names aren't allowed</li>
                            </ul>
                           </div>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal">OK</button>
                      </div>
                    </div>
                  </div>
                </div>
           </form>
        </div>
     </div>
</body>
</html>


