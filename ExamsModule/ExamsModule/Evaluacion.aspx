<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Evaluacion.aspx.cs" Inherits="Evaluacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Evaluación de entrenamiento</title>
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet"/>
    <link href="Content/menu.css" rel="stylesheet"/>
    <link href="Content/entrenamientoEval.css" rel="stylesheet"/>
    <link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.6.3/css/all.css" integrity="sha384-UHRtZLI+pbxtHCWp1t77Bi1L4ZtiqrqD80Kn4Z8NTSRyMA2Fd33n5dQ8lWUE00s/" crossorigin="anonymous"/>
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet"/>

    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-ui-1.12.1.js"></script>
    <script src="Scripts/jquery-confirm.js"></script>
    <script src="Scripts/accessCeap.js"></script>
    <script src="Scripts/evaluacion.js"></script>
</head>
<body>
    <form id="form1" runat="server" novalidate> <!--onsubmit="capture_missing_information()"> -->
        <div>
            <div class="pos-f-t">
                <nav class="navbar navbar-dark bg-sugg suggnav">
                    <button class="navbar-toggler custom-toggler" type="button" data-toggle="collapse" data-target="#navbarToggleExternalContent" aria-controls="navbarToggleExternalContent" aria-expanded="false" aria-label="Toggle navigation">
                        <span class="navbar-toggler-icon "></span>
                    </button>

                    <h3><b>EVALUACIÓN DE ENTRENAMIENTO</b> <br />
                        <center><b>TRAINING EVALUATION</b></center></h3>
               
                    <img src="Resources/logo%202%20esquinas.png" class="logoesquina"/>
                </nav>
                <div class="collapse enc" id="navbarToggleExternalContent">
                    <div class="p-4 bg-sugg">
                        <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                          <li class ="nav-item">
                              <a class="nav-link" onclick="cerrar_sesion()">Salir</a>
                          </li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class="container contenido">
                <div class="row inside">
                    <div class="col-8 menu oformu" id="section0">
                        <div class="col-12 formu" id="first">
                            <div class="col-12">
                                <br />
                                <div class="row rowDivision">
                                    <div class="col-12" style="text-align:center">
                                        <h4><b>Ingresa los datos faltantes<br /><small>Enter the missing information</small></b></h4>
                                        <br />
                                    </div>
                                </div>
                                <br />
                                <div class="col-12">
                                    <div class="row">
                                        <h5><b>Fecha<br /><small>Date</small></b></h5>
                                        <input type="date" class="form-control txta" name="date" id="fecha_ansEv" required="required"/>
                                    </div>
                                    <!--
                                    <br />
                                    <div class="row">
                                        <h5><b>Número de empleado<br /><small>Employee number</small></b></h5>
                                        <input type="number" step="1" class="form-control txta" name="open_answer_01" id="empN_ansEv" placeholder="Escribe aquí/Write here..."  required="required"/>  
                                    </div>
                                    -->
                                    <br />
                                    <div class="row">
                                        <h5><b>Curso<br /><small>Class Title</small></b></h5>
                                        <select class="form-control" id="ddl_exams" name="exams"></select>
                                    </div>
                                    <br />
                                    <div class="row">
                                        <h5><b>Instructor<br /><small>Instructor</small></b></h5>
                                        <input type="text" class="form-control txta" name="open_answer_02" id="instructor_ansEv" placeholder="Escribe aquí/Write here..."  required="required"/>
                                    </div>
                                    
                                    <div class="row">
                                        <br />
                                        <p style="text-align:justify">Esta evaluación ayudará a determinar si el curso cumplió con sus necesidades e intereses, así como proveer una base para el mejoramiento. <br />This evaluation will help to determine whether the course met your needs and interests, as well as provide a baseline for improvements.</p>
                                    </div>
                                    <br />
                                </div>
                                <div class="row">
                                    <div class="col-12" style="text-align:center">
                                        <input type="submit" class="btn btn-primary captura" id="next_btn0" onclick="section_0('1')" value="Guardar/Save"/>
                                    </div>
                                    <br />
                                    <br />
                                    <br />

                                    <div class="col-12" id="progress_0">
                                        <div id="bar_0"></div>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>

                    <div class="col-8 menu oformu" id="section1">
                        <div class="col-12 formu" id="second">
                            <div class="col-12">
                                <br />
                                <div class="row rowDivision">
                                    <div class="col-12" style="text-align:center">
                                        <h4><b>1. Objetivos</b><br /><small>Objectives</small></h4>
                                        <br />
                                    </div>
                                </div>
                                <br />
                                <div class="col-12">
                                    <div class="row">
                                        <h5><b>1.1 ¿A qué nivel se cumplieron los objetivos del curso?<br /><small>At what level were your objectives fulfilled?</small></b></h5>
                                    </div>                                 
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s11" value="s1l1" id="s11level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s11" value="s1l2" id="s11level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s11" value="s1l3" id="s11level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s11" value="s1l4" id="s11level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s11" value="s1l5" id="s11level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <div class="row rowDivision">
                                        <br />
                                    </div>
                                    <br />
                                    <div class="row">
                                        <h5><b>1.2 Si solo se cumplieron parcialmente, por favor explique:<br /><small>If only partially, please explain why:</small></b></h5>
                                        <input type="text" class="form-control txta" name="o_ans_12" id="open_answer_12" placeholder="Escribe aquí/Write here..." required="required"/>
                                    </div>
                                    <br />
                                </div>
                                <div class="row">
                                    <div class="col-6" style="text-align:right">
                                        <input type="submit" class="btn btn-primary captura" id="prev_btn1" onclick="section_1('0')" value="Anterior/Previous"/>
                                    </div>                                    
                                    <div class="col-6" style="text-align:left">
                                        <input type="submit" class="btn btn-primary captura" id="next_btn1" onclick="section_1('1')" value="Siguiente/Next"/>
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                    <div class="col-12" id="progress_1">
                                        <div id="bar_1"></div>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>

                    <div class="col-8 menu oformu" id="section2">
                        <div class="col-12 formu" id="third">
                            <div class="col-12">
                                    <br />
                                    <div class="row rowDivision">
                                        <div class="col-12" style="text-align:center">
                                            <h4><b>2. Relevancia del tema <br /><small>Subject relevance</small></b></h4>
                                            <br />
                                        </div>
                                    </div>
                                    <br />
                                    <div class="col-12">
                                        <div class="row">
                                            <h5><b>2.1 Aplicación en el trabajo<br /><small>Application in the job</small></b></h5>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s21" value="s21l1" id="s21level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s21" value="s21l2" id="s21level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s21" value="s21l3" id="s21level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s21" value="s21l4" id="s21level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s21" value="s21l5" id="s21level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                        </div>
                                        <div class="row rowDivision">
                                            <br />
                                        </div>
                                        <br />
                                        <div class="row">
                                            <h5><b>2.2 Claridad del tema presentado<br /><small>The information is clear</small></b></h5>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s22" value="s22l1" id="s22level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s22" value="s22l2" id="s22level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s22" value="s22l3" id="s22level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s22" value="s22l4" id="s22level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                        </div>
                                        <div class="row" style="margin-left:4vh">
                                            <label style="color:#000000"><input type="radio" name="s22" value="s22l5" id="s22level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                        </div>
                                        <br />
                                    </div>
                                <div class="row">
                                    <div class="col-6" style="text-align:right">
                                        <input type="submit" class="btn btn-primary captura" id="prev_btn2" onclick="section_2('0')" value="Anterior/Previous"/>
                                    </div>
                                    <div class="col-6" style="text-align:left">
                                        <input type="submit" class="btn btn-primary captura" id="next_btn2" onclick="section_2('1')" value="Siguiente/Next"/>
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                    <div class="col-12" id="progress_2">
                                        <div id="bar_2"></div>
                                    </div>
                                </div>
                                <br />
                                </div>
                        </div>
                    </div>

                    <div class="col-8 menu oformu" id="section3">
                        <div class="col-12 formu" id="fourth">
                            <div class="col-12">
                                <br />
                                <div class="row rowDivision">
                                    <div class="col-12" style="text-align:center">
                                        <h4><b>3. Recursos (manuales, ayudas visuales, vídeos, etc.)<br /><small>Resources (manuals, handouts, visual aids, videos, etc.)</small></b></h4>
                                        <br />
                                    </div>
                                </div>
                                <br />
                                <div class="col-12">
                                    <div class="row" >
                                        <h5><b>3.1 Relevancia del material<br /><small>Relevance of materials</small></b></h5>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s31" value="s31l1" id="s31level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s31" value="s31l2" id="s31level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s31" value="s31l3" id="s31level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s31" value="s31l4" id="s31level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s31" value="s31l5" id="s31level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <div class="row rowDivision">
                                        <br />
                                    </div>
                                    <br />
                                    <div class="row">
                                        <h5><b>3.2 Organización del contenido<br /><small>Organization of content</small></b></h5>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s32" value="s32l1" id="s32level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s32" value="s32l2" id="s32level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s32" value="s32l3" id="s32level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s32" value="s32l4" id="s32level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s32" value="s32l5" id="s32level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <br />
                                </div>
                                <div class="row">
                                    <div class="col-6" style="text-align:right">
                                        <input type="submit" class="btn btn-primary captura" id="prev_btn3" onclick="section_3('0')" value="Anterior/Previous"/>
                                    </div>
                                    <div class="col-6" style="text-align:left">
                                        <input type="submit" class="btn btn-primary captura" id="next_btn3" onclick="section_3('1')" value="Siguiente/Next"/>
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                    <div class="col-12" id="progress_3">
                                        <div id="bar_3"></div>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>

                    <div class="col-8 menu oformu" id="section4"> 
                        <div class="col-12 formu" id="fifth">
                            <div class="col-12">
                                <br />
                                <div class="row rowDivision">
                                    <div class="col-12" style="text-align:center">
                                        <h4><b>4. Calidad de la instrucción<br /><small>Instruction quality</small></b></h4>
                                        <%--<br />--%>
                                    </div>
                                </div>
                                <br />
                                <div class="col-12">
                                    <div class="row">
                                        <h5><b>4.1 Conocimiento del instructor acerca del tema</b><br /><small>Instructor's knowledge of the subject</small></h5>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s41" value="s41l1" id="s41level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s41" value="s41l2" id="s41level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s41" value="s41l3" id="s41level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s41" value="s41l4" id="s41level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s41" value="s41l5" id="s41level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <div class="row rowDivision">
                                        <br />
                                    </div>
                                    <br />
                                    <div class="row">
                                        <h5><b>4.2 Cobertura clara del material</b><br /><small>Clear coverage of the material</small></h5>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s42" value="s42l1" id="s42level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s42" value="s42l2" id="s42level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s42" value="s42l3" id="s42level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s42" value="s42l4" id="s42level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s42" value="s42l5" id="s42level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <div class="row rowDivision">
                                        <br />
                                    </div>
                                    <br />
                                    <div class="row">
                                        <h5><b>4.3 Oportunidad para hacer preguntas</b><br /><small>Opportunities to ask questions</small></h5>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s43" value="s43l1" id="s43level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s43" value="s43l2" id="s43level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s43" value="s43l3" id="s43level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s43" value="s43l4" id="s43level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s43" value="s43l5" id="s43level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <div class="row rowDivision">
                                        <br />
                                    </div>
                                    <br />
                                    <div class="row">
                                        <h5><b>4.4 Nivel de involucramiento/discusión del grupo</b><br /><small>Level of group involvement/discussion</small></h5>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s44" value="s44l1" id="s44level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s44" value="s44l2" id="s44level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s44" value="s44l3" id="s44level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s44" value="s44l4" id="s44level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s44" value="s44l5" id="s44level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <br />
                                </div>
                                <div class="row">
                                    <div class="col-6" style="text-align:right">
                                        <input type="submit" class="btn btn-primary captura" id="prev_btn4" onclick="section_4('0')" value="Anterior/Previous"/>
                                    </div>
                                    <div class="col-6" style="text-align:left">
                                        <input type="submit" class="btn btn-primary captura" id="next_btn4" onclick="section_4('1')" value="Siguiente/Next"/>
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                    <div class="col-12" id="progress_4">
                                        <div id="bar_4"></div>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>

                    <div class="col-8 menu oformu" id="section5"> 
                        <div class="col-12 formu" id="sixth">
                            <div class="col-12">
                                <br />
                                <div class="row rowDivision">
                                    <div class="col-12" style="text-align:center">
                                        <h4><b>5. Aspectos generales<br /><small>General aspects</small></b></h4>
                                        <br />
                                    </div>
                                </div>
                                <br />
                                <div class="col-12">
                                    <div class="row">
                                        <h5><b>5.1 Satisfacción general</b><br /><small>General satisfaction</small></h5>
                                        <br />
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s51" value="s51l1" id="s51level1" required="required"/><b>&nbsp; Por debajo de las expectativas.</b><br /><small style="margin-left:2.5vh">Below expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s51" value="s51l2" id="s51level2" required="required"/><b>&nbsp; Cumple las expectativas (bajo).</b><br /><small style="margin-left:2.5vh">Meets expectations (low).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s51" value="s51l3" id="s51level3" required="required"/><b>&nbsp; Cumple las expectativas.</b><br /><small style="margin-left:2.5vh">Meets Expectations.</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s51" value="s51l4" id="s51level4" required="required"/><b>&nbsp; Cumple las expectativas (alto).</b><br /><small style="margin-left:2.5vh">Meets Expectations (high).</small></label>
                                    </div>
                                    <div class="row" style="margin-left:4vh">
                                        <label style="color:#000000"><input type="radio" name="s51" value="s51l5" id="s51level5" required="required"/><b>&nbsp; Excede las expectativas.</b><br /><small style="margin-left:2.5vh">Exceeds Expectations.</small></label>
                                    </div>
                                    <br />
                                </div>
                                <div class="row">
                                    <div class="col-6" style="text-align:right">
                                        <input type="submit" class="btn btn-primary captura" id="prev_btn5" onclick="section_5('0')" value="Anterior/Previous"/>
                                    </div>
                                    <div class="col-6" style="text-align:left">
                                        <input type="submit" class="btn btn-primary captura" id="next_btn5" onclick="section_5('1')" value="Siguiente/Next"/>
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                    <div class="col-12" id="progress_5">
                                        <div id="bar_5"></div>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>

                    <div class="col-8 menu oformu" id="section6">
                        <div class="col-12 formu" id="seventh">
                            <div class="col-12">
                                <br />
                                <div class="row rowDivision">
                                    <div class="col-12" style="text-align:center">
                                        <h4><b>6. Habilidades/conocimientos y comentarios/sugerencias<br /><small>Skills/knowledge and comments/suggestions</small></b></h4> 
                                        <br />
                                    </div>
                                </div>
                                <br />
                                <div class="col-12">
                                    <div class="row">
                                        <h5><b>6.1 ¿Qué habilidades/conocimientos aprendió en el curso?</b><br /><small>What skills/knowledge did you learn in the course?</small></h5>
                                        <input type="text" class="form-control txta" name="o_ans_61" id="open_answer_61" placeholder="Escribe aquí/Write here..." required="required"/>
                                    </div>
                                    <br />
                                    <div class="row"> <!-- style="padding:1vh"> -->
                                        <h5><b>6.2 ¿Cómo utilizará estos conocimientos/habilidades para un mejor desempeño en Bosch?</b><br /><small>How will you use this skills/knowledge to perform better at Bosch?</small></h5>
                                        <input type="text" class="form-control txta" name="o_ans_62" id="open_answer_62" placeholder="Escribe aquí/Write here..." required="required"/>
                                    </div>
                                    <br />
                                    <div class="row"> <!-- style="padding:1vh"> -->
                                        <h5><b>6.3 Comentarios/sugerencias adicionales (ej. ¿la duración del curso fue apropiada? ¿el material estaba actualizado? ¿había partes confusas? ¿hay información que deba ser cambiada o agregada?)</b><br /><small>Additional comments/suggestions (i.e. was the course duration appropriate? were the materials updated? were any parts confusing? do you think necessary change or add information?)</small></h5>
                                        <input type="text" class="form-control txta" name="o_ans_63" id="open_answer_63" placeholder="Escribe aquí/Write here..." required="required"/>
                                    </div>
                                    <br />
                                </div>
                                <div class="row">
                                    <div class="col-6" style="text-align:right">
                                        <input type="submit" class="btn btn-primary captura" id="prev_btn6" onclick="section_6('0')" value="Anterior/Previous"/>
                                    </div>
                                    <div class="col-6" style="text-align:left">
                                        <input type="submit" class="btn btn-primary captura" id="next_btn6" onclick="section_6('1')" value="Terminar/Finish"/>
                                    </div>
                                    <br />
                                    <br />
                                    <br />
                                    <div class="col-12" id="progress_6">
                                        <div id="bar_6"></div>
                                    </div>
                                </div>
                                <br />
                            </div>
                        </div>
                    </div>

                    <div class="col-8 menu oformu" id="section7">
                        <div class="col-12 formu" id="eight">
                            <br />
                            <br />
                            <div class="col-12" style="text-align:center">
                                <h1><b>¡Gracias por contestar la encuesta!<br /><small>Thank you for answering the survey!</small></b></h1>
                            </div>
                            <div class="col-12">
                                <div class="col" style="text-align:center">
                                    <br />
                                    <br />
                                    <a href="menuCeap.aspx">
                                        <input type="submit" class="btn btn-primary captura" onclick="going_back()" id="goback" value="Regresar a menú/Go back to menu"/>
                                    </a>
                                    <br />
                                    <br />
                                    <br />
                                </div>
                            </div>
                        </div>
                        
                    </div>

                    <div class="col-4 menu2">
                        <div class="row">
                            <div class="col-6">
                                <div class="row">
                                    <br />
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>User:</b><br />
                                        <label class="bg-sugg-cuenta" id="user">User</label><br /><br />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>No. Asociado:</b><br />
                                        <label class="bg-sugg-cuenta" id="no_empleado_display"></label><br /><br />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>Fecha:</b><br />
                                        <label class="bg-sugg-cuenta" id="fecha_display"></label><br /><br />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>Curso:</b><br />
                                        <label class="bg-sugg-cuenta" id="curso_display"></label><br /><br />
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <b>Instructor(a):</b><br />
                                        <label class="bg-sugg-cuenta" id="instructor_display"></label><br /><br />
                                    </div>
                                </div>
                            </div>
                            <div class="col-6">
                                <img src="Resources/icono%20usuario.png" class="user"/>
                            </div>
                        </div>
                    </div>
                

                </div>
            <br />
            <br />
            <br />
            </div>
        </div>
    </form>
</body>
</html>