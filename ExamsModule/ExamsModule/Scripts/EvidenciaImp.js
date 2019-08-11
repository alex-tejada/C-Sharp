$(document).ready(function () {
    if (sessionStorage["FolioImp"] == null || sessionStorage["FolioImp"] == '')
    { window.history.back(); }
    GetUnits();
    GetData();

    if (sessionStorage["EstadoImp"] == 'Implemented')
    { ImplementedOption(); }

    else
    {
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
    }
});

function ImplementedOption()
{
    document.getElementById('desc').disabled = true;
    document.getElementById('unidades').disabled = true;
    document.getElementById('beneficios').disabled = true;
    document.getElementById('antesfile').disabled = true;
    document.getElementById('despuesfile').disabled = true;

    document.getElementById('AntesDiv').style.display = 'none';
    document.getElementById('DespuesDiv').style.display = 'none';
    document.getElementById('btn_capturar').style.display = 'none';

    document.getElementById('AntesButton').style.display = 'block';
    document.getElementById('DespuesButton').style.display = 'block';

}

function Cancel()
{
    debugger;
    sessionStorage.removeItem("FolioImp");
    window.location.href = sessionStorage["Page"];
}

function isNumber(evt) {
    var codigo = (evt.which) ? evt.which : event.keyCode;
    if ((codigo > 47 && codigo < 58) || (codigo == 46 || codigo == 8)) { return true; }

    return false;
}

function GetData()
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetImpEvidenceSug",
        data:"{'ID':'"+sessionStorage["FolioImp"]+"'}",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            if (result != null) {
                document.getElementById('folio').value = result[0];
                document.getElementById('originador').innerHTML = result[2];
                document.getElementById('implementador').innerHTML = result[12];
                document.getElementById('planta').innerHTML = result[5];
                document.getElementById('area').innerHTML = result[6];
                document.getElementById('estacion').innerHTML = result[8];
                document.getElementById('seccion').innerHTML = result[7];
                document.getElementById('problema').innerHTML = result[9];
                document.getElementById('propuesta').innerHTML = result[10];
                document.getElementById('mejoras').innerHTML = result[11];

                if (result[13] == null) { document.getElementById('desc').innerHTML = ""; }
                else { document.getElementById('desc').innerHTML = result[13]; }

                if (result[14] == null) { document.getElementById('beneficios').value = ""; }
                else { document.getElementById('beneficios').value = result[14]; }

                if (result[15] == null) { document.getElementById('unidades').value = ""; }
                else { document.getElementById('unidades').value = result[15]; }
            }
        }
    });
}

function GetUnits()
{
    $.ajax({
        type: "POST",
        url: "WebService.asmx/GetUnits",
        contentType: "application/json",
        async: false,
        datatype: "json",
        success: function (responseFromServer) {
            var result = responseFromServer.d;
            if (result != null) {
                for(var i = 0; i<result.length; i++)
                { $('#unidades').append('<option value="'+result[i]+'">'+result[i]+'</option>'); }
            }
        }
    });
}
