$(document).ready(function () {
    //This section shows the user and emplyee number in the right side of the page.
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado_display").innerHTML = sessionStorage["NoReloj"];

    //display_exams();

    //This section shows the date, class title and instructor as '--', if they have not been captured or with the real values, once they are captured.
    if (sessionStorage["fecha_ansEv"] == null || sessionStorage["fecha_ansEv"] == "") { document.getElementById("fecha_display").innerHTML = "--"; } else { document.getElementById("fecha_display").innerHTML = sessionStorage["fecha_ansEv"]; }
    if (sessionStorage["curso_ansEv"] == null || sessionStorage["curso_ansEv"] == "") { document.getElementById("curso_display").innerHTML = "--"; } else { document.getElementById("curso_display").innerHTML = sessionStorage["curso_ansEv"]; }
    if (sessionStorage["instructor_ansEv"] == null || sessionStorage["instructor_ansEv"] == "") { document.getElementById("instructor_display").innerHTML = "--"; } else { document.getElementById("instructor_display").innerHTML = sessionStorage["instructor_ansEv"]; }

    //This section helps to show section by section as soon as there is a click 
    disp_section0();
    disp_section1();
    disp_section2();
    disp_section3();
    disp_section4();
    disp_section5();
    disp_section6();
    disp_section7();
});

function display_exams() {
    var exams;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_exam_titles_for_combobox",
        data: "{'user':'" + sessionStorage["usuario"] + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            exams = result;
        }
    });

    var list_e = document.getElementById("ddl_exams");

    for (var i = 0; i < exams.length; i++) {
        list_e.options[i] = new Option(exams[i], exams[i]);
    }
}

function disp_section0() {
    //If the variable has a null or block value, the container will be visible, otherwise, it will remain hidden. 
    //The null in the condition is because this container is the first one to appear once you get in this section
    if (sessionStorage["section0"] == null || sessionStorage["section0"] == "block") {
        //The container is set as visible
        document.getElementById("section0").style.display = "block";

        //The date, class title and instructor are displayed according to the values stored. Yet this section is not the one at the right side of the window, is actually the form that is filled out by the user.
        if (sessionStorage["fecha_ansEv"] != null && sessionStorage["fecha_ansEv"] != "") { document.getElementById("fecha_ansEv").value = sessionStorage["fecha_ansEv"]; }
        if (sessionStorage["curso_ansEv"] != null && sessionStorage["curso_ansEv"] != "") { document.getElementById("curso_ansEv").value = sessionStorage["curso_ansEv"]; }
        if (sessionStorage["instructor_ansEv"] != null && sessionStorage["instructor_ansEv"] != "") { document.getElementById("instructor_ansEv").value = sessionStorage["instructor_ansEv"]; }

        //All input fieds are locked
        disable_all();

        //The input fields that belong to the current container are unlock
        document.getElementById("fecha_ansEv").disabled = false;
        document.getElementById("curso_ansEv").disabled = false;
        document.getElementById("instructor_ansEv").disabled = false;
    } else {
        //The container is set as not visible
        document.getElementById("section0").style.display = "none";
    }
}

function disp_section1() {
    if (sessionStorage["section1"] == "block") {
        //The container is set as visible
        document.getElementById("section1").style.display = "block";

        //All input fieds are locked
        disable_all();

        //The input fields that belong to the current container are unlock
        for (var i = 1; i < 6; i++) {
            document.getElementById("s11level" + i).disabled = false;
        }
        document.getElementById("open_answer_12").disabled = false;

        //If there are some answers that were previously stored, they will be displayed in the input fileds.
        if (sessionStorage["s11"] != null && sessionStorage["s11"] != "") { document.getElementById(sessionStorage["s11"]).checked = true; }
        if (sessionStorage["s12"] != null && sessionStorage["s12"] != "") { document.getElementById("open_answer_12").value = sessionStorage["s12"]; }

    } else {
        //The container is set as not visible
        document.getElementById("section1").style.display = "none";
    }
}

