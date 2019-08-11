var update_type = 0;
var User = '';
var NoReloj = '';

$(document).ready(function () {
    if (sessionStorage["nivel"] != "D")
    { window.location.href = "menu.aspx"; }
    document.getElementById("user").innerHTML = sessionStorage["nombre"];
    document.getElementById("no_empleado").innerHTML = sessionStorage["NoEmp"];
});

//GENERIC
function TodayDate(id) {
    var today = new Date();
    document.getElementById(id).value = today.getFullYear() + '-' + ('0' + (today.getMonth() + 1)).slice(-2) + '-' + ('0' + today.getDate()).slice(-2);
}

//GENERIC
function show(id, option) {
    switch (option) {
        case 1: // Filtros dept
            //metodo para reiniciar los datos desde que se abre 
            User = '';
            NoReloj = '';
            getDept('#area');
            break;
        case 2: //Area
            getDept("#adepto");
            break;
        case 3: //Cambio Estado
            getStatus();
            break;
        case 4: //admin area
            getDept("#aadepto");
            break;
        case 5: //relacion pago sugerencias
            TodayDate('inicio');
            TodayDate('fin');
            $('#tbl_benefits').empty();
            document.getElementById('psasociado').value = '';
            break;

    }
    $(id).modal('show');
}

//GENERIC
function getUser(user, name, email)
{
    var usuario = document.getElementById(user).value;
    if (usuario.length >= 6) {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/get_user",
            contentType: "application/json",
            data: "{'us':'" + usuario + "'}",
            async: false,
            datatype: "json",
            success: function (responseFromServer) {    
                var result = responseFromServer.d;
                document.getElementById(name).value = result[0];
                document.getElementById(email).value = result[1];
            }
        });
    }
    else
    {
        document.getElementById(name).value = "";
        document.getElementById(email).value = "";
    }
}

//GENERIC
function getDept(id) {
    $(id).empty();
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_department",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            for (var i = 0; i < result.length; i++) { $(id).append("<option id = '" + result[i] + "'>" + result[i] + "</option>"); }

            if (id == "#aadepto") { getAreaAdmin(); }
            else if (id == "#adepto") { getArea('#aarea', 'adepto') }
            else { getArea('#division', 'area') }
        }
    });
}

//GENERIC 
function getArea(id, id2) {
    var valor = document.getElementById(id2).value;
    $(id).empty();
    $.ajax({
        type: "POST",
        url: "WebService.asmx/LoadDivisionesAdmin",
        data: "{'dept': '" + valor + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                var result = responseFromServer.d;
                if (result != null) {
                    for (var i = 0; i < result.length; i++) { $(id).append("<option id = '" + result[i] + "'>" + result[i] + "</option>"); }
                    if (id == '#division') { getDivisionUsers(); }
                }
            }
            catch (ex) { }
        }
    });

}

//AREA ADMIN
function getAreaAdmin()
{
    var valor = document.getElementById('aadepto').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_area_admin",
        data:"{'area':'"+valor+"'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer)
        {
            var result = responseFromServer.d;
            document.getElementById("aaemp").value = result[0];
            document.getElementById("aausuario").value = result[1];
            document.getElementById("aanombre").value = result[2];
            document.getElementById("aaemail").value = result[3];
        }
    });
}

