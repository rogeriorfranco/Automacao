var cntrlIsPressed = false; // Valida se o leftControl está pressionado
var ids = []; // Armazena o id das imagens selecionadas

$(document).ready(function ($) {
    var defaults;
    $.event.fix = (function (originalFix) {
        return function (event) {
            event = originalFix.apply(this, arguments);
            if (event.type.indexOf('copy') === 0 || event.type.indexOf('paste') === 0) {
                if (ids.length > 0) {
                    var nro_pergunta = removePrint(document.activeElement.name);
                    var sub_nro = retornSubNro(document.activeElement.name);
                    copyImage(ids, $("#hfFormularioId").val(), nro_pergunta, sub_nro, 'tbl_' + document.activeElement.name);
                } else {
                    event.clipboardData = event.originalEvent.clipboardData;
                }
            }
            return event;
        };
    })($.event.fix);
    defaults = {
        callback: $.noop,
        matchType: /image.*/
    };

    return $.fn.pasteImageReader = function (options) {
        if (ids.length == 0) {
            if (typeof options === "function") {
                options = {
                    callback: options
                };
            }
            options = $.extend({}, defaults, options);
            return this.each(function () {
                var $this, element;
                element = this;
                $this = $(this);
                return $this.bind('paste', function (event) {
                    if (ids.length == 0) {
                        var clipboardData, found;
                        found = false;
                        clipboardData = event.clipboardData;
                        return Array.prototype.forEach.call(clipboardData.types, function (type, i) {
                            var file, reader;
                            if (found) {
                                return;
                            }
                            if (type.match(options.matchType) || clipboardData.items[i].type.match(options.matchType)) {
                                file = clipboardData.items[i].getAsFile();

                                reader = new FileReader();
                                reader.onload = function (evt) {
                                    return options.callback.call(element, {
                                        dataURL: evt.target.result,
                                        event: evt,
                                        file: file,
                                        name: file.name
                                    });
                                };
                                reader.readAsDataURL(file);
                                return found = true;
                            }
                        });
                    }
                });
            });
        } else {
            return "";
        }
    };
});

function retornSubNro(sub_nro) {
    var sub = sub_nro.split('__');
    if (sub[1] == null) {
        return 0;
    }
    else {
        return sub[1];
    }
}

function convertDataURIToBinary(dataURI) {
    var BASE64_MARKER = ';base64,';
    var base64Index = dataURI.indexOf(BASE64_MARKER) + BASE64_MARKER.length;
    var base64 = dataURI.substring(base64Index);
    var raw = window.atob(base64);
    var rawLength = raw.length;
    var array = new Uint8Array(new ArrayBuffer(rawLength));

    for (i = 0; i < rawLength; i++) {
        array[i] = raw.charCodeAt(i);
    }
    return array;
}

function removeBase64(dataURI) {
    var BASE64_MARKER = ';base64,';
    return dataURI.substring(dataURI.indexOf(BASE64_MARKER) + BASE64_MARKER.length);
}

function removePrint(dataURI) {
    var printButton = dataURI.split('__');
    var printMarker = ';printQuestao_';

    if (printButton[1] == null) {
        return dataURI.substring(dataURI.indexOf(printMarker) + printMarker.length);
    }
    else {
        return printButton[0].substring(dataURI.indexOf(printMarker) + printButton[0].length);
    }
}

function removeTblName(dataURI) {
    var printButton = dataURI.split('__');
    var printMarker = ';tbl_printQuestao_';

    if (printButton[1] == null) {
        return dataURI.substring(dataURI.indexOf(printMarker) + printMarker.length);
    }
    else {
        return printButton[0].substring(dataURI.indexOf(printMarker) + printButton[0].length);
    }
}

function saveImage(table, img, formularioId, nro_pergunta, sub_nro) {
    $.ajax({
        type: "POST",
        url: "../saveImage",
        data: '{ img:"' + img + '", formularioId:"' + formularioId + '" , nro_pergunta:"' + nro_pergunta + '", sub_nro:"' + sub_nro + '"  }',
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (r) {
            loadImages(table, formularioId, nro_pergunta, sub_nro);
        },
        error: function () {
           // alert("An error has occurred during processing your request.");
        }
    });
}

function copyImage(ids, formularioId, nro_pergunta, sub_nro, table) {
    $.ajax({
        type: "POST",
        url: "../copyImage",
        data: {ids: ids, nQuestao: nro_pergunta, subQuestao: sub_nro},
        dataType: "json",
        success: function (r) {
            loadImages(table, formularioId, nro_pergunta, sub_nro);
        },
        error: function () {
            // alert("An error has occurred during processing your request.");
        }
    });
}

function deleteImage(table, imgId, formularioId, nro_pergunta, sub_nro) {
    $.ajax({
        type: "POST",
        url: "../delete/" + imgId,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            loadImages(table, formularioId, nro_pergunta, sub_nro);
        },
        error: function () {
            alert("An error has occurred during processing your request.");
        }
    });
}

function loadImage(imgId) {
    $.getJSON("../loadImage/" + imgId,
    function (data) {
        $("#imgModal").attr('src', 'data:image/png;base64,' + data + '');
    })
    .fail(
    function (jqXHR, textStatus, err) {
        alert(err);
    });
}


function loadImages(table, formularioId, nro_pergunta, sub_nro) {
    $(".printImage").val("");
    $.getJSON("../readImages/" + formularioId + "/" + nro_pergunta + "/" + sub_nro,
        function (data) {
            $("#" + table).empty();
            if (data.length > 0) {
                var appendToResult = "<tr>";
                $.each(data, function (index) {
                    appendToResult = appendToResult + "<td>";
                    appendToResult = appendToResult + "<div class='carousel-inner'>";
                    appendToResult = appendToResult + "<img id='" + table + "_ImgPic_" + index + "' class='img-thumbnail' name='" + this['id'] + "' src='data:image/png;base64," + this['imgRedimensionada'] + "'>";
                    appendToResult = appendToResult + "<a id='" + table + "_lblExcluir_" + index + "'class='img-excluir' name='" + this['id'] + "' href='#'')'>Excluir</a>";
                    appendToResult = appendToResult + "</div>";
                    appendToResult = appendToResult + "</td>";
                });
                appendToResult + "\n" + "</tr>";
                $("#" + table).append(appendToResult);
            }
        });
}

function fechar() {
    window.close();
}

$(document).keydown(function (event) {
    if (event.which == "17")
        cntrlIsPressed = true;
});

$(document).keyup(function (event) {
    if (event.which == "17")
        cntrlIsPressed = false;
});

$(document).ready(function () {
    $(document).on("click", ".img-thumbnail", function () {
        event.stopPropagation();
        if (cntrlIsPressed) {
            //var imageCode = this.src.slice(this.src.indexOf("base64,") + 7, this.src.length);
            var id = this.name;

            if (!ids.includes(id)) {
                ids.push(id);
                $(this).css("background-color", "#fc0303");
            } else {
                for (var x = 0; x < ids.length; x++) {
                    if (ids[x] == id) {
                        ids.splice(x, 1);
                        $(this).css("background-color", "#ffffff");
                        break;
                    }
                }
            }
        } else {
            $('#myModalImage').modal('show');
            loadImage(this.name);
        }
    });

    $(document).on("click", ".printImage", function () {
        event.stopPropagation();
    });

    $(document).ready(function () {
        $(".printImage").pasteImageReader(function (results) {
            var nro_pergunta = removePrint(document.activeElement.name);
            var sub_nro = retornSubNro(document.activeElement.name);
            saveImage('tbl_' + this.name, removeBase64(results.dataURL), $("#hfFormularioId").val(), nro_pergunta, sub_nro);
        });
    });

    $(document).ready(function () {
        $(document).on("click", ".img-excluir", function (event) {
            var table = this.parentElement.parentElement.parentElement.parentElement.id;
            var nro_pergunta = removeTblName(this.parentElement.parentElement.parentElement.parentElement.id);
            var sub_nro = retornSubNro(this.parentElement.parentElement.parentElement.parentElement.id);
            deleteImage(table, this.name, $("#hfFormularioId").val(), nro_pergunta, sub_nro);
            event.preventDefault();
        });
    });

    $(window).click(function () {
        $(".img-thumbnail").each(function (index) {
            $(this).css("background-color", "#ffffff");
        });

        ids = [];
    });

    $(document).ready(function () {
        $('.printImage').bind('copy paste', function (e) {
            e.preventDefault();
        });
    });
});