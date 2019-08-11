$(document).ready(function () {
    //restriccion de sesion iniciada;
    //var acc = sessionStorage['usuario'];
    if (sessionStorage["NoReloj"] == null) { window.location.href = 'ceapLogin.aspx'; }
});

function cerrar_sesion() {
    sessionStorage.clear();
    window.location.replace("ceapLogin.aspx");
}



function has_access(access, url) {
    if (sessionStorage['nivel'] >= access) { window.location.href = url; }
    else {
        $.alert({
            title: "Sin acceso",
            type: "red",
            content: "No cuenta con acceso para esta ventana",
            columnClass: 'col-md-6 col-md-offset-3'
        });
    }
}


function Alerts(titulo, mensaje, tipo) {

    $.alert({
        title: titulo,
        content: mensaje,
        type: tipo,
        columnClass: 'col-md-6 col-md-offset-3'
    });
}

