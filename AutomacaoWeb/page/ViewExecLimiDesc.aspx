<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="ViewExecLimiDesc.aspx.cs" Inherits="AutomacaoWeb.page.ViewExecLimiDesc" %>

<%@ Register Src="~/template/UserControlHeader.ascx" TagPrefix="uc1" TagName="UserControlHeader" %>
<%@ Register Src="~/template/UserControlExecQuestao1.ascx" TagPrefix="uc1" TagName="UserControlExecQuestao1" %>
<%@ Register Src="~/template/UserControlExecQuestao3.ascx" TagPrefix="uc1" TagName="UserControlExecQuestao3" %>
<%@ Register Src="~/template/UserControlUpdateProgress.ascx" TagPrefix="uc1" TagName="UserControlUpdateProgress" %>
<%@ Register Src="~/template/UserControlShowImage.ascx" TagPrefix="uc1" TagName="UserControlShowImage" %>
<%@ Register Src="~/template/UserControlQuestao11.ascx" TagPrefix="uc1" TagName="UserControlQuestao11" %>
<%@ Register Src="~/template/UserControlQuestao13.ascx" TagPrefix="uc1" TagName="UserControlQuestao13" %>
<%@ Register Src="~/template/UserControlQuestao14.ascx" TagPrefix="uc1" TagName="UserControlQuestao14" %>





<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Automação</title>
    <link rel="shortcut icon" href="../images/favicon.ico" />
    <link href="../content/bootstrap.min.css" rel="stylesheet" />
    <link href="../content/font-awesome.min.css" rel="stylesheet" />
    <link href="../content/Page.css" rel="stylesheet" />
    <link href="../content/iCheck/all.css" rel="stylesheet" />
    <link href="../content/AdminLTE.min.css" rel="stylesheet" />
    <link href="../content/sumoselect.css" rel="stylesheet" />

    <script src="../scripts/jquery-3.3.1.min.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
    <script src="../scripts/vanilla-masker.min.js"></script>
    <script src="../content/iCheck/icheck.min.js"></script>
    <script src="../scripts/jquery.sumoselect.min.js"></script>
    <script src="../scripts/image.js"></script>
    <script src="../scripts/execLimiDesc.js"></script>
