<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="AutomacaoWeb.Home" %>

<%@ Register Src="~/template/UserControlShowImage.ascx" TagPrefix="uc1" TagName="UserControlShowImage" %>
<%@ Register Src="~/template/UserControlUpdateProgress.ascx" TagPrefix="uc1" TagName="UserControlUpdateProgress" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Automação</title>
    <link rel="shortcut icon" href="<%= ResolveUrl("images/favicon.ico") %>" />
    <link href="<%= ResolveUrl("content/bootstrap.min.css") %>" rel="stylesheet" />
    <link href="<%= ResolveUrl("content/font-awesome.min.css") %>" rel="stylesheet" />
    <link href="<%= ResolveUrl("content/iCheck/all.css") %>" rel="stylesheet" />
    <link href="<%= ResolveUrl("content/AdminLTE.min.css") %>" rel="stylesheet" />
    <script src="<%= ResolveUrl("scripts/jquery-3.3.1.min.js") %>"></script>
    <script src="<%= ResolveUrl("content/iCheck/icheck.min.js") %>"></script>
    <script src="<%= ResolveUrl("scripts/bootstrap.min.js") %>"></script>
    <script src="<%= ResolveUrl("scripts/automacao.js") %>"></script>
    <script src="dist/js/teste.js"></script>
</head>
<body>
    <form id="form1" runat="server">

                          <button type="submit" id="btnTeste" class="btn btn-primary">Submit</button>

                            <table id='tbl_printQuestao_1'>
                            </table>



        <asp:ScriptManager ID="ScriptManager1" runat="server" EnablePartialRendering="true"></asp:ScriptManager>

        <section class="content-header">
            <h1>Selecione o tipo de formulário<small><asp:Label ID="lblSubTituloCaso" runat="server"></asp:Label></small></h1>
        </section>

        <section class="content">
            <div class="box box-primary">
                <div class="box-body">
                    <asp:UpdatePanel ID="upList" runat="server" UpdateMode="Always">
                        <ContentTemplate>
                            <asp:RadioButtonList ID="rbList" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="rbList_SelectedIndexChanged" CellPadding="3">
                                <asp:ListItem Value="2">Acordo Previo</asp:ListItem>
                                <asp:ListItem Value="3">Execução</asp:ListItem>
                                <asp:ListItem Value="4">Liminar</asp:ListItem>
                                <asp:ListItem Value="5">Descumprimento</asp:ListItem>
                                <asp:ListItem Value="6">Subsídio</asp:ListItem>
                            </asp:RadioButtonList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                    <br />
                    <asp:UpdatePanel ID="upSubisdio" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="cSubisidio"  runat="server" Visible="false" CssClass="form-control input-sm" AutoPostBack="True" OnSelectedIndexChanged="cSubisidio_SelectedIndexChanged">
                                <asp:ListItem Value="0">Selecione</asp:ListItem>
                                <asp:ListItem Value="1">Fraude</asp:ListItem>
                                <asp:ListItem Value="6">Acidente</asp:ListItem>
                                <asp:ListItem Value="7">Portabilidade</asp:ListItem>
                                <asp:ListItem Value="8">Problemas Com Vendas</asp:ListItem>
                                <asp:ListItem Value="9">Migração Indevida</asp:ListItem>
                                <asp:ListItem Value="10">Negativação Indevida</asp:ListItem>
                                <asp:ListItem Value="11">Cancelamento</asp:ListItem>
                                <asp:ListItem Value="12">Entrega de Aparelho</asp:ListItem>
                                <asp:ListItem Value="13">Problema Técnico</asp:ListItem>
                                <asp:ListItem Value="14">Servico Adicional</asp:ListItem>
                                <asp:ListItem Value="16">Rede Cobertura</asp:ListItem>
                                <asp:ListItem Value="17">Outros</asp:ListItem>
                            </asp:DropDownList>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>

            <br />


            <div class='row' style="padding-top: 20px">
                <asp:UpdatePanel ID="upTot" runat="server">
                    <ContentTemplate>
                        <div class="col-xs-12">
                            <h2 class="page-header">
                                <i class="fa fa-filter"></i>Consulta Demanda           

                                <small class="pull-right">
                                    <asp:Label ID="lblTotDemanda" runat="server"></asp:Label></small>

                            </h2>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

            <div class="col-sm-2">
                <div class="form-group">
                    <label>Sub</label>
                    <asp:TextBox ID="txtCaso" ClientIDMode="Static" runat="server" class="form-control input-sm"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-2">
                <div class="form-group">
                    <label>Cliente</label>
                    <asp:TextBox ID="txtCliente" runat="server" class="form-control input-sm" ClientIDMode="Static"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-2">
                <div class="form-group">
                    <label>Cpf</label>
                    <asp:TextBox ID="txtCpf" runat="server" class="form-control input-sm" ClientIDMode="Static"></asp:TextBox>
                </div>
            </div>
            <div class="col-sm-2">
                <div class="form-group">
                    <label>Tipo</label>
                    <asp:DropDownList ID="ddlTipo" runat="server" class="form-control input-sm" ClientIDMode="Static">
                        <asp:ListItem Value="0">Selecione</asp:ListItem>
                        <asp:ListItem>Acordo Prévio</asp:ListItem>
                        <asp:ListItem>Execução</asp:ListItem>
                        <asp:ListItem>Liminar</asp:ListItem>
                        <asp:ListItem>Descumprimento</asp:ListItem>
                        <asp:ListItem>Subsídio</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            <div class="col-xs-2">
                <div class="pull-right" style="padding-top: 15px">
                    <asp:UpdatePanel ID="upPesquisar" runat="server">
                        <ContentTemplate>
                            <asp:LinkButton ID="lbPesquisar" runat="server" CssClass="btn btn-primary" OnClick="lbPesquisar_Click"><i class="fa fa-search"></i> Pesquisar</asp:LinkButton>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            </div>
            <div class="table-responsive">
                <asp:UpdatePanel ID="upGv" runat="server">
                    <ContentTemplate>
                        <asp:GridView ID="gv" ClientIDMode="Static" runat="server" CssClass="table table-bordered table-hover"
                            EmptyDataText="Sem Informações" AutoGenerateColumns="False" AllowPaging="True" PageSize="100" OnRowCommand="gv_RowCommand" OnRowDataBound="gv_RowDataBound" OnPageIndexChanging="gv_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbEdit" runat="server" CausesValidation="False" CommandName="Select" ToolTip="Visualizar Demanda"><i class="fa fa-edit"></i></asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle VerticalAlign="Middle" Wrap="False" Width="10px" />
                                </asp:TemplateField>
                                 <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbPdf" runat="server" CausesValidation="False" CommandName="Download" ToolTip="Visualizar PDF"><i class="fa fa-download"></i></asp:LinkButton>
                                    </ItemTemplate>
                                    <ItemStyle VerticalAlign="Middle" Wrap="False" Width="10px" />
                                </asp:TemplateField>
                                <asp:BoundField DataField="id_caso" HeaderText="Sub" />
                                <asp:BoundField DataField="formulario" HeaderText="Formulario" />
                                <asp:BoundField DataField="cliente" HeaderText="Cliente" />
                                <asp:BoundField DataField="cpf" HeaderText="Cpf" />
                                <asp:BoundField DataField="nro_processo" HeaderText="Processo" />
                                <asp:BoundField DataField="nro_linha" HeaderText="Linha" />
                                <asp:BoundField DataField="nro_contrato" HeaderText="Contrato" />
                                <asp:BoundField DataField="estado" HeaderText="Estado" />
                                <asp:BoundField DataField="cidade" HeaderText="Cidade" />
                            </Columns>
                            <EmptyDataRowStyle ForeColor="Red" />
                            <HeaderStyle CssClass="thead" />
                            <PagerStyle CssClass="pagination-ys" />
                        </asp:GridView>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
                        <div class="modal fade" id="confirmModal" tabindex="-1" role="dialog" aria-labelledby="ModalLabel" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <button id="btnClose" type="button" class="close" data-dismiss="modal"" aria-hidden="true">&times;</button>
                            <h4 class="modal-title" id="myModalLabel">Automação</h4>
                        </div>
                        <div class="modal-body">
                            <h4>
                               <label id="textModalId"></label>
                            </h4>
                        </div>
                        <div class="modal-footer">

                            <button type="button" class="btn btn-secondary" data-dismiss="modal">Não</button>
                            <asp:Button ID="btnProcess"  class="btn btn-primary" runat="server" Text="Sim" OnClick="btnProcess_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <uc1:UserControlShowImage runat="server" ID="UserControlShowImage" />
        <uc1:UserControlUpdateProgress runat="server" ID="UserControlUpdateProgress" />
    </form>
</body>
</html>

