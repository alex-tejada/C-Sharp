$(document).ready(function () {
    //This section shows the user and emplyee number in the right side of the page.
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    //document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];

    if (sessionStorage["evaluations_left"] == undefined) {
        get_evaluations();
    }

    fill_with_evaluations();
    fill_variables_for_display();

    display_no_pages();

    if (sessionStorage["second_button"] == 1) {
        document.getElementById("next").style.display = "block";
        document.getElementById("previous").style.display = "block";
    } else if (sessionStorage["third_button"] == 1) {
        document.getElementById("next").style.display = "none";
        document.getElementById("previous").style.display = "block";
    } else {
        document.getElementById("next").style.display = "block";
        document.getElementById("previous").style.display = "none";
    }


});

function display_no_pages() {
    document.getElementById("no_pages").innerHTML = (parseInt(sessionStorage["actual_page"], 10) + 1).toString() + " de " + sessionStorage["total_pages"];
}

function get_evaluations() {
    //debugger;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_evaluations",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            if (result != null) {
                sessionStorage["total_evaluations"] = result.length;
                //sessionStorage["actual_page"] = 0;
                if (sessionStorage["evaluations_left"] == undefined) {
                    sessionStorage["evaluations_left"] = result.length;
                }
                
                for (var i = 0; i < result.length; i++) {
                    sessionStorage["id_encuestas_" + i] = result[i][0];
                    sessionStorage["fecha_" + i] = result[i][1];
                    sessionStorage["curso_" + i] = result[i][2];
                    sessionStorage["instructor_" + i] = result[i][3];
                }
            }
        }
    });
}

function fill_variables_for_display() {
    evaluations_to_display = sessionStorage["evaluations_left"] - 9;

    //if (evaluations_to_display == 0) {

    //} else
    if (evaluations_to_display <= 9 && evaluations_to_display > 0) {
        sessionStorage["evaluations_to_display"] = evaluations_to_display;
    } else if (evaluations_to_display > 9) {
        sessionStorage["evaluations_to_display"] = 9;
    } else {
        sessionStorage["evaluations_to_display"] = 9 + evaluations_to_display;
    }
}

function fill_with_evaluations() {
    sessionStorage["total_pages"] = Math.ceil(parseFloat(sessionStorage["total_evaluations"]) / 9);
    evaluations_to_display = parseInt(sessionStorage["evaluations_to_display"], 10);

    for (var i = 0; i < 9; i++) {
        if (sessionStorage["actual_page"] == undefined) {
            sessionStorage["actual_page"] = 0;
        }
        if (sessionStorage["actual_page"] == 0) {
            sessionStorage["first_button"] = 1;
            sessionStorage["second_button"] = 0;
            sessionStorage["third_button"] = 0;
        } else if (parseInt(sessionStorage["actual_page"], 10) == (parseInt(sessionStorage["total_pages"], 10) - 1)) {
            sessionStorage["first_button"] = 0;
            sessionStorage["second_button"] = 0;
            sessionStorage["third_button"] = 1;
        } else {
            sessionStorage["first_button"] = 0;
            sessionStorage["second_button"] = 1;
            sessionStorage["third_button"] = 0;
        }

        if (i >= evaluations_to_display || sessionStorage["curso_" + (i + (9 * sessionStorage["actual_page"]))] == undefined) {
            document.getElementById("file" + i).style.display = "none";
        } else {
            document.getElementById("classTitle_" + i).innerHTML = sessionStorage["curso_" + (i + (9 * sessionStorage["actual_page"]))];
            document.getElementById("instructor_" + i).innerHTML = "Instructor: " + sessionStorage["instructor_" + (i + (9 * sessionStorage["actual_page"]))];
            document.getElementById("date_" + i).innerHTML = "Fecha: " + sessionStorage["fecha_" + (i + (9 * sessionStorage["actual_page"]))];
        }
    }
}

function upDateValues(kind, no_button) {
    evaluations_left = sessionStorage["evaluations_left"] - sessionStorage["evaluations_to_display"];

    if (evaluations_left >= 0 && kind == 1) {
        //if (parseInt(sessionStorage["actual_page"], 10) == (parseInt(sessionStorage["total_pages"], 10) - 1))
        sessionStorage["evaluations_left"] = evaluations_left;
        sessionStorage["actual_page"] = parseInt(sessionStorage["actual_page"], 10) + 1;
        if (parseInt(sessionStorage["actual_page"], 10) == (parseInt(sessionStorage["total_pages"], 10) - 1)) {
            sessionStorage["evaluations_left"] = 0;
        } else if (parseInt(sessionStorage["actual_page"], 10) == 0) {
            sessionStorage["evaluations_left"] = parseInt(sessionStorage["total_evaluations"]) - 9;
        }
    } else{
        //sessionStorage["evaluations_left"] = parseInt(sessionStorage["evaluations_left"], 10) + parseInt(sessionStorage["evaluations_to_display"], 10);
        sessionStorage["evaluations_left"] = parseInt(sessionStorage["evaluations_left"], 10) + 9; 
        sessionStorage["evaluations_to_display"] = 9;
        sessionStorage["actual_page"] = sessionStorage["actual_page"] - 1;
    }
}

function setSelected(no_page) {
    sessionStorage["id_selectedEvaluation"] = sessionStorage["id_encuestas_" + (no_page + (9 * sessionStorage["actual_page"]))];
    //window.location.replace("desplegarEvaluacion.aspx");
    location.href = 'desplegarEvaluacion.aspx';
}
