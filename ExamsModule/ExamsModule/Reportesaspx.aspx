<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Reportesaspx.aspx.cs" Inherits="Reportesaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sugerencias</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/CapSug.css" rel="stylesheet" />
    <link href="Content/jquery-confirm.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous"/>
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
                <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon "></span>
                </button>
                <h3><b>REPORTES</b></h3>
                <div class="div-logo" onclick="window.location.href = 'menu.aspx'">
                    <b style="position: relative;">Menú Principal</b>
                    <img src="Resources/logo%202%20esquinas.png" class="logoesquina"/>
                </div>            
            </nav>
            <div class="collapse enc" id="navbarToggleExternalContent">
                <div class="p-4 bg-sugg">
                    <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                      <li class="nav-item">
                        <a class="nav-link btn-click" onclick="has_access('D','adminBPS.aspx')">Administración BPS</a>
                      </li>
                      <li class="nav-item">
                        <a class="nav-link" href="Reportesaspx.aspx">Reportes</a>
                      </li>
                      <li class="nav-item">
                        <a class="nav-link btn-click" onclick="has_access('B', 'CambioPassword.aspx')">Cambio de Pasword</a>
                      </li>
                      <li class ="nav-item">
                          <a class="nav-link btn-click" onclick="cerrar_sesion()">Salir</a>
                      </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="container contenido">
            <div class="row inside">
                <div class="col-8 menu">
                    <div class="row">
                        <div class="col">
                            <img src="Resources/reporteben.png" class="btns3" onclick="has_access('D','Repbeneficios.aspx')"/>
                        </div>
                        <div class="col">
                            <img src="Resources/estadisticas.png" class="btns3" onclick="has_access('C', 'EstadisticasGen.aspx')"/>
                        </div>
                        <div class="col">
                            <img src="Resources/histsug.png" class="btns3" onclick="window.location.href = 'HistSugEmp.aspx'";/>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col">
                            <img src="Resources/regeneral.png" class="btns3" onclick="window.location.href= 'FiltroBeneficios.aspx'"/>
                        </div>
                        <div class="col">
                            <img src="Resources/infosug.png" class="btns4" onclick="window.location.href= 'InformacionSugerencia.aspx'"/>
                        </div>
                        <div class="col">
                        </div>
                    </div>
                </div>
                <div class="col-4 menu2">
                    <div class="row">
                        <div class="col">
                            <div class="row">
                                <div class="col">
                                    <b>Usuario(a):</b><br />
                                    <label class="bg-sugg-cuenta" id="user">User</label><br /><br />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <b>No. Asociado</b><br />
                                    <label class="bg-sugg-cuenta" id="no_empleado"></label>
                                </div>
                            </div>
                        </div>
                        <div class="col">
                            <img src="Resources/icono%20usuario.png" class="user" />
                        </div>
                    </div>
                </div>
            </div>
        </div>



        <!-- Modals --->

        <!-- Modal Filtros Deptes -->
            <div class="modal" tabindex="-1" role="dialog" id="filtros">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                    <h5 class="modal-title">FILTROS DEPARTAMENTALES</h5>
                  </div>
                  <div class="modal-body">
                    <div class="container">
                        <div class="row">
                            <div class="col">
                                <label for="area">Area</label>
                                <label class="select">
                                    <select name="area" id="area">
                                        <option>VS1</option>
                                        <option>VS2</option>
                                        <option>VS3</option>
                                    </select>
                                </label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label for="area">División</label>
                                <label class="select">
                                    <select name="area" id="area">
                                        <option>AE</option>
                                        <option>AE2</option>
                                        <option>EE</option>
                                    </select>
                                </label>
                            </div>
                        </div>
                        <div class="row">
                                <div class="col">
                                     <label for="problema">Personal</label>
                                     <input type="text" class="form-control txta" id="problema"/>
                                </div>
                            </div>
                    </div>
                  </div>
                  <div class="modal-footer">
                      <img src="Resources/guardar.png" class="botonmodal"/>
                      <img src="Resources/cancelar.png" class="botonmodal" data-dismiss="modal"/>
                  </div>
                </div>
              </div>
            </div>
        <!-- Fin Modal Filtros deptes -->

        <!-- Modal Administrador de Areas -->
            <div class="modal" tabindex="-1" role="dialog" id="adminareas">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                    <h5 class="modal-title">ADMINISTRACIÓN DE AREAS</h5>
                  </div>
                  <div class="modal-body">
                    <div class="container">
                        <div class="row">
                            <div class="col">
                                <label for="area">Departamento</label>
                                <label class="select">
                                    <select name="area" id="aadepto">
                                        <option>VS1</option>
                                        <option>VS2</option>
                                        <option>VS3</option>
                                    </select>
                                </label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label for="area">Áreas</label>
                                <label class="select">
                                    <select name="area" id="aaarea">
                                        <option>AE</option>
                                        <option>AE2</option>
                                        <option>EE</option>
                                    </select>
                                </label>
                            </div>
                        </div>
                    </div>
                  </div>
                  <div class="modal-footer">
                      <img src="Resources/guardar.png" class="botonmodal"/>
                      <img src="Resources/cancelar.png" class="botonmodal" data-dismiss="modal"/>
                  </div>
                </div>
              </div>
            </div>
        <!-- Fin Modal Administrador de Areas -->

        <!-- Modal Beneficios -->
            <div class="modal" tabindex="-1" role="dialog" id="beneficios">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                      <span aria-hidden="true">&times;</span>
                    </button>
                    <h5 class="modal-title">BENEFICIOS</h5>
                  </div>
                  <div class="modal-body">
                    <div class="container">
                        <div class="row">
                            <div class="col">
                                <label for="basociado">Asociado</label>
                                <input type="text" class="form-control txta" id="basociado"/>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label for="bdesde">Desde</label>
                                <label class="select">
                                    <select name="bsdesde" id="bsdesde">
                                        <option>01/22/2019</option>
                                        <option>01/21/2019</option>
                                        <option>01/20/2019</option>
                                    </select>
                                </label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label for="bshasta">Hasta</label>
                                <label class="select">
                                    <select name="bshasta" id="bshasta">
                                        <option>01/22/2019</option>
                                        <option>01/21/2019</option>
                                        <option>01/20/2019</option>
                                    </select>
                                </label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label for="btotal">Total</label>
                                <input type="text" class="form-control txta" id="btotal"/>
                            </div>
                        </div>
                    </div>
                  </div>
                  <asp:GridView runat="server" ID="gvRecord"></asp:GridView>
                    <table runat="server" id="tabla1"></table>
                </div>
              </div>
            </div>
        <!-- Fin Modal Beneficios -->


        <!-- Fin Modals -->
    </div>
    </form>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-confirm.js"></script>
    <script src="Scripts/access.js"></script>
    <script src="Scripts/reportesaspx.js"></script>
</body>
</html>