//AREA ADMIN
function setAdmin()
{
    var area = document.getElementById("aadepto").value;
    var NoReloj = document.getElementById("aaemp").value;
    var usuario = document.getElementById("aausuario").value;
    var nombre = document.getElementById("aanombre").value;

    $.ajax({
        type: "POST",
        url: "WebService.asmx/set_area_admin",
        data:"{'area':'"+area+"','BadgeNo':'"+NoReloj+"','user':'"+usuario+"','name':'"+nombre+"'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer)
        {
            if (responseFromServer.d)
            {
                $.alert({
                    title: 'Administrador de area',
                    content: 'Se ha actualizado el administrador de area',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }
            else
            {
                $.alert({
                    title: 'Administrador de area',
                    type:'red',
                    content: 'Error al actualizar al administrador de area, porfavor verifique sus datos e intente de nuevo',
                    columnClass: 'col-md-6 col-md-offset-3'
                });
            }
        }
    });
}

//DEPT FILTERS
function getDivisionUsers()
{

    //METODO PARA CARGAR EL PERSONAL DE EL AREA Y DIVISION SELECCIONADOS
    var dep = document.getElementById('area').value;
    var area = document.getElementById('division').value;
    NoReloj = '';
    User = '';
    $.ajax({
        type: "POST",
        url: "WebService.asmx/LoadUsers",
        data: "{'dept': '" + dep + "', 'area':'"+area+"'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try
            {
                $('#personal').empty();
                result = responseFromServer.d;
                if (result != null)
                {
                    for (var i = 0; i < result.length; i++)
                    {
                        var temporal = result[i].split('-');
                        $('#personal').append('<div class="row div-filter"><input type="text" readonly="readonly" id="'+temporal[2]+'" class="form-control txta filtros-txt" onclick="SelectedFilter(\''+temporal[2]+'\' , \''+temporal[1]+'\')"  value="' + temporal[0] + '"  /></div>');
                    }
                }
            }
            catch (ex)
            {

            }
        }
    });
}

//DEPT FILTERS
function SelectedFilter(Id, Usuario)
{
    NoReloj = Id; 
    User = Usuario;
    $('#personal').find("*").css({'background-color':'white'}); // SET ALL FILTERS BACKGROUND WHITE
    $('#' + Id).css({'background-color':'#D9D9D9'}); // SET SELECTED FILTER BACKGROUND #D9D9D9

}

// DEPT FILTERS
function delete_filter()
{
    var dept = document.getElementById('area').value;
    var division = document.getElementById('division').value;
    var Response = false;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/delete_filter",
        data: "{'dept': '" + dept + "', 'division':'" + division + "', 'badgeNo': '"+NoReloj+"'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer)
        {
            try
            {
                Response = responseFromServer.d;
            }
            catch (ex)
            {

            }
        }
    });

    if (Response) {
        $.alert({
            title: 'Edición de Filtros Departamentales',
            content: 'Filtro Departamental eliminado',
            columnClass: 'col-md-6 col-md-offset-3'
        });

    }
    else {
        $.alert({
            title: 'Edición de Filtros Departamentales',
            type: "red",
            content: 'Error al eliminar el filtro departamental',
            columnClass: 'col-md-6 col-md-offset-3'
        });
    }
    getDept('#area');
}

//DEPT FILTERS
function editFilters(option)
{
    if (option == '1')//new filter // es un insert
    {
        update_type = 1;
        document.getElementById('labarea').value = document.getElementById('area').value;
        document.getElementById('labdivision').value = document.getElementById('division').value;
        document.getElementById('labuser').value = "";
        document.getElementById('labnum').value = "";
        document.getElementById('labnombre').value = "";
        document.getElementById('labemail').value = "";
    }
    else if (option == '2')//create filter from new area // es un update a la cuenta recien creada
    {
        update_type = 2;
        //dismiss modal o modales de area 
        $('#areaNew').modal('hide');
        $('#areas').modal('hide');
        document.getElementById('labarea').value = document.getElementById('DeptNew').innerHTML;
        document.getElementById('labdivision').value = document.getElementById('Newarea').value;
        document.getElementById('labuser').value = "";
        document.getElementById('labnum').value = "";
        document.getElementById('labnombre').value = "";
        document.getElementById('labemail').value = "";
        $('#newFiltro').modal('show');
    }
    else //edit filter // es un update
    {
        if (NoReloj != '' && User != '')
        {
            update_type = 3;
            document.getElementById('labarea').value = document.getElementById('area').value;
            document.getElementById('labdivision').value = document.getElementById('division').value;
            document.getElementById('labnum').value = NoReloj;
            document.getElementById('labuser').value = User;
            getUser('labuser', 'labnombre', 'labemail');
            if (option == null)
            { document.getElementById('labnombre').value = document.getElementById('personal').innerHTML; }
            $('#newFiltro').modal('show');
        }

    }
}

//DEPT FILTERS
function btn_setFilter()
{
    $.confirm({
        title: 'Edición de Filtros Departamentales',
        type: 'orange',
        content: '¿La información ingresada es la correcta?',
        columnClass: 'col-md-6 col-md-offset-3',
        buttons: {
            confirm: function () {
                setFilter();
            },
            cancel: function () {

            }
        }
    });
}

//DEPT FILTERS
function btn_deleteFilter()
{
    if (NoReloj != '' && User != '')
    {
        $.confirm({
            title: 'Edición de Filtros Departamentales',
            type: 'orange',
            content: '¿Desea Eliminar el Filtro departamental Seleccionado?',
            columnClass: 'col-md-6 col-md-offset-3',
            buttons: {
                confirm: function () {
                    delete_filter();
                },
                cancel: function () {

                }
            }
        });
    }
}