function disp_section2() {
    if (sessionStorage["section2"] == "block") {
        //The container is set as visible
        document.getElementById("section2").style.display = "block";

        //All input fieds are locked
        disable_all();

        //The input fields that belong to the current container are unlock
        for (var i = 1; i < 6; i++) {
            document.getElementById("s21level" + i).disabled = false;
            document.getElementById("s22level" + i).disabled = false;
        }

        //If there are some answers that were previously stored, they will be displayed in the input fileds.
        if (sessionStorage["s21"] != null && sessionStorage["s21"] != "") { document.getElementById(sessionStorage["s21"]).checked = true; }
        if (sessionStorage["s22"] != null && sessionStorage["s22"] != "") { document.getElementById(sessionStorage["s22"]).checked = true; }
    } else {
        //The container is set as not visible
        document.getElementById("section2").style.display = "none";
    }
}

function disp_section3() {
    if (sessionStorage["section3"] == "block") {
        //The container is set as visible
        document.getElementById("section3").style.display = "block";

        //All input fieds are locked
        disable_all();

        //The input fields that belong to the current container are unlock
        for (var i = 1; i < 6; i++) {
            document.getElementById("s31level" + i).disabled = false;
            document.getElementById("s32level" + i).disabled = false;
        }

        //If there are some answers that were previously stored, they will be displayed in the input fileds.
        if (sessionStorage["s31"] != null && sessionStorage["s31"] != "") { document.getElementById(sessionStorage["s31"]).checked = true; }
        if (sessionStorage["s32"] != null && sessionStorage["s32"] != "") { document.getElementById(sessionStorage["s32"]).checked = true; }
    } else {
        //The container is set as not visible
        document.getElementById("section3").style.display = "none";
    }
}

function disp_section4() {
    if (sessionStorage["section4"] == "block") {
        //The container is set as visible
        document.getElementById("section4").style.display = "block";

        //All input fields are locked
        disable_all();

        //The input fields that belong to the current container are unlock
        for (var i = 1; i < 6; i++) {
            document.getElementById("s41level" + i).disabled = false;
            document.getElementById("s42level" + i).disabled = false;
            document.getElementById("s43level" + i).disabled = false;
            document.getElementById("s44level" + i).disabled = false;
        }

        //If there are some answers that were previously stored, they will be displayed in the input fileds.
        if (sessionStorage["s41"] != null && sessionStorage["s41"] != "") { document.getElementById(sessionStorage["s41"]).checked = true; }
        if (sessionStorage["s42"] != null && sessionStorage["s42"] != "") { document.getElementById(sessionStorage["s42"]).checked = true; }
        if (sessionStorage["s43"] != null && sessionStorage["s43"] != "") { document.getElementById(sessionStorage["s43"]).checked = true; }
        if (sessionStorage["s44"] != null && sessionStorage["s44"] != "") { document.getElementById(sessionStorage["s44"]).checked = true; }
    } else {
        //The container is set as not visible
        document.getElementById("section4").style.display = "none";
    }
}

function disp_section5() {
    if (sessionStorage["section5"] == "block") {
        //The container is set as visible
        document.getElementById("section5").style.display = "block";

        //All input fields are locked
        disable_all();

        //The input fields that belong to the current container are unlock
        for (var i = 1; i < 6; i++) {
            document.getElementById("s51level" + i).disabled = false;
        }

        //If there are some answers that were previously stored, they will be displayed in the input fileds.
        if (sessionStorage["s51"] != null && sessionStorage["s51"] != "") { document.getElementById(sessionStorage["s51"]).checked = true; }
    } else {
        //The container is set as not visible
        document.getElementById("section5").style.display = "none";
    }
}

function disp_section6() {
    if (sessionStorage["section6"] == "block") {
        //The container is set as visible
        document.getElementById("section6").style.display = "block";

        //All input fields are locked
        disable_all();

        //The input fields that belong to the current container are unlock
        document.getElementById("open_answer_61").disabled = false;
        document.getElementById("open_answer_62").disabled = false;
        document.getElementById("open_answer_63").disabled = false;

        //If there are some answers that were previously stored, they will be displayed in the input fileds
        if (sessionStorage["s62"] != null && sessionStorage["s61"] != "") { document.getElementById("open_answer_61").value = sessionStorage["s61"]; }
        if (sessionStorage["s62"] != null && sessionStorage["s62"] != "") { document.getElementById("open_answer_62").value = sessionStorage["s62"]; }
        if (sessionStorage["s63"] != null && sessionStorage["s63"] != "") { document.getElementById("open_answer_63").value = sessionStorage["s63"]; }
    } else {
        //The container is set as not visible
        document.getElementById("section6").style.display = "none";
    }
}

