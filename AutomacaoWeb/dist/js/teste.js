function teste() {
    $.getJSON("http://localhost:53722/testeApi",
        function (data) {
            $("#example2 tbody").empty();
            if (data.length > 0) {
                $.each(data, function (i, item) {
                    $("#example2 tbody").append(
                        "<tr>"
                        + "<td>" + item.id + "</td>"
                        + "<td>" + item.cliente + "</td>"
                        + "<td>" + item.cpf + "</td>"
                        + "</tr>"
                    );
                });
            }
        });
}

    $(document).ready(function () {
        $('#btnTeste').click(function (e) {
            teste();
           // loadImages('tbl_printQuestao_1');
        });
    });