// DEPT FILTERS
function setFilter() {

    var noreloj = document.getElementById('labnum').value;
    var nombre = document.getElementById('labnombre').value;
    var usuario = document.getElementById('labuser').value;
    var departamento = document.getElementById('labarea').value;
    var division = document.getElementById('labdivision').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/set_filters",
        data: "{'option':" + update_type + " ,'badgeno':'" + noreloj + "', 'name':'" + nombre + "', 'user':'" + usuario + "', 'dept':'" + departamento + "', 'division':'" + division + "', 'OldBagdeNo':'" + NoReloj + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                if (responseFromServer.d) {
                    $.alert({
                        title: 'Edición de Filtros Departamentales',
                        content: 'Filtro Departamental actualizado con éxito!',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
                else {
                    $.alert({
                        title: 'Edición de Filtros Departamentales',
                        type: "red",
                        content: 'Ocurrió un error al editar el Filtro Departamental, porfavor revise su información',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
            }
            catch (ex) { console.log(ex.message); }
        }
    });
    $('#newFiltro').modal('hide');
    $('#filtros').modal('hide');
}

// AREAS - NEW AREA
function open_areaNew()
{
    $('#areas').modal('hide');
    document.getElementById('DeptNew').innerHTML = document.getElementById('adepto').value;
    document.getElementById('Newarea').value = "";
    $('#areaNew').modal('show');
}

//AREAS - NEW AREA
function close_areaNew()
{
    $('#areaNew').modal('hide');
    $('#areas').modal('show');

}

//CHANGE STATUS
function getStatus()
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/get_status",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                $("#ceedo").empty();
                var result = responseFromServer.d;
                if (result != null) { for (var i = 0; i < result.length; i++) { $("#ceedo").append("<option id = '" + result[i] + "'>" + result[i] + "</option>"); } }
            }
            catch (ex) { }
        }
    });
}

//CHANGE STATUS
function GetStatusId() {
    var valor = document.getElementById("folio").value;
    if (valor.length > 3)
    {
        $.ajax({
            type: "POST",
            url: "WebService.asmx/get_status_id",
            data: "{'id': '" + valor + "'}",
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer) {
                try {
                    if (responseFromServer.d != null)
                    {
                        var result = responseFromServer.d;
                        document.getElementById("ceedo").disabled = false;
                        document.getElementById("btnceedo").disabled = false;
                        document.getElementById("ceedo").value = result;
                    }
                    
                }
                catch (ex) { }
            }
        });
    }
    else
    {
        document.getElementById("btnceedo").disabled = true;
        document.getElementById("ceedo").disabled = true;
    }

}

//CHANGE STATUS
function set_status(id, estado)
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/set_status",
        data: "{'id':'" + id + "','new_status':'" + estado + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                var result = responseFromServer.d;
                switch (result) {
                    case "Y":
                        $.alert({
                            title: 'Cambio de estado a Sugerencia',
                            content: 'La sugerencia ha sido cambiada de Estado',
                            columnClass: 'col-md-6 col-md-offset-3'
                        });
                        break;
                    case "N":
                        $.alert({
                            title: 'Cambio de estado a Sugerencia',
                            type: 'orange',
                            content: 'La Sugerencia no puede ser cambiada a Estado ' + estado + ' debido a que no tiene a un Implementador Asignado, Por Favor Coloquela en Estado "In Revision"',
                            columnClass: 'col-md-6 col-md-offset-3'
                        });
                        break;
                    case "E":
                        $.alert({
                            title: 'Cambio de estado a Sugerencia',
                            type: 'red',
                            content: 'Error al cambiar el Estado a la sugerencia',
                            columnClass: 'col-md-6 col-md-offset-3'
                        });
                        break;
                }
            }
            catch (ex) { }
        }
    });
}

//CHANGE STATUS
function btn_change_click()
{    
    var id = document.getElementById('folio').value;
    var estado = document.getElementById('ceedo').value;
    $.confirm({
        title: 'Cambio de estado a sugerencia ',
        type: 'orange',
        content: '¿Está seguro que desea cambiar el Estado de la sugerencia: ' +id + ' a ' + estado + '?',
        columnClass: 'col-md-6 col-md-offset-3',
        buttons: {
            confirm: function () {
                set_status(id, estado);
            },
            cancel: function () {
                
            }
        }
    });

}