function disp_section7() {
    if (sessionStorage["section7"] == "block") {
        //The container is set as visible
        document.getElementById("section7").style.display = "block";
    } else {
        //The container is set as not visible
        document.getElementById("section7").style.display = "none";
    }
}

function disable_all() {
    //This function disables all inputfileds 
    document.getElementById("fecha_ansEv").disabled = true;
    document.getElementById("curso_ansEv").disabled = true;
    document.getElementById("instructor_ansEv").disabled = true;

    for (var i = 1; i < 6; i++) {
        document.getElementById("s11level" + i).disabled = true;
        document.getElementById("s21level" + i).disabled = true;
        document.getElementById("s22level" + i).disabled = true;
        document.getElementById("s31level" + i).disabled = true;
        document.getElementById("s32level" + i).disabled = true;
        document.getElementById("s41level" + i).disabled = true;
        document.getElementById("s42level" + i).disabled = true;
        document.getElementById("s43level" + i).disabled = true;
        document.getElementById("s44level" + i).disabled = true;
        document.getElementById("s51level" + i).disabled = true;
    }

    document.getElementById("open_answer_12").disabled = true;
    document.getElementById("open_answer_61").disabled = true;
    document.getElementById("open_answer_62").disabled = true;
    document.getElementById("open_answer_63").disabled = true;
}

function capture_missing_information() {
    //With this function, the values for date, class title and instructor are stored
    sessionStorage["fecha_ansEv"] = document.getElementById("fecha_ansEv").value.toString();
    sessionStorage["curso_ansEv"] = document.getElementById("curso_ansEv").value.toString();
    sessionStorage["instructor_ansEv"] = document.getElementById("instructor_ansEv").value.toString();
}

function change_button(section) {
    //This function changes the visible container.
    no_sections = 8;

    for (var index = 0; index < no_sections; index++) {
        if (index == section) {
            sessionStorage["section" + index] = "block";
        }
        else {
            sessionStorage["section" + index] = "none";
        }
    }
}

function capture_answer_checked(section_esp) {
    //This function captures the option checked when there is a set of checkboxes
    var check_boxes = document.getElementsByName(section_esp);

    for (var i = 0; i < check_boxes.length; i++) {
        if (check_boxes[i].checked) {
            sessionStorage[section_esp] = section_esp + "level" + (i + 1);
            sessionStorage[section_esp + "_resp"] = (i + 1);
        }
    }
}

function section_0(option) {
    //This function has only one option since this is called in the first container (there is not any other previous container)
    if (option == "1") {
        capture_missing_information();
        change_button("1");
    }
}

function section_1(option) {
    //The option 1 is to move forward in the containers and store the given data. Anything different than 1 is to move backwards in the containers.
    if (option == "1") {
        capture_answer_checked("s11");
        sessionStorage["s12"] = document.getElementById("open_answer_12").value.toString();
        change_button("2");
    } else {
        change_button("0");
    }
}

function section_2(option) {
    //The option 1 is to move forward in the containers and store the given data. Anything different than 1 is to move backwards in the containers.
    if (option == "1") {
        capture_answer_checked("s21");
        capture_answer_checked("s22");
        change_button("3");
    } else {
        change_button("1");
    }
}

function section_3(option) {
    //The option 1 is to move forward in the containers and store the given data. Anything different than 1 is to move backwards in the containers.
    if (option == "1") {
        capture_answer_checked("s31");
        capture_answer_checked("s32");
        change_button("4");
    } else {
        change_button("2");
    }
}

function section_4(option) {
    //The option 1 is to move forward in the containers and store the given data. Anything different than 1 is to move backwards in the containers.
    if (option == "1") {
        capture_answer_checked("s41");
        capture_answer_checked("s42");
        capture_answer_checked("s43");
        capture_answer_checked("s44");
        change_button("5");
    } else {
        change_button("3");
    }
}

function section_5(option) {
    //The option 1 is to move forward in the containers and store the given data. Anything different than 1 is to move backwards in the containers.
    if (option == "1") {
        capture_answer_checked("s51");
        change_button("6");
    } else {
        change_button("4");
    }
}

