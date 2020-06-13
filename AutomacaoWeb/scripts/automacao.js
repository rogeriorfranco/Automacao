$(document).ready(function () {
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(InIEvent);
    function InIEvent(sender, e) {
        atribuiRadio();
    }
});

$(document).ready(function () {
        atribuiRadio();
});

function atribuiRadio() {
    $('input[type="radio"]').iCheck({
        radioClass: 'iradio_flat-blue'
    });
    $('input').on('ifChecked', function (event) { $(this).trigger("click"); });
}