//AREAS
function btn_deleteArea() // Btn para eliminar el area seleccionada de departamentos y areas en adminBPS
{
    var depto = document.getElementById('adepto').value;
    var area = document.getElementById('aarea').value;
    $.confirm({
        title: 'Eliminar Area',
        type: 'orange',
        content: '¿Está seguro que desea eliminar el area seleccionada?',
        columnClass: 'col-md-6 col-md-offset-3',
        buttons: {
            confirm: function () {
                delete_area(depto, area);
            },
            cancel: function () {
            }
        }
    });    
}
//AREAS
function delete_area(depto, area) {
    $.ajax({
        type: "POST",
        url: "WebService.asmx/delete_area",
        data: "{'dept':'" + depto + "' , 'area':'" + area + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                var result = responseFromServer.d;
                if (result) {
                    $.alert({
                        title: 'Area eliminada',
                        content: 'Se ha eliminado el area seleccionada',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
                else {
                    $.alert({
                        title: 'Area eliminada',
                        type: "red",
                        content: 'Error al intentar eliminar el area seleccionada',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
                getDept("#adepto");
            }
            catch (ex)
            {
                console.log(ex);
            }


        }
    });
}
//AREAS
function btn_add_area()
{
    var area = document.getElementById('Newarea').value;
    var dept = document.getElementById('DeptNew').innerHTML;
    $.confirm({
        title: 'Agregar Area',
        type: 'orange',
        content: '¿Los datos introducidos son Correctos?',
        columnClass: 'col-md-6 col-md-offset-3',
        buttons: {
            confirm: function () {
                add_area(dept, area);
            },
            cancel: function () {
                //  no se procede con metodo
            }
        }
    });
}
//AREAS
function add_area(dept, area)
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/insert_area",
        data: "{'dept': '" + dept + "' , 'area': '" + area + "'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            try {
                var result = responseFromServer.d;
                if (result) {
                    $.alert({
                        title: 'Area nueva Creada',
                        content: 'Se ha creado el area ' + area + ' al Departamento ' + dept + ', por favor asigne el filtro departamental para esa area',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                    editFilters('2');
                }
                else {
                    $.alert({
                        title: 'Creación de Area nueva',
                        type: "red",
                        content: 'Error al intentar crear el area ingresada',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
            }
            catch (ex)
            {
                console.log(ex);
            }
        }
    });
}

//BENEFITS P/ ASOCIATE
function benefitsAsociate()
{
    var inicio = document.getElementById("inicio").value.toString();
    var fin = document.getElementById("fin").value.toString();
    var NoReloj = document.getElementById('psasociado').value;
    $.ajax({
        type: "POST",
        url: "WebService.asmx/benefitsPerAsociate",
        data: JSON.stringify({ begin: inicio, end: fin, badgeNo: NoReloj }),
        contentType: "application/json",
        datatype: "json",
        success: function (responseFromServer) {
            try
            {
                $('#tbl_benefits').empty();
                var result = responseFromServer.d;
                if (result != null)
                {

                    //create responsive table
                    for (var i = 0; i < result.length; i++) {
                        var temporal = result[i].split('-');
                        $('#tbl_benefits').append('<tr><td>' + temporal[0] + '</td><td>' + temporal[1] + '</td><td>' + temporal[2] + '</td></tr>');
                    }

                    //ver la forma de crear una tabla para vizualizar todos los datos que arrojó el método
                }
            }
            catch (ex)
            {
                console.log(ex.message);
            }

        }
    });
}

//BENEFITS P/ ASOCIATE
function CloseReport() {
    $('#EmailModal').modal('hide');
    $('#ps').modal('show');
}

//BENEFITS P/ ASOCIATE
function sendReport()
{
    //condicional de correo bosch
    var Correo = document.getElementById('correo').value;
    var temp = Correo.split('@');
    if(temp[1].toLowerCase() =='us.bosch.com')
    {
        var fecha_desde = document.getElementById('inicio').value;
        var fecha_hasta = document.getElementById('fin').value;
        var num_reloj = document.getElementById('psasociado').value;

        $.ajax({
            type: "POST",
            url: "WebService.asmx/Open_Excel",
            data: "{'begin': '" + fecha_desde + "' , 'end': '" + fecha_hasta + "', 'badgeNo': '" + num_reloj + "', 'Email':'" + Correo + "'}",
            contentType: "application/json",
            async: false,
            datatype: "json",
            success: function (responseFromServer) {
                if (responseFromServer.d == 'Success') {
                    $.alert({
                        title: 'REPORTE',
                        content: 'Reporte Enviado',
                        columnClass: 'col-md-6 col-md-offset-3'
                    });
                }
                else {
                    console.log(responseFromServer.d);
                }
            }
        });
        $('#EmailModal').modal('hide');
    }
    else {
        $.alert({
            title: 'REPORTE',
            type: 'orange',
            content: 'El correo ingresado no es una cuenta de correo Bosch, por favor ingrese una Cuenta de Correo Bosch',
            columnClass: 'col-md-6 col-md-offset-3'
        });
    }



}

//BENEFITS P/ ASOCIATE
function get_excel()
{
    document.getElementById('correo').value = '';
    $('#ps').modal('hide');
    $('#EmailModal').modal('show');
}