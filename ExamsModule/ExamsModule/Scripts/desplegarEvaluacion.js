$(document).ready(function () {
    //This section shows the user and employee number in the right side of the page.
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    //document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];

    if (sessionStorage["id_selectedEvaluation"] == undefined) {
        sessionStorage["id_selectedEvaluation"] = 0;
    }

    load_all_information();
    load_general_information();
    load_answers();
});

function load_all_information() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_all_information_of_evaluations",
        data: "{'Id_encuesta':'" + sessionStorage["id_selectedEvaluation"] + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            for (var i = 0; i < 18; i++) { if (result[i] == null) { result[i] = " "; } }
            sessionStorage["noReloj"] = result[0];
            sessionStorage["fecha"] = result[1];
            sessionStorage["curso"] = result[2];
            sessionStorage["instructor"] = result[3];
            sessionStorage["preg_11"] = result[4];
            sessionStorage["preg_12"] = result[5];
            sessionStorage["preg_21"] = result[6];
            sessionStorage["preg_22"] = result[7];
            sessionStorage["preg_31"] = result[8];
            sessionStorage["preg_32"] = result[9];
            sessionStorage["preg_41"] = result[10];
            sessionStorage["preg_42"] = result[11];
            sessionStorage["preg_43"] = result[12];
            sessionStorage["preg_44"] = result[13];
            sessionStorage["preg_51"] = result[14];
            sessionStorage["preg_61"] = result[15];
            sessionStorage["preg_62"] = result[16];
            sessionStorage["preg_63"] = result[17];
        }
    });
}

function load_general_information() {
    document.getElementById("emp_no").innerHTML = sessionStorage["noReloj"];
    document.getElementById("date").innerHTML = sessionStorage["fecha"];
    document.getElementById("class_title").innerHTML = sessionStorage["curso"];
    document.getElementById("instructor").innerHTML = sessionStorage["instructor"];
}

function load_answers() {
    if (sessionStorage["preg_11"] != " ") { document.getElementById("s11_" + sessionStorage["preg_11"]).checked = true; document.getElementById("s11_" + sessionStorage["preg_11"] + "_ch").style.backgroundColor = "aliceblue"; };
    document.getElementById("s12").innerHTML = sessionStorage["preg_12"];
    if (sessionStorage["preg_21"] != " ") { document.getElementById("s21_" + sessionStorage["preg_21"]).checked = true; document.getElementById("s21_" + sessionStorage["preg_21"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    if (sessionStorage["preg_22"] != " ") { document.getElementById("s22_" + sessionStorage["preg_22"]).checked = true; document.getElementById("s22_" + sessionStorage["preg_22"] + "_ch").style.backgroundColor = "aliceblue"; };
    if (sessionStorage["preg_31"] != " ") { document.getElementById("s31_" + sessionStorage["preg_31"]).checked = true; document.getElementById("s31_" + sessionStorage["preg_31"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    if (sessionStorage["preg_32"] != " ") { document.getElementById("s32_" + sessionStorage["preg_32"]).checked = true; document.getElementById("s32_" + sessionStorage["preg_32"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    if (sessionStorage["preg_41"] != " ") { document.getElementById("s41_" + sessionStorage["preg_41"]).checked = true; document.getElementById("s41_" + sessionStorage["preg_41"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    if (sessionStorage["preg_42"] != " ") { document.getElementById("s42_" + sessionStorage["preg_42"]).checked = true; document.getElementById("s42_" + sessionStorage["preg_42"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    if (sessionStorage["preg_43"] != " ") { document.getElementById("s43_" + sessionStorage["preg_43"]).checked = true; document.getElementById("s43_" + sessionStorage["preg_43"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    if (sessionStorage["preg_44"] != " ") { document.getElementById("s44_" + sessionStorage["preg_44"]).checked = true; document.getElementById("s44_" + sessionStorage["preg_44"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    if (sessionStorage["preg_51"] != " ") { document.getElementById("s51_" + sessionStorage["preg_51"]).checked = true; document.getElementById("s51_" + sessionStorage["preg_51"] + "_ch").style.backgroundColor = "aliceblue"; }; 
    document.getElementById("s61").innerHTML = sessionStorage["preg_61"]; 
    document.getElementById("s62").innerHTML = sessionStorage["preg_62"];
    document.getElementById("s63").innerHTML = sessionStorage["preg_63"];
}
