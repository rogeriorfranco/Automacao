//function loadTableTeste() {
//    $.getJSON("../testeApi",
//        function (data) {
//            //$("#tbl_printQuestao_1").empty();
//            if (data.length > 0) {
//                var appendToResult = "<tr>";
//                $.each(data, function (index) {
//                    appendToResult = appendToResult + "<td>";
//                    appendToResult = appendToResult + "<div class='carousel-inner'>";
//                    appendToResult = appendToResult + "<img id='" + table + "_ImgPic_" + index + "' class='img-thumbnail' name='" + this['id'] + "' src='data:image/png;base64," + this['imgRedimensionada'] + "'>";
//                    appendToResult = appendToResult + "<a id='" + table + "_lblExcluir_" + index + "'class='img-excluir' name='" + this['id'] + "' href='#'')'>Excluir</a>";
//                    appendToResult = appendToResult + "</div>";
//                    appendToResult = appendToResult + "</td>";
//                });
//                appendToResult + "\n" + "</tr>";
//                //$("#tbl_printQuestao_1").append(appendToResult);
//            }
//        });
    $(document).ready(function () {

        loadImages('tbl_printQuestao_1');


    });

function loadImages(table) {
    $.getJSON("http://localhost:53722/readImages/42997/12/0",
            function (data) {
                $("#tbl_printQuestao_1").empty();
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
                    $("#tbl_printQuestao_1").append(appendToResult);
                }
            });
    }

    //$(document).ready(function () {
    //    $('#btnTeste').click(function (e) {
    //        loadImages();
    //    });
    //});


    //function loadImage() {
    //    $.getJSON("http://10.33.113.28:81/api/cliente/dadosCliente/087192326279222",
    //        function (data) {
    //            console.log(data);
    //        })
    //        .fail(
    //            function (jqXHR, textStatus, err) {
    //                console.log(err);
    //            });
    //}