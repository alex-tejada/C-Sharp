$(document).ready(function () {
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
});