function section_6(option) {
    //The option 1 is to move forward in the containers and store the given data. Anything different than 1 is to move backwards in the containers.
    if (option == "1") {
        sessionStorage["s61"] = document.getElementById("open_answer_61").value.toString();
        sessionStorage["s62"] = document.getElementById("open_answer_62").value.toString();
        sessionStorage["s63"] = document.getElementById("open_answer_63").value.toString();
        add_survey_information();
        change_button("7");
    } else {
        change_button("5");
    }
}

function reset_information() {
    sessionStorage["section0"] = "block";
    sessionStorage["section1"] = "none";
    sessionStorage["section2"] = "none";
    sessionStorage["section3"] = "none";
    sessionStorage["section4"] = "none";
    sessionStorage["section5"] = "none";
    sessionStorage["section6"] = "none";
    sessionStorage["section7"] = "none";
}

function going_back() {
    document.getElementById(sessionStorage["s11"]).checked = false;
    document.getElementById(sessionStorage["s21"]).checked = false;
    document.getElementById(sessionStorage["s22"]).checked = false;
    document.getElementById(sessionStorage["s31"]).checked = false;
    document.getElementById(sessionStorage["s32"]).checked = false;
    document.getElementById(sessionStorage["s41"]).checked = false;
    document.getElementById(sessionStorage["s42"]).checked = false;
    document.getElementById(sessionStorage["s43"]).checked = false;
    document.getElementById(sessionStorage["s44"]).checked = false;
    document.getElementById(sessionStorage["s51"]).checked = false;
    sessionStorage.removeItem("fecha_ansEv");
    sessionStorage.removeItem("curso_ansEv");
    sessionStorage.removeItem("instructor_ansEv");
    sessionStorage.removeItem("s11_resp");
    sessionStorage.removeItem("s11");
    sessionStorage.removeItem("s12");
    sessionStorage.removeItem("s21_resp");
    sessionStorage.removeItem("s21");
    sessionStorage.removeItem("s22_resp");
    sessionStorage.removeItem("s22");
    sessionStorage.removeItem("s31_resp");
    sessionStorage.removeItem("s31");
    sessionStorage.removeItem("s32_resp");
    sessionStorage.removeItem("s32");
    sessionStorage.removeItem("s41_resp");
    sessionStorage.removeItem("s41");
    sessionStorage.removeItem("s42_resp");
    sessionStorage.removeItem("s42");
    sessionStorage.removeItem("s43_resp");
    sessionStorage.removeItem("s43");
    sessionStorage.removeItem("s44_resp");
    sessionStorage.removeItem("s44");
    sessionStorage.removeItem("s51_resp");
    sessionStorage.removeItem("s51");
    sessionStorage.removeItem("s61");
    sessionStorage.removeItem("s62");
    sessionStorage.removeItem("s63");
    reset_information();
    window.location.replace("menuCeap.aspx");
}

function add_survey_information() {

    //This function stores the information in the database. All the answers captured in the forms are stored here in other variables and then sent to the web service
    $.ajax({
        type: "POST",
        url: "WebService.asmx/add_survey",
        data: JSON.stringify({
            noReloj: sessionStorage["NoReloj"], fecha: sessionStorage["fecha_ansEv"], curso: sessionStorage["curso_ansEv"], instructor: sessionStorage["instructor_ansEv"], preg_11: sessionStorage["s11_resp"],
            preg_12: sessionStorage["s12"], preg_21: sessionStorage["s21_resp"], preg_22: sessionStorage["s22_resp"], preg_31: sessionStorage["s31_resp"], preg_32: sessionStorage["s32_resp"],
            preg_41: sessionStorage["s41_resp"], preg_42: sessionStorage["s42_resp"], preg_43: sessionStorage["s43_resp"], preg_44: sessionStorage["s44_resp"], preg_51: sessionStorage["s51_resp"],
            preg_61: sessionStorage["s61"], preg_62: sessionStorage["s62"], preg_63: sessionStorage["s63"]
        }),
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            //if (responseFromServer.d) { console.log("result", responseFromServer.d); alert("¡Sugerencia capturada!"); }
        }
    });
}