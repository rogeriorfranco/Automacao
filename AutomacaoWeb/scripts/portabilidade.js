$(document).ready(function () {
    $('#rbCanaisCriticos').on('ifChecked', function (event) {
        if (event.target.value == "1") {
            $("#UserControlQuestao6_CanalManifestoID").show();
            ValidatorEnable($('#UserControlQuestao6_rfCanal')[0], true);
            ValidatorEnable($('#UserControlQuestao6_rfProtocoloManifesto')[0], true);
        } else {
            $("#UserControlQuestao6_CanalManifestoID").hide();
            $("#UserControlQuestao6_ddlCanal").val(0);
            $("#UserControlQuestao6_txtProtocoloManifesto").val('');
            ValidatorEnable($('#UserControlQuestao6_rfCanal')[0], false);
            ValidatorEnable($('#UserControlQuestao6_rfProtocoloManifesto')[0], false);
        }
    });
});

$(document).ready(function () {
    $('#rbAcordoPrevio').on('ifChecked', function (event) {
        if (event.target.value == "1") {
            $("#UserControlQuestao5_reclClienteID").show();
            $("#UserControlQuestao3_4_pPrincipal4").hide();
            $("#UserControlQuestao5_lblAcordoPrevio").text("Valor do Acordo:");
            $("#UserControlQuestao5_ddlReclamacaoCliente").val(0);
          //  ValidatorEnable($('#UserControlQuestao5_rfReclamacaoCliente')[0], true);

        } else {

            $("#UserControlQuestao5_reclClienteID").hide();
            $("#UserControlQuestao3_4_pPrincipal4").show();
            $("#UserControlQuestao5_lblAcordoPrevio").text("Valor do proposto:");
       //     ValidatorEnable($('#UserControlQuestao5_rfReclamacaoCliente')[0], false);
        }
    });
});

$(document).ready(function () {
    $('#UserControlExecQuestao1_chkCliente').click(function () {
        if ($(this).prop("checked") == true) {
            $("#UserControlExecQuestao1_txtTelefone").val('');
            $("#UserControlExecQuestao1_txtTelefone").prop("disabled", true);
            ValidatorEnable($('#UserControlExecQuestao1_rfTel')[0], false);
        }
        else {
            $("#UserControlExecQuestao1_txtTelefone").prop("disabled", false);
            ValidatorEnable($('#UserControlExecQuestao1_rfTel')[0], true);
        }
    });
});


$(document).ready(function () {
    if ($('#hfFormularioId').val() != "") {
        loadImages('tbl_printQuestao_1', $('#hfFormularioId').val(), 1, 0);
        loadImages('tbl_printQuestao_1__1', $('#hfFormularioId').val(), 1, 1);
        loadImages('tbl_printQuestao_1__2', $('#hfFormularioId').val(), 1, 2);
        loadImages('tbl_printQuestao_1__3', $('#hfFormularioId').val(), 1, 3);
        loadImages('tbl_printQuestao_1__4', $('#hfFormularioId').val(), 1, 4);
        loadImages('tbl_printQuestao_2', $('#hfFormularioId').val(), 2, 0);
        loadImages('tbl_printQuestao_3', $('#hfFormularioId').val(), 3, 0);
        loadImages('tbl_printQuestao_4', $('#hfFormularioId').val(), 4, 0);
        loadImages('tbl_printQuestao_5', $('#hfFormularioId').val(), 5, 0);
        loadImages('tbl_printQuestao_6', $('#hfFormularioId').val(), 6, 0);
        loadImages('tbl_printQuestao_7', $('#hfFormularioId').val(), 7, 0);
        loadImages('tbl_printQuestao_8', $('#hfFormularioId').val(), 8, 0);
        loadImages('tbl_printQuestao_9', $('#hfFormularioId').val(), 9, 0);
        loadImages('tbl_printQuestao_10', $('#hfFormularioId').val(), 10, 0);
        loadImages('tbl_printQuestao_11', $('#hfFormularioId').val(), 11, 0)
        loadImages('tbl_printQuestao_12', $('#hfFormularioId').val(), 12, 0);
        loadImages('tbl_printQuestao_13', $('#hfFormularioId').val(), 13, 0);
        loadImages('tbl_printQuestao_14', $('#hfFormularioId').val(), 14, 0);
        loadImages('tbl_printQuestao_15', $('#hfFormularioId').val(), 15, 0)
        loadImages('tbl_printQuestao_16', $('#hfFormularioId').val(), 16, 0);
        loadImages('tbl_printQuestao_17', $('#hfFormularioId').val(), 17, 0);
        loadImages('tbl_printQuestao_18', $('#hfFormularioId').val(), 18, 0);
        loadImages('tbl_printQuestao_19', $('#hfFormularioId').val(), 19, 0);
        loadImages('tbl_printQuestao_20', $('#hfFormularioId').val(), 20, 0);
        loadImages('tbl_printQuestao_21', $('#hfFormularioId').val(), 21, 0);
        loadImages('tbl_printQuestao_22', $('#hfFormularioId').val(), 22, 0);
        loadImages('tbl_printQuestao_23', $('#hfFormularioId').val(), 23, 0);
        loadImages('tbl_printQuestao_24', $('#hfFormularioId').val(), 24, 0);
        loadImages('tbl_printQuestao_25', $('#hfFormularioId').val(), 25, 0);
        loadImages('tbl_printQuestao_26', $('#hfFormularioId').val(), 26, 0);
        loadImages('tbl_printQuestao_27', $('#hfFormularioId').val(), 27, 0);
        loadImages('tbl_printQuestao_28', $('#hfFormularioId').val(), 28, 0);
        loadImages('tbl_printQuestao_29', $('#hfFormularioId').val(), 29, 0);
        loadImages('tbl_printQuestao_31', $('#hfFormularioId').val(), 31, 0);
    }
});

