$(document).ready(function () {
    $('#txtDtAcordo').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtDtAcordo').inputmask('99/99/9999');

    $('#txtDataNascimento').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtDataNascimento').inputmask('99/99/9999');

    $('#txtDataUltimaAcao').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtDataUltimaAcao').inputmask('99/99/9999');

}); 