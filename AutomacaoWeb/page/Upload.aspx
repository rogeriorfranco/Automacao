<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Upload.aspx.cs" Inherits="AutomacaoWeb.page.Upload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Importação de Mailing</title>

    <link rel="shortcut icon" href="../images/favicon.ico" />
    <link href="../content/bootstrap.min.css" rel="stylesheet" />
    <link href="../content/font-awesome.min.css" rel="stylesheet" />
    <link href="../content/AdminLTE.min.css" rel="stylesheet" />
    <script src="../scripts/jquery-3.3.1.min.js"></script>
    <script src="../scripts/upload.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <section class="content-header">
            <h1>Importação</h1>
        </section>

        <section class="content">

            <div class="box box-primary">
                <div class="box-body">
                    <div class='row'>

                        <div class="input-group">
                            <asp:DropDownList ID="ddlTipoRelatorio" runat="server">
                                <asp:ListItem Value="0">Selecione</asp:ListItem>
                                <asp:ListItem>1 - 249: AcordoPrevio/Subsidio</asp:ListItem>
                                <asp:ListItem>2 - 249: Execução/Liminar/Descumprimento</asp:ListItem>
                                <asp:ListItem>3 - 249: Finalizados</asp:ListItem>
                                <asp:ListItem>4 - Reabertura: Incluir Atualização</asp:ListItem>
                                <asp:ListItem>5 - Reabertura: Atualizar cumprimento</asp:ListItem>
                                <asp:ListItem>6 - Reabertura: Reanálise Má Qualidade</asp:ListItem>
                                <asp:ListItem>7 - Reabertura: Ajustar Inf. Demanda (Má Qualidade)</asp:ListItem>
                                <asp:ListItem>8 - Reabertura: Ajustar Inf. Demanda (Cumprimento)</asp:ListItem>
                                <asp:ListItem>9 - Reabertura: Executar Cumprimento</asp:ListItem>
                                <asp:ListItem>10 - Reabertura: Incluir Inf. Operador</asp:ListItem>
                            </asp:DropDownList>
                        </div>

                        <br />
                        <div class="input-group">
                            <asp:FileUpload ID="FileUploadMalling" runat="server" CssClass="upload" />
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:Label ID="lblCount" runat="server"></asp:Label>
                        </div>
                        <br />
                        <div class="input-group">
                            <asp:LinkButton ID="btnFileUp" runat="server" CssClass="btn btn-primary" OnClick="btnFileUp_Click"><i class="fa fa-upload"></i> Importar </asp:LinkButton>
                        </div>



                    </div>
                </div>
            </div>
        </section>

    </form>
</body>
</html>