$(document).ready(function () {
    $('#rbCanaisCriticos').on('ifChecked', function (event) {
        if (event.target.value == "1") {
            $("#UserControlQuestao6_CanalManifestoID").show();
        } else {
            $("#UserControlQuestao6_CanalManifestoID").hide();
        }
    });
});

$(document).ready(function ($) {
    Sys.WebForms.PageRequestManager.getInstance().add_endRequest(InIEvent);
    function InIEvent(sender, e) {
        atribuiDLL();
        atribuiRadio();
        atribuiMascara();
        mascaraTelefone();      
    }
});

//mascaras
$(document).ready(function () {
    atribuiDLL();
    atribuiRadio();
    atribuiMascara();
    mascaraTelefone();
});

function preenchePendente_7() {
    atribuiDLL();
    $.getJSON("../listaPendente/" + $("#hfFormularioId").val() + "/" + 7,
        function (data) {
            if (data !== null) {
                if (data.length > 0) {
                    $.each(data, function (i, v) {
                        $('#UserControlQuestao7_lbPendente')[0].sumo.selectItem(v);
                    });
                }
            }       
    })
    .fail(
    function (jqXHR, textStatus, err) {
        alert(err);
    });
}


function atribuiDLL() {

    $("#UserControlQuestao7_lbPendente").SumoSelect({
        placeholder: '<< Selecionar >>',
        csvDispCount: 10,
        okCancelInMulti: false,
        selectAll: true,
        forceCustomRendering: true,
        locale: ['OK', 'Cancelar', 'Selecionar Todos'],
        up: false,
        showTitle: true,
        floatWidth: 300
    });
}

function atribuiRadio() {
    $('input[type="radio"]').iCheck({
        radioClass: 'iradio_flat-blue'
    });
    $('input').on('ifChecked', function (event) { $(this).trigger("click"); });
}

