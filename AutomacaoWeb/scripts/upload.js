$(document).ready(function () {
    $('#ddlTipoRelatorio').change(function () {
        if ($('#ddlTipoRelatorio').val() == "0") {
            $('#btnFileUp').attr('disabled', 'disabled');
        }
        else {
            $('#btnFileUp').removeAttr('disabled');
        }
    });
});