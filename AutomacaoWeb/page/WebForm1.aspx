<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AutomacaoWeb.page.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link href="../content/bootstrap.min.css" rel="stylesheet" />
    <link href="../content/bootstrap-datepicker.min.css" rel="stylesheet" />
    <link href="../content/font-awesome.min.css" rel="stylesheet" />
    <link href="../content/AdminLTE.min.css" rel="stylesheet" />
    <link href="../content/Page.css" rel="stylesheet" />
    <link href="../content/iCheck/all.css" rel="stylesheet" />
    <link href="../content/sumoselect.css" rel="stylesheet" />

    <script src="../scripts/jquery-3.3.1.min.js"></script>
    <script src="../scripts/vanilla-masker.min.js"></script>
    <script src="../scripts/jquery.inputmask.js"></script>
    <script src="../scripts/jquery.mask.min.js"></script>
    <script src="../scripts/jquery.sumoselect.min.js"></script>
    <script src="../scripts/jquery.maskMoney.js"></script>
    <script src="../content/iCheck/icheck.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
    <script src="../scripts/bootstrap-datepicker.min.js"></script>
    <script src="../scripts/bootstrap-datepicker.pt-BR.min.js"></script>
    <%--<script src="../scripts/image.js"></script>--%>
  
    <script src="../scripts/teste.js"></script>
</head>
<body>
    <form id="form1" runat="server">
             <button type="submit" id="btnTeste" class="btn btn-primary">Submit</button>

                            <table id='tbl_printQuestao_1'>
                            </table>


                    <div class="box-body">
                  <table id="example2" class="table table-bordered table-hover">
                      <thead>
                          <tr>
                              <th>idCliente</th>
                              <th>statusNet</th>
                              <th>nome</th>
                          </tr>
                      </thead>
                      <tbody></tbody>

                  </table>
              </div>

    </form>
</body>
</html>