function atribuiMascara() {
    $('#UserControlQuestao5_txtDataHorario1').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#UserControlQuestao5_txtDataHorario1').inputmask('99/99/9999');

    $('#UserControlQuestao5_txtDataHorario2').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#UserControlQuestao5_txtDataHorario2').inputmask('99/99/9999');

    $('#UserControlQuestao5_txtDataHorario3').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#UserControlQuestao5_txtDataHorario3').inputmask('99/99/9999');

    $('#txtDtInsQuestao_3').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtDtInsQuestao_3').inputmask('99/99/9999');
    $('#txtDtInsQuestao_3').focusout(() => {
        if ($('#txtDtInsQuestao_3').val().includes('_')) {
            $('#txtDtInsQuestao_3').val("");
        }
    });

    $('#txtDtQuestao_10').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtDtQuestao_10').inputmask('99/99/9999');

    $('#txtdtQuestao_28').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtdtQuestao_28').inputmask('99/99/9999');

    $("#txtMinQuestao_10").on('keyup keydown blur', function (event) {
        $(this).val($(this).val().replace(/[^0-9]/g, ''));
    });

    var mask = function (val) {
        val = val.split(":");
        return (parseInt(val[0]) > 19) ? "HZ:M0" : "H0:M0";
    }

    pattern = {
        onKeyPress: function (val, e, field, options) {
            field.mask(mask.apply({}, arguments), options);
        },
        translation: {
            'H': { pattern: /[0-2]/, optional: false },
            'Z': { pattern: /[0-3]/, optional: false },
            'M': { pattern: /[0-5]/, optional: false }
        }
    };

    $('#UserControlQuestao5_txtHora1').mask(mask, pattern);
    $('#UserControlQuestao5_txtHora2').mask(mask, pattern);
    $('#UserControlQuestao5_txtHora3').mask(mask, pattern);

    //Form Acordo
    $('#UserControlFormularioAcordo_txtDtAcordo').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#UserControlFormularioAcordo_txtDtAcordo').inputmask('99/99/9999');

    $('#UserControlFormularioAcordo_txtMesAno').datepicker({ format: 'mm/yyyy', language: 'pt-BR', viewMode: "months", minViewMode: "months" , autoclose: true });
    $('#UserControlFormularioAcordo_txtMesAno').inputmask('99/9999');

    $('#txtDataUltimaAcaoFA').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtDataUltimaAcaoFA').inputmask('99/99/9999');

    $('#txtDataNascimentoFA').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#txtDataNascimentoFA').inputmask('99/99/9999');

    //Qst_3_4
    $('#UserControlQuestao3_4_txtDataInstalacao').datepicker({ format: 'dd/mm/yyyy', language: 'pt-BR', autoclose: true });
    $('#UserControlQuestao3_4_txtDataInstalacao').inputmask('99/99/9999');

    //mascaraTelefone();


    $(function () {
        var maxLength = '-0.000.000,00'.length;

        $("#UserControlQuestao5_txtValorProposta1").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');

        $("#UserControlQuestao5_txtValorProposta2").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');

        $("#UserControlQuestao5_txtValorProposta3").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');

        $("#UserControlQuestao5_txtValorPropostaAcordo").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');

        //Form Acordo
        $("#txtValorSolicitadoFA").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');

        $("#txtValorAlcadaFA").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');


        $("#txtAcordoRealizadoMoralFA").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');

        $("#txtAcordoRealizadoMaterialFA").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');

        $("#txtAcordoRealizadoObricacaoFA").maskMoney({
            allowNegative: true,
            thousands: '.',
            decimal: ',',
            affixesStay: false,
            prefix: 'R$ '
        }).attr('maxlength', maxLength).trigger('mask.maskMoney');
    });
}


function mascaraTelefone() {
    //* TELEFONE *//
    function inputHandler2(masks, max, event) {
        var c = event.target;
        var v = c.value.replace(/\D/g, '');
        var m = c.value.length > max ? 1 : 0;
        VMasker(c).unMask();
        VMasker(c).maskPattern(masks[m]);
        c.value = VMasker.toPattern(v, masks[m]);
    }

    telMask = ['(99) 9999-99999', '(99) 99999-9999'];
    tel = document.querySelector('input[name="UserControlExecQuestao1$txtTelefone"]');
    VMasker(tel).maskPattern(telMask[0]);
    tel.addEventListener('input', inputHandler2.bind(undefined, telMask, 14), false);
}

$(document).ready(() => {
    $("#UserControlExecQuestao1_txtTelefone").focusout(() => {
       var expressao = '^\\([0-9]{2}\\) ((2[0-9]{3}-[0-9]{4})|(3[0-9]{3}-[0-9]{4})|(4[0-9]{3}-[0-9]{4})|(5[0-9]{3}-[0-9]{4})|(6[0-9]{3}-[0-9]{4})|(7[0-9]{3}-[0-9]{4})|(9[0-9]{3}-[0-9]{5})|(9[0-9]{4}-[0-9]{4}))$';
        var regex = new RegExp(expressao);

        msisdn = $("#UserControlExecQuestao1_txtTelefone").val();

        if (msisdn != "") {

            if (regex.test(msisdn) == false) {
                $("#UserControlExecQuestao1_txtTelefone").val("");
                $('#UserControlExecQuestao1_rfTel').text("MSISDN inválido!");
                $('#UserControlExecQuestao1_rfTel').css("visibility", "visible");
            }
        } else {
            $('#UserControlExecQuestao1_rfTel').css("visibility", "visible");
            $('#UserControlExecQuestao1_rfTel').text("Campo Obrigatório !");
        }
    });

    $("#UserControlExecQuestao1_txtTelefone").focusin(() => {
        $('#UserControlExecQuestao1_rfTel').css("visibility", "hidden");
    });
});