</head>
<body>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <section class="content-header">
            <h1>
                <asp:Label ID="lblTitulo" runat="server" ClientIDMode="Static"></asp:Label><small><asp:Label ID="lblSubTituloCaso" runat="server"></asp:Label></small>
                <asp:Label ID="lblStatusReabertura" runat="server"></asp:Label>
            </h1>

            <ol class="breadcrumb">
                <li><a target="_blank" href="../Home"><i class="fa fa-search"></i>Pesquisar Sub</a></li>
            </ol>

        </section>

        <asp:HiddenField ID="hfId" runat="server" ClientIDMode="Static" />
        <asp:HiddenField ID="hfFormularioId" runat="server" ClientIDMode="Static" />
        <section class="content">

            <div class="box box-primary">
                <div class="box-body">

                    <uc1:UserControlHeader runat="server" ID="UserControlHeader" />

                    <hr />

                    <h4 class="text-light-blue">Obrigações a fazer</h4>
                    <label class="text-light-blue">Justificativa: </label>
                    <asp:Label ID="lblJustificativa" runat="server"></asp:Label>
                    <br />
                    <label class="text-light-blue">Informações Complementares: </label>
                    <asp:Label ID="lblInfoComplementares" runat="server"></asp:Label>
                    <br />
                    <label class="text-light-blue">Motivo Cumprimento: </label>
                    <asp:Label ID="lblMotivoCumprimento" runat="server"></asp:Label>
                    <br />
                    <label class="text-light-blue">Descrição: </label>
                    <asp:Label ID="lblDescricao" runat="server"></asp:Label>
                    <br />
                    <label class="text-light-blue">Orgão: </label>
                    <asp:Label ID="lblOrgao" runat="server"></asp:Label>
                    <br />
                    <hr />

                    <h4 class="text-light-blue">Print e detalhes da obrigação a fazer</h4>
                    <asp:TextBox ID="printQuestao_0" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                    <asp:TextBox ID="txtDetalheQuestao_0" runat="server" TextMode="MultiLine" Height="100px" Width="100%" placeholder="Detalhes"></asp:TextBox>

                    <table id='tbl_printQuestao_0'>
                    </table>

                    <br />
                    <hr />

                    <ol>
                        <li class="text-light-blue">Itens da obrigação de fazer</li>
                        <div class="box-header">
                            <h4 class="box-title">
                                <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne">Selecionar Motivo da Obrigação
                                </a>
                            </h4>
                        </div>

                        <div id="collapseOne" class="panel-collapse collapse">
                            <div class="box-body">

                                <div class="form-group row">
                                    <div class="col-sm-12">
                                        <input type="text" class="form-control" id="filterCheck" placeholder="Digite alguma letra para filtrar os motivos">
                                    </div>
                                </div>

                                <asp:CheckBoxList ID="cbList" runat="server" RepeatColumns="4" ClientIDMode="Static">
                                    <asp:ListItem Value="1">RESGATE DE LIGAÇÃO</asp:ListItem>
                                    <asp:ListItem Value="2">ENVIAR PARA DOSSIÊ</asp:ListItem>
                                    <asp:ListItem Value="3">RETORNO ESCRITÓRIO</asp:ListItem>
                                    <asp:ListItem Value="4">ALTERAR PLANO</asp:ListItem>
                                    <asp:ListItem Value="5">CANCELAR LINHA / CONTRATO</asp:ListItem>
                                    <asp:ListItem Value="6">REATIVAR LINHA / CONTRATO</asp:ListItem>
                                    <asp:ListItem Value="7">REINSTALAR LINHA / CONTRATO</asp:ListItem>
                                    <asp:ListItem Value="8">INCLUIR PONTO ADICIONAL (TV)</asp:ListItem>
                                    <asp:ListItem Value="9">EXCLUIR PONTO ADICIONAL (TV)</asp:ListItem>
                                    <asp:ListItem Value="10">SUSPENDER LINHA / CONTRATO (30 dias)</asp:ListItem>
                                    <asp:ListItem Value="11">SUSPENDER LINHA / CONTRATO (60 dias)</asp:ListItem>
                                    <asp:ListItem Value="12">SUSPENDER LINHA / CONTRATO (90 dias)</asp:ListItem>
                                    <asp:ListItem Value="13">SUSPENDER LINHA / CONTRATO (120 dias)</asp:ListItem>
                                    <asp:ListItem Value="14">RETIRAR SUSPENSÃO LINHA / CONTRATO</asp:ListItem>
                                    <asp:ListItem Value="15">SUB JUDICE</asp:ListItem>
                                    <asp:ListItem Value="16">POLÍTICA DE PREÇO</asp:ListItem>
                                    <asp:ListItem Value="17">INDIVIDUALIZAR PRODUTOS</asp:ListItem>
                                    <asp:ListItem Value="18">LIBERAR CPF</asp:ListItem>
                                    <asp:ListItem Value="19">DESABILITAR LINHA / CONTRATO</asp:ListItem>
                                    <asp:ListItem Value="20">DESCONECTAR LINHA / CONTRATO</asp:ListItem>
                                    <asp:ListItem Value="21">BAIXAR EQUIPAMENTO (Valores)</asp:ListItem>
                                    <asp:ListItem Value="22">RETIRAR EQUIPAMENTO (Visita Técnica)</asp:ListItem>
                                    <asp:ListItem Value="23">Incluir - NÃO REALIZAR COBRANÇA (CLARO Móvel ACA)</asp:ListItem>
                                    <asp:ListItem Value="24">Retirar - NÃO REALIZAR COBRANÇA (CLARO Móvel ACA)</asp:ListItem>
                                    <asp:ListItem Value="25">Incluir - NÃO REALIZAR COBRANÇA (CLARO TV)</asp:ListItem>
                                    <asp:ListItem Value="26">Retirar - NÃO REALIZAR COBRANÇA (CLARO TV)</asp:ListItem>
                                    <asp:ListItem Value="27">Incluir - NÃO REALIZAR COBRANÇA (NET Combo Multi)</asp:ListItem>
                                    <asp:ListItem Value="28">Retirar - NÃO REALIZAR COBRANÇA (NET Combo Multi)</asp:ListItem>
                                    <asp:ListItem Value="29">Incluir - NÃO REALIZAR COBRANÇA (NET TV)</asp:ListItem>
                                    <asp:ListItem Value="30">Retirar - NÃO REALIZAR COBRANÇA (NET TV)</asp:ListItem>
                                    <asp:ListItem Value="31">Incluir - NÃO REALIZAR COBRANÇA (NET Fone)</asp:ListItem>
                                    <asp:ListItem Value="32">Retirar - NÃO REALIZAR COBRANÇA (NET Fone)</asp:ListItem>
                                    <asp:ListItem Value="33">Incluir - NÃO REALIZAR COBRANÇA (EMBRATEL)</asp:ListItem>
                                    <asp:ListItem Value="34">Retirar - NÃO REALIZAR COBRANÇA (EMBRATEL)</asp:ListItem>
                                    <asp:ListItem Value="35">ALTERAR EMAIL</asp:ListItem>
                                    <asp:ListItem Value="36">Incluir - DEPENDENTE / ADICIONAL</asp:ListItem>
                                    <asp:ListItem Value="37">Retirar - DEPENDENTE / ADICIONAL</asp:ListItem>
                                    <asp:ListItem Value="38">Incluir - FLAG DE ISENÇÃO</asp:ListItem>
                                    <asp:ListItem Value="39">Retirar - FLAG DE ISENÇÃO</asp:ListItem>
                                    <asp:ListItem Value="40">Incluir - BÔNUS DADOS CELULAR</asp:ListItem>
                                    <asp:ListItem Value="41">Retirar - BÔNUS DADOS CELULAR</asp:ListItem>
                                    <asp:ListItem Value="42">Incluir - PROMOÇÃO CELULAR</asp:ListItem>
                                    <asp:ListItem Value="43">Retirar - PROMOÇÃO CELULAR</asp:ListItem>
                                    <asp:ListItem Value="44">Incluir - PROMOÇÃO VIRTUAL</asp:ListItem>
                                    <asp:ListItem Value="45">Retirar - PROMOÇÃO VIRTUAL</asp:ListItem>
                                    <asp:ListItem Value="46">Incluir - PROMOÇÃO NET FONE</asp:ListItem>
                                    <asp:ListItem Value="47">Retirar - PROMOÇÃO NET FONE</asp:ListItem>
                                    <asp:ListItem Value="48">Incluir - PROMOÇÃO CLARO TV</asp:ListItem>
                                    <asp:ListItem Value="49">Retirar - PROMOÇÃO CLARO TV</asp:ListItem>
                                    <asp:ListItem Value="50">Incluir - PROMOÇÃO EMBRATEL</asp:ListItem>
                                    <asp:ListItem Value="51">Retirar - PROMOÇÃO EMBRATEL</asp:ListItem>
                                    <asp:ListItem Value="52">POSITIVAR CLIENTE (Baixa de Restritivo)</asp:ListItem>
                                    <asp:ListItem Value="53">Retirar - FLAG DE ISENÇÃO</asp:ListItem>
                                    <asp:ListItem Value="54">INSERIR CRÉDITOS</asp:ListItem>
                                    <asp:ListItem Value="55">INIBIÇÃO ENVIO DE FATURAS</asp:ListItem>
                                    <asp:ListItem Value="56">REEMISSÃO DE BOLETOS</asp:ListItem>
                                    <asp:ListItem Value="57">CANCELAR SERVIÇOS</asp:ListItem>
                                    <asp:ListItem Value="58">CANCELAR AGREGADORES</asp:ListItem>
                                    <asp:ListItem Value="59">CANCELAR DÉBITOS</asp:ListItem>
                                    <asp:ListItem Value="60">TRANSFERÊNCIA DE TITULARIDADE</asp:ListItem>
                                    <asp:ListItem Value="61">AJUSTE DE FATURAS</asp:ListItem>
                                    <asp:ListItem Value="62">INIBIÇÃO DE FATURAS NET</asp:ListItem>
                                </asp:CheckBoxList>


                            </div>

                            <div id="pQuestao_1" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_1" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_1" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_1" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_1" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_1" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_1'>
                                </table>
                            </div>

                            <div id="pQuestao_2" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_2" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_2" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_2" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_2" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_2" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_2'>
                                </table>
                            </div>

                            <div id="pQuestao_3" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_3" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_3" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_3" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_3" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_3" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_3'>
                                </table>
                            </div>

                            <div id="pQuestao_4" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_4" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_4" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_4" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_4" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_4" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_4'>
                                </table>
                            </div>

                            <div id="pQuestao_5" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_5" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_5" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_5" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_5" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_5" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_5'>
                                </table>
                            </div>

                            <div id="pQuestao_6" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_6" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_6" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_6" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_6" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_6" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_6'>
                                </table>
                            </div>

                            <div id="pQuestao_7" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_7" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_7" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="70px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_7" runat="server" TextMode="MultiLine" Height="70px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_7" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_7" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_7'>
                                </table>
                            </div>

                            <div id="pQuestao_8" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_8" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_8" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_8" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_8" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_8" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_8'>
                                </table>
                            </div>

                            <div id="pQuestao_9" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_9" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_9" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="90px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_9" runat="server" TextMode="MultiLine" Height="90px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_9" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_9" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_9'>
                                </table>
                            </div>

                            <div id="pQuestao_10" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_10" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_10" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_10" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_10" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_10" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_10'>
                                </table>
                            </div>

                            <div id="pQuestao_11" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_11" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_11" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="110%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_11" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_11" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_11" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_11'>
                                </table>
                            </div>

                            <div id="pQuestao_12" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_12" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_12" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="120%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_12" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_12" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_12" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_12'>
                                </table>
                            </div>

                            <div id="pQuestao_13" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_13" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_13" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="130%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_13" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_13" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_13" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_13'>
                                </table>
                            </div>

                            <div id="pQuestao_14" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_14" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_14" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="140%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_14" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_14" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_14" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_14'>
                                </table>
                            </div>

                            <div id="pQuestao_15" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_15" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_15" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="150%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_15" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_15" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_15" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_15'>
                                </table>
                            </div>

                            <div id="pQuestao_16" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_16" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_16" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="160%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_16" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_16" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_16" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_16'>
                                </table>
                            </div>

                            <div id="pQuestao_17" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_17" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_17" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="170%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_17" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_17" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_17" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_17'>
                                </table>
                            </div>

                            <div id="pQuestao_18" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_18" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_18" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="180%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_18" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_18" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_18" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_18'>
                                </table>
                            </div>

                            <div id="pQuestao_19" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_19" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_19" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="190%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_19" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_19" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_19" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_19'>
                                </table>
                            </div>

                            <div id="pQuestao_20" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_20" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_20" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="200%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_20" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_20" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_20" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_20'>
                                </table>
                            </div>

                            <div id="pQuestao_21" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_21" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_21" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="210%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_21" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_21" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_21" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_21'>
                                </table>
                            </div>

                            <div id="pQuestao_22" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_22" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_22" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="220%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_22" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_22" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_22" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_22'>
                                </table>
                            </div>

                            <div id="pQuestao_23" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_23" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_23" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="230%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_23" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_23" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_23" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_23'>
                                </table>
                            </div>

                            <div id="pQuestao_24" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_24" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_24" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="240%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_24" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_24" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_24" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_24'>
                                </table>
                            </div>

                            <div id="pQuestao_25" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_25" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_25" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="250%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_25" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_25" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_25" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_25'>
                                </table>
                            </div>

                            <div id="pQuestao_26" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_26" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_26" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="260%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_26" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_26" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_26" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_26'>
                                </table>
                            </div>

                            <div id="pQuestao_27" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_27" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_27" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="270%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_27" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_27" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_27" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_27'>
                                </table>
                            </div>

                            <div id="pQuestao_28" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_28" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_28" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="280%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_28" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_28" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_28" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_28'>
                                </table>
                            </div>

                            <div id="pQuestao_29" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_29" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_29" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="290%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_29" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_29" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_29" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_29'>
                                </table>
                            </div>

                            <div id="pQuestao_30" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_30" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_30" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="300%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_30" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_30" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_30" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_30'>
                                </table>
                            </div>

                            <div id="pQuestao_31" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_31" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_31" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="310%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_31" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_31" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_31" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_31'>
                                </table>
                            </div>

                            <div id="pQuestao_32" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_32" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_32" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="320%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_32" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_32" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_32" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_32'>
                                </table>
                            </div>

                            <div id="pQuestao_33" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_33" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_33" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="330%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_33" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_33" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_33" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_33'>
                                </table>
                            </div>

                            <div id="pQuestao_34" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_34" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_34" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="340%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_34" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_34" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_34" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_34'>
                                </table>
                            </div>

                            <div id="pQuestao_35" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_35" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_35" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="350%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_35" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_35" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_35" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_35'>
                                </table>
                            </div>

                            <div id="pQuestao_36" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_36" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_36" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="360%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_36" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_36" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_36" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_36'>
                                </table>
                            </div>

                            <div id="pQuestao_37" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_37" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_37" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="370%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_37" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_37" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_37" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_37'>
                                </table>
                            </div>

                            <div id="pQuestao_38" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_38" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_38" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="380%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_38" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_38" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_38" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_38'>
                                </table>
                            </div>

                            <div id="pQuestao_39" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_39" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_39" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="380%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_39" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_39" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_39" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_39'>
                                </table>
                            </div>

                            <div id="pQuestao_40" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_40" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_40" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="400%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_40" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_40" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_40" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_40'>
                                </table>
                            </div>

                            <div id="pQuestao_41" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_41" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_41" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="410%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_41" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_41" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_41" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_41'>
                                </table>
                            </div>

                            <div id="pQuestao_42" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_42" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_42" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="60px" Width="420%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_42" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_42" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_42" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_42'>
                                </table>
                            </div>

                            <div id="pQuestao_43" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_43" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_43" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_43" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_43" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_43" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_43'>
                                </table>
                            </div>

                            <div id="pQuestao_44" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_44" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_44" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_44" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_44" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_44" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_44'>
                                </table>
                            </div>

                            <div id="pQuestao_45" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_45" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_45" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_45" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_45" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_45" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_45'>
                                </table>
                            </div>

                            <div id="pQuestao_46" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_46" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_46" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_46" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_46" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_46" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_46'>
                                </table>
                            </div>

                            <div id="pQuestao_47" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_47" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_47" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_47" runat="server" TextMode="MultiLine" Height="60px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_47" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_47" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_47'>
                                </table>
                            </div>

                            <div id="pQuestao_48" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_48" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_48" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="70px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_48" runat="server" TextMode="MultiLine" Height="70px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_48" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_48" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_48'>
                                </table>
                            </div>

                            <div id="pQuestao_49" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_49" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_49" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_49" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_49" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_49" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_49'>
                                </table>
                            </div>

                            <div id="pQuestao_50" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_50" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_50" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_50" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_50" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_50" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_50'>
                                </table>
                            </div>

                            <div id="pQuestao_51" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_51" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_51" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_51" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_51" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_51" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_51'>
                                </table>
                            </div>

                            <div id="pQuestao_52" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_52" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_52" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_52" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_52" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_52" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_52'>
                                </table>
                            </div>

                            <div id="pQuestao_53" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_53" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_53" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_53" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_53" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_53" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_53'>
                                </table>
                            </div>

                            <div id="pQuestao_54" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_54" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_54" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_54" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_54" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_54" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_54'>
                                </table>
                            </div>

                            <div id="pQuestao_55" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_55" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_55" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_55" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_55" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_55" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_55'>
                                </table>
                            </div>

                            <div id="pQuestao_56" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_56" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_56" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_56" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_56" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_56" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_56'>
                                </table>
                            </div>

                            <div id="pQuestao_57" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_57" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_57" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_57" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_57" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_57" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_57'>
                                </table>
                            </div>

                            <div id="pQuestao_58" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_58" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_58" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_58" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_58" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_58" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_58'>
                                </table>
                            </div>

                            <div id="pQuestao_59" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_59" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_59" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_59" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_59" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_59" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_59'>
                                </table>
                            </div>


                            <div id="pQuestao_60" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_60" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_60" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_60" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_60" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_60" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_60'>
                                </table>
                            </div>


                            <div id="pQuestao_61" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_61" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_61" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_61" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_61" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_61" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_61'>
                                </table>
                            </div>


                            <div id="pQuestao_62" runat="server" style="display: none">
                                <asp:TextBox ID="lblQuestao_62" CssClass="text-light-blue" Font-Bold="true" BorderStyle="None" BackColor="White" runat="server" Enabled="false" Width="200px"></asp:TextBox>
                                <asp:TextBox ID="printQuestao_62" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_62" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Detalhamento ..."></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rvftxtObsQuestao_62" runat="server" InitialValue="" ControlToValidate="txtObsQuestao_62" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                <table id='tbl_printQuestao_62'>
                                </table>
                            </div>

                            <br />
                            <li class="text-light-blue">Considerações finais</li>
                            <asp:TextBox ID="txtFinalizacao" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>
                    </ol>

                </div>


                <div class="box-header">
                    <h4 class="box-title">
                        <a data-toggle="collapse" data-parent="#accordion" href="#collapseTwo">
                            <h2 class="text-primary" style="text-align: center;"><strong>Questionário</strong></h2>
                        </a>
                    </h4>
                </div>

                <div id="collapseTwo" class="panel-collapse collapse in" aria-expanded="true">
                    <div class="box-body">

                        <uc1:UserControlExecQuestao1 runat="server" ID="UserControlExecQuestao1" />

                        <uc1:UserControlExecQuestao3 runat="server" ID="UserControlExecQuestao3" />

                        <uc1:UserControlQuestao11 runat="server" ID="UserControlQuestao11" />

                        <uc1:UserControlQuestao13 runat="server" ID="UserControlQuestao13" />

                        <uc1:UserControlQuestao14 runat="server" ID="UserControlQuestao14" />



                        <asp:Panel ID="pPrincipalRespostaCumprimento" runat="server" Visible="false">
                            <fieldset style="text-align: left; margin: 15px;">
                                <legend>
                                    <h5 class="text-primary" style="text-align: left;"><strong>RESPOSTA OPERAÇÃO</strong></h5>
                                </legend>
                                <div class="row">

                                    <div class="col-sm-3" style="text-align: right; padding: 2px">
                                        <asp:Label runat="server" class="text-light-blue">Solicitação Escritório - Atualizar Cumprimento:</asp:Label>
                                    </div>

                                    <div class="col-sm-9" style="padding: 2px">
                                        <asp:TextBox ID="txtSolicitacaoEscritorio" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvtxtSolicitacaoEscritorio" runat="server" InitialValue="" ControlToValidate="txtSolicitacaoEscritorio" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                    </div>

                                    <div class="col-sm-3" style="text-align: right; padding: 2px">
                                        <asp:Label runat="server" class="text-light-blue">Resposta Operação - Atualizar Cumprimento:</asp:Label>
                                    </div>

                                    <div class="col-sm-9" style="padding: 2px">
                                        <asp:TextBox ID="txtRespostaOperacao" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvtxtRespostaOperacao" runat="server" InitialValue="" ControlToValidate="txtRespostaOperacao" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true" Enabled="false"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </fieldset>
                        </asp:Panel>


                    </div>
                </div>

                <div class="box-footer">
                    <asp:UpdatePanel ID="upSalvar" runat="server">
                        <ContentTemplate>
                            <asp:LinkButton ID="btnSalvar" ToolTip="Salva as informações parcialmente" CausesValidation="false" runat="server" CssClass="btn btn-danger" OnClick="btnSalvar_Click"><i class="fa fa-save"></i> Salvar Parcial</asp:LinkButton>

                            <asp:LinkButton ToolTip="Salva o formulário para a conclusão" Style="float: right;" ID="btnConcluir" runat="server" CssClass="btn btn-primary" OnClick="btnConcluir_Click"><i class="fa fa-check"></i> Salvar e Concluir</asp:LinkButton>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>

            </div>
        </section>
        <uc1:UserControlUpdateProgress runat="server" ID="UserControlUpdateProgress" />
        <uc1:UserControlShowImage runat="server" ID="UserControlShowImage" />
    </form>
</body>
</html>
