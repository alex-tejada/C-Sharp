<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Repbeneficios.aspx.cs" Inherits="Repbeneficios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sugerencias</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/menu.css" rel="stylesheet" />
    <link href="Content/CapSug.css" rel="stylesheet" />
    <link href="Content/repben.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous"/>
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet"/>
    <link href="Content/jquery-confirm.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div class="pos-f-t">
            <nav class="navbar navbar-dark bg-sugg suggnav">
                <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon "></span>
                </button>
                <h3><b>REPORTE DE BENEFICIOS</b></h3>
                <div class="div-logo" onclick="window.location.href = 'menu.aspx'">
                    <b style="position: relative;">Menú Principal</b>
                    <img src="Resources/logo%202%20esquinas.png" class="logoesquina"/>
                </div>            </nav>
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
                <div class="col-9 menu">
                    <div class="row">
                        <div class="col-8">
                            <div class="col scrollable">
                                <table class="table table-striped">
                                    <thead class="sticky-top tbl-reportes">
                                    <tr>
                                        <th scope="col">No. de reloj</th>
                                        <th scope="col">NOMBRE </th>
                                        <th scope="col">ÁREA</th>
                                        <th scope="col">BENEFICIO</th>
                                    </tr>
                                    </thead>
                                    <tbody id="tbl_benefits">
                                    </tbody>
                                </table>
                        </div>
                        </div>
                        <div class="col-4 fechassp">
                            <div class="row">
                                <div class="col">
                                    <label for="problema">Desde</label>
                                     <input type="date" class="form-control txta" id="desde" onchange="get_all_benefits()"/>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col">
                                    <label for="problema">Hasta</label>
                                     <input type="date" class="form-control txta" id="hasta" onchange="get_all_benefits()"/>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col icons">
                            <img src="Resources/filtrar.png" class="ops" onclick="window.location.href = 'FiltroBeneficios.aspx';"/>
                            <img src="Resources/enviar.png" class="ops" onclick=" get_excel()"/>
                        </div>
                    </div>
                </div>
                <div class="col-3 menu2">
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



        <!--Modal correo-->
           <div class="modal" tabindex="-1" role="dialog" id="EmailModal">
              <div class="modal-dialog" role="document">
                <div class="modal-content">
                  <div class="modal-header">
                    <h5 class="modal-title">ENVIAR REPORTE</h5>
                  </div>
                  <div class="modal-body">
                    <div class="container">
                        <div class="row">
                            <div class="col">
                                <label for="area">Correo Electrónico</label>
                                    <input type="email" class="form-control" id="correo" placeholder="nombre@us.bosch.com" runat="server"/>
                            </div>
                        </div>
                    </div>
                  </div>
                  <div class="modal-footer">
                      <img src="Resources/aceptar.png" class="botonmodal" onclick="sendReport()"/>
                      <img src="Resources/cancelar.png" class="botonmodal" data-dismiss="modal"/>
                  </div>
                </div>
              </div>
            </div>
        <!---->


        <!-- Fin Modals -->
    </div>
    </form>
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-confirm.js"></script>
    <script src="Scripts/access.js"></script>
    <script src="Scripts/repbeneficios.js"></script>
</body>
</html>

