<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckExam.aspx.cs" Inherits="CheckExam" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id='titleCheckExam'>Exam</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/exam.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/jquery-confirm.css" rel="stylesheet" />
    <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jquery-confirm/3.3.2/jquery-confirm.min.css" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script src="Scripts/newExam.js"></script>
    <script src="Scripts/checkExam.js"></script>
</head>
<body>
    <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
               <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                   <span class="navbar-toggler-icon "></span>
               </button>
               <img src="Resources/logo%202%20esquinas.png" class="logoesquina" />
            </nav>
            <div class="collapse enc" id="navbarToggleExternalContent">
                <div class="p-4 bg-sugg">
                    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnMenu()">Main</a>
                      </li>
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnToAllowed()">Allowed Exams</a>
                      </li>
                    </ul>
                </div>
            </div>
     </div><br /><br />
    <div class="container">
       <div class="col-lg-12 col-md-9 col-sm-6 col-xs-4">
           <br />
           <div class="text-center" id="examTittle"></div> <br />
           <div class="text-center"><img style="width:50px;height:50px;" src="Resources/timer.gif" alt="Timer" /><label id="timer"></label> </div>
           <br />
           <form class="" id="creationExamForm" onsubmit="event.preventDefault();event.stopPropagation();">
               <hr />
               <div class="form-row shadow" id="questions">
                    
               </div>
               <br />
               <div class="text-center">
                  <button style="visibility:hidden;" id="buttonOpenFinish" type="button" class="btn btn-primary"  data-toggle="modal" data-target="#modalFinishExam"><label id="buttonOpenFinishText">Finish exam</label></button>
               </div>
               <br /> 
               <br />
           </form>
        </div>
        <div class="modal" tabindex="-1" id="modalFinishExam" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title"><label id="titleEnd">Finish</label></h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                        <p><label id="titleEndSave">Please confirm you want to finalize the exam. Once submitted you won’t be able to access it again</label></p>
                      </div>
                      <div class="modal-footer">
                         <div id="loadingDiv" style="visibility:hidden;" class="spinner-grow spinner-grow-sm" role="status">
                           <span class="sr-only"><label id="buttonDialogFinish">Finishing</label></span>
                         </div>
                        <button type="button" id="buttonFinish" class="btn btn-primary" onclick="prepareDataToSend();"><label id="buttonConfirmFinish">Confirm</label></button>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal"><label id="buttonCancelFinish">Cancel</label></button>
                      </div>
                    </div>
                  </div>
                </div>
        <div class="modal" tabindex="-1" id="modalFinalScore" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                          <div class="text-center">
                              <img src="Resources/finished.png" alt="finished" /> <br /> <label id="finalDialog">Exam finished</label> <br /> <p id="score"></p>
                          </div>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal"><label id="">Ok</label></button>
                      </div>
                    </div>
                  </div>
                </div>
        <div class="modal" tabindex="-1" id="modalAccessDenied" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                          <div class="text-center">
                              <img src="Resources/denied.png" alt="finished" /> <br /> <label id="deniedTitle">You don't have access to this exam, request to the instructor</label>
                          </div>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal" onclick="returnTitle();"><label id="deniedReturn">Return</label></button>
                      </div>
                    </div>
                  </div>
                </div>
        <div class="modal" tabindex="-1" id="modalTimeover" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                          <div class="text-center">
                              <img src="Resources/timeover.png" alt="time over" /> <br /> <br /> <label id="timeoverDialog">Timeover, your answers have been sent</label>
                          </div>
                      </div>
                      <div class="modal-footer">
                      </div>
                    </div>
                  </div>
                </div>
    </div>
</body>    
</html>

