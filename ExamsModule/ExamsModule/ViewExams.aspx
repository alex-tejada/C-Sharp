<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ViewExams.aspx.cs" Inherits="ViewExams" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title id='titleViewExams'>Exams</title>
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
    <script src="Scripts/viewExams.js"></script>
</head>
<body>
    <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
               <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                   <span class="navbar-toggler-icon "></span>
               </button>
               <h1>Exams</h1>
               <img src="Resources/logo%202%20esquinas.png" class="logoesquina" />
            </nav>
            <div class="collapse enc" id="navbarToggleExternalContent">
                <div class="p-4 bg-sugg">
                    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="returnMenu()">Main</a>
                      </li>
                    </ul>
                </div>
            </div>
     </div><br /><br />
    <div class="container">
        <br />
        <button type='button' class='btn-sm btn-primary' data-toggle='modal' data-target='#newExamModal'><img src='Resources/newexam.png' title='Add new exam' alt='add new exam' /></button>
        <br/>
        <br/>
        <table class="table table-sm" style="text-align:center;">
          <thead class="">
            <tr>
              <th scope="col">#</th>
              <th scope="col"><label id='tableTitle'>Title</label></th>
              <th scope="col"><label id='tableArea'>Area</label></th>
              <th scope="col"><label id='tableLanguage'>Language</label></th>
              <th scope="col"><label id='tableDate'>Creation Date</label></th>
              <th scope="col"></th>
              <th scope="col"></th>
              <th scope="col"></th>
              <th scope="col"></th>
            </tr>
          </thead>
          <tbody id="tableBody">

          </tbody>
        </table>
        <div class="modal" tabindex="-1" id="newExamModal" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title"><label id="newExamTittle">New Exam</label></h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                        <p> <label id="newExamConfirm"> Add new exam? </label></p>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-primary" onclick="openNewExamCreation();"> <label id="newExamAccept"> Accept</label></button>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal"><label id="newExamCancel"> Cancel</label></button>
                      </div>
                    </div>
                  </div>
                </div>
        <div class="modal" tabindex="-1" id="editExamModal" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title"><label id="editTittle"> Edit Exam</label></h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                        <p> <label id="editConfirm"> Edit exam? </label></p>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-primary" onclick=";" id="editAcceptButton"> <label id="editAccept"> Accept </label></button>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal"><label id="cancelEdit"> Cancel</label></button>
                      </div>
                    </div>
                  </div>
                </div>
        <div class="modal" tabindex="-1" id="deleteExamModal" role="dialog">
                  <div class="modal-dialog" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h5 class="modal-title"><label id="deleteTittle">Delete Exam</label></h5>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                        <p> <label id="deleteConfirm"> Are you sure to delete exam? </label></p>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-primary" onclick="" id="deleteAcceptButton"> <label id="deleteAccept"> Accept</label></button>
                        <button type="button" class="btn btn-secondary" data-dismiss="modal"><label id="cancelDelete"> Cancel</label></button>
                      </div>
                    </div>
                  </div>
                </div>
        <div class="modal" tabindex="-1" id="newUserExamModal" role="dialog">
                  <div class="modal-dialog modal-md" role="document">
                    <div class="modal-content">
                      <div class="modal-header">
                        <h6 class="modal-title"><label id="titleforExam"></label><label id="newUserTittle">Authorize user</label></h6>
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                          <span aria-hidden="true">&times;</span>
                        </button>
                      </div>
                      <div class="modal-body">
                              <div>
                                 <table id="tableResults" style="visibility:hidden;text-align:center;width:400px;display:inline" class="table table-sm">
                                    <thead>
                                      <tr>
                                        <th scope="col"><label id='tableAvailable'>Available users</label></th>
                                        <th scope="col"></th>
                                      </tr>
                                     </thead>
                                     <tbody id="tableResultsBody">
                                     </tbody>
                                 </table>
                                  <table id="tableAuthorized" style="visibility:hidden;text-align:center;width:400px;display:inline" class="table table-sm">
                                      <thead>
                                      <tr>
                                        <th scope="col"><label id='tableAuthorizedTitle'>Authorized</label></th>
                                        <th scope="col"></th>
                                      </tr>
                                     </thead>
                                     <tbody id="tableAuthorizedBody">
                                     </tbody>
                                  </table>
                              </div><br />
                          <div>
                              
                          </div>
                      </div>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-secondary" data-dismiss="modal"><label id="newUserCancel">Cancel</label></button>
                      </div>
                    </div>
                  </div>
                </div>
    </div>
</body>
</html>

