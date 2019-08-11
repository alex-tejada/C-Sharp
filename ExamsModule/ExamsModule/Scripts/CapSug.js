$(document).ready(function () {
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
    document.getElementById("Originador").value = sessionStorage["NoEmp"];
    
    GetFocus();
    GetPlant();
    GetArea();
    GetDepartment();


    var inputs = document.querySelectorAll('.inputfile');

    Array.prototype.forEach.call(inputs, function (input) {
        var label = input.nextElementSibling,
		labelVal = label.innerHTML;

        input.addEventListener('change', function (e) {
            var fileName = '';
            if (this.files && this.files.length > 1)
                fileName = (this.getAttribute('data-multiple-caption') || '').replace('{count}', this.files.length);
            else
                fileName = e.target.value.split('\\').pop();

            if (fileName)
                label.innerHTML = fileName;
            else
                label.innerHTML = labelVal;
        });
    });
});

function act_costo() {
    if (document.getElementById("redcheck").checked == true) { document.getElementById("redcosto").disabled = false; }
    else { document.getElementById("redcosto").disabled = true; document.getElementById("redcosto").value = 0; }
}

function isNumber(evt) {
    var codigo = (evt.which) ? evt.which : event.keyCode;
    if ((codigo > 47 && codigo < 58) || (codigo == 46 || codigo == 8)) { return true; }

    return false;
}

function GetFocus() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_focus",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            for (var i = 0; i < result.length; i++)
            { $("#enfoque").append("<option id = '" + result[i] + "'>" + result[i] + "</option>"); }
        }
    });
}

function GetArea() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_area",
        contentType: "application/json",
        datatype: "json",
        async: false,
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            for (var i = 0; i < result.length; i++) {
                $("#area").append("<option id = '" + result[i] + "'>" + result[i] + "</option>");
            }
        }
    });
}

function GetPlant() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_plant",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            for (var i = 0; i < result.length; i++) {
                $("#planta").append("<option id = '" + result[i] + "'>" + result[i] + "</option>");
            }
        }
    });
}

function GetDepartment() {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_department",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            for (var i = 0; i < result.length; i++) {
                $("#departamento").append("<option id = '" + result[i] + "'>" + result[i] + "</option>");
            }
        }
    });
}

function GetSection() {
    var valor = document.getElementById("area").value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_section",
        data: "{'area': '" + valor + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                $("#seccion").empty();
                $("#estacion").empty();
                var result = responseFromServer.d;
                if (result != null) {
                    for (var i = 0; i < result.length; i++) { $("#seccion").append("<option id = '" + result[i] + "'>" + result[i] + "</option>"); }
                    GetStation();
                }
            }
            catch (ex) { }
        }
    });
}

function GetStation() {
    var valor = document.getElementById("seccion").value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_station",
        data: "{'section': '" + valor + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                $("#estacion").empty();
                var result = responseFromServer.d;
                for (var i = 0; i < result.length; i++) {
                    $("#estacion").append("<option id = '" + result[i] + "'>" + result[i] + "</option>");
                }
            }
            catch (ex) { }
        }
    });
}
