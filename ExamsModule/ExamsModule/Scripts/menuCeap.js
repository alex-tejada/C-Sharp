$(document).ready(function () {
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    //document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
    //document.getElementById("basociado").value = sessionStorage["nombre"];

    console.log(sessionStorage["usuario"]);
    document.getElementById("visEv").style.display = "none";

    if (sessionStorage["tipo"] == "S") {
        document.getElementById("myEx").style.display = "none";
        document.getElementById("myG").style.display = "none";
    }

    if (sessionStorage["tipo"] == "H") {
        document.getElementById("visEv").style.display = "block";
    }

    TodayDate('Fecha_inicio');
    TodayDate('Fecha_fin');
});

function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}