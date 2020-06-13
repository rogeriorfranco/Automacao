﻿<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="ViewEntregaAparelho.aspx.cs" Inherits="AutomacaoWeb.page.ViewEntregaAparelho" %>

<%@ Register Src="~/template/UserControlHeader.ascx" TagPrefix="uc1" TagName="UserControlHeader" %>
<%@ Register Src="~/template/UserControlExecQuestao1.ascx" TagPrefix="uc4" TagName="UserControlExecQuestao1" %>
<%@ Register Src="~/template/UserControlQuestao5.ascx" TagPrefix="uc4" TagName="UserControlQuestao5" %>
<%@ Register Src="~/template/UserControlQuestao6.ascx" TagPrefix="uc4" TagName="UserControlQuestao6" %>
<%@ Register Src="~/template/UserControlQuestao7.ascx" TagPrefix="uc4" TagName="UserControlQuestao7" %>
<%@ Register Src="~/template/UserControlQuestao3_4.ascx" TagPrefix="uc1" TagName="UserControlQuestao3_4" %>
<%@ Register Src="~/template/UserControlUpdateProgress.ascx" TagPrefix="uc1" TagName="UserControlUpdateProgress" %>
<%@ Register Src="~/template/UserControlShowImage.ascx" TagPrefix="uc1" TagName="UserControlShowImage" %>
<%@ Register Src="~/template/UserControlQuestao14.ascx" TagPrefix="uc1" TagName="UserControlQuestao14" %>
<%@ Register Src="~/template/UserControlQuestao11.ascx" TagPrefix="uc1" TagName="UserControlQuestao11" %>
<%@ Register Src="~/template/UserControlQuestao12.ascx" TagPrefix="uc1" TagName="UserControlQuestao12" %>
<%@ Register Src="~/template/UserControlOcorrenciaNet.ascx" TagPrefix="uc1" TagName="UserControlOcorrenciaNet" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Automação</title>
    <link rel="shortcut icon" href="../images/favicon.ico" />
    <link href="../content/bootstrap.min.css" rel="stylesheet" />
    <link href="../content/bootstrap-datepicker.min.css" rel="stylesheet" />
    <link href="../content/sumoselect.css" rel="stylesheet" />
    <link href="../content/font-awesome.min.css" rel="stylesheet" />
    <link href="../content/AdminLTE.min.css" rel="stylesheet" />
    <link href="../content/Page.css" rel="stylesheet" />
    <link href="../content/iCheck/all.css" rel="stylesheet" />

    <script src="../scripts/jquery-3.3.1.min.js"></script>
    <script src="../scripts/jquery.inputmask.js"></script>
    <script src="../scripts/jquery.mask.min.js"></script>
    <script src="../scripts/jquery.sumoselect.min.js"></script>
    <script src="../scripts/jquery.maskMoney.js"></script>
    <script src="../scripts/bootstrap.min.js"></script>
    <script src="../scripts/bootstrap-datepicker.min.js"></script>
    <script src="../scripts/bootstrap-datepicker.pt-BR.min.js"></script>
    <script src="../scripts/vanilla-masker.min.js"></script>
    <script src="../content/iCheck/icheck.min.js"></script>
    <script src="../scripts/image.js"></script>
    <script src="../scripts/entregaaparelho.js"></script>
</head>
<body>

    <form id="form1" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <section class="content-header">
            <h1>Entrega de Aparelho<small><asp:Label ID="lblSubTituloCaso" runat="server"></asp:Label></small>
                <asp:Label ID="lblStatusReabertura" runat="server"></asp:Label>
            </h1>
        </section>

        <section class="content">

            <div class="box box-primary">
                <div class="box-body">

                    <uc1:UserControlHeader runat="server" ID="UserControlHeader" />

                    <div class='row'>

                        <hr />
                        <asp:HiddenField ID="hfId" runat="server" ClientIDMode="Static" />
                        <asp:HiddenField ID="hfFormularioId" runat="server" ClientIDMode="Static" />
                        <ol>

                            <li class="text-light-blue">Cliente ativo?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_1" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="" ControlToValidate="rbQuestao_1" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_1" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_1" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_1'>
                            </table>

                            <br />

                            <li class="text-light-blue">Data da instalação ou habilitação do produto </li>
                            <asp:TextBox ID="txtDtInsQuestao_2" runat="server" placeholder="Data" ClientIDMode="Static" MaxLength="10"></asp:TextBox>

                            <br />
                            <br />

                            <asp:TextBox ID="printQuestao_2" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_2" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>


                            <table id='tbl_printQuestao_2'>
                            </table>

                            <br />
                            <br />

                            <li class="text-light-blue">Existe protocolo de reclamação/solicitações quanto à entrega?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_3" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" InitialValue="" ControlToValidate="rbQuestao_3" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_3" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_3" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_3'>
                            </table>
                            <br />

                            <li class="text-light-blue">Cliente reclama de negativação realizada pelo grupo? Se sim, anexar tela que comprove a negativação.</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_4" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" InitialValue="" ControlToValidate="rbQuestao_4" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_4" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_4" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_4'>
                            </table>
                            <br />

                            <li class="text-light-blue">Cliente reclama de negativação realizada por terceiros? Se sim, anexar tela que comprove a negativação.</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_5" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" InitialValue="" ControlToValidate="rbQuestao_5" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_5" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_5" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_5'>
                            </table>
                            <br />


                            <li class="text-light-blue">Há solicitação de aparelho na venda?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_6" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" InitialValue="" ControlToValidate="rbQuestao_6" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_6" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_6" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_6'>
                            </table>
                            <br />


                            <li class="text-light-blue">A solicitação do aparelho foi cadastrada no sistema de acordo com o acordado no momento da venda?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_7" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" InitialValue="" ControlToValidate="rbQuestao_7" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_7" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_7" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_7'>
                            </table>
                            <br />

                            <li class="text-light-blue">Possui utilização/tráfego na combinação IMEI/IMSI?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_8" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" InitialValue="" ControlToValidate="rbQuestao_8" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_8" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_8" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_8'>
                            </table>
                            <br />

                            <li class="text-light-blue">Há comprovação de entrega de aparelho ou nota fiscal assinada?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_9" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" InitialValue="" ControlToValidate="rbQuestao_9" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_9" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_9" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_9'>
                            </table>
                            <br />

                            <li class="text-light-blue">Aparelho foi entregue dentro do prazo?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_10" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" InitialValue="" ControlToValidate="rbQuestao_10" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_10" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_10" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_10'>
                            </table>
                            <br />

                            <li class="text-light-blue">Recebeu o modelo que contratou?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_11" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" InitialValue="" ControlToValidate="rbQuestao_11" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_11" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_11" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_11'>
                            </table>
                            <br />

                            <li class="text-light-blue">Aparelho recondicionado?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_12" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" InitialValue="" ControlToValidate="rbQuestao_12" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_12" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_12" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_12'>
                            </table>
                            <br />

                            <li class="text-light-blue">É Claro UP?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_13" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" InitialValue="" ControlToValidate="rbQuestao_13" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_13" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_13" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_13'>
                            </table>
                            <br />

                            <li class="text-light-blue">É Seguro Proteção Móvel?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_14" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" InitialValue="" ControlToValidate="rbQuestao_14" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_14" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_14" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_14'>
                            </table>
                            <br />

                            <li class="text-light-blue">Contrato objeto da petição é do autor?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_15" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" InitialValue="" ControlToValidate="rbQuestao_15" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_15" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_15" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_15'>
                            </table>
                            <br />

                            <li class="text-light-blue">Possui outros contratos em seu CPF/CNPJ?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_16" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" InitialValue="" ControlToValidate="rbQuestao_16" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_16" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_16" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_16'>
                            </table>
                            <br />

                            <li class="text-light-blue">Possui fatura(s) paga(s) e não contestadas?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_17" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" InitialValue="" ControlToValidate="rbQuestao_17" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_17" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_17" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_17'>
                            </table>
                            <br />

                            <li class="text-light-blue">O problema objeto da petição foi resolvido?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_18" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" InitialValue="" ControlToValidate="rbQuestao_18" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_18" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_18" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_18'>
                            </table>
                            <br />
                            <li class="text-light-blue">Considerações finais</li>
                            <asp:TextBox ID="txtConsideracoesFinais" runat="server" TextMode="MultiLine" Height="100px" Width="100%"></asp:TextBox>
                            <br />
                            <br />

                            <li class="text-light-blue">Telas Adicionais</li>
                            <asp:TextBox ID="printQuestao_20" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_20" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_20'>
                            </table>
                            <br />
                            <br />

                            <div class="box-header">
                                <h4 class="box-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true" class>
                                        <h2 class="text-primary" style="text-align: center;"><strong>Questionário</strong></h2>
                                    </a>
                                </h4>
                            </div>

                            <div id="collapseOne" class="panel-collapse collapse in" aria-expanded="true">
                                <div class="box-body">

                                    <uc4:UserControlExecQuestao1 runat="server" ID="UserControlExecQuestao1" />

                                    <uc1:UserControlQuestao3_4 runat="server" ID="UserControlQuestao3_4" />

                                    <uc4:UserControlQuestao5 runat="server" ID="UserControlQuestao5" />

                                    <uc4:UserControlQuestao6 runat="server" ID="UserControlQuestao6" />

                                    <uc4:UserControlQuestao7 runat="server" ID="UserControlQuestao7" />
                                   
                                    <uc1:UserControlQuestao11 runat="server" ID="UserControlQuestao11" />

                                    <uc1:UserControlQuestao12 runat="server" ID="UserControlQuestao12" />

                                    <uc1:UserControlQuestao14 runat="server" ID="UserControlQuestao14" />

                                    <uc1:UserControlOcorrenciaNet runat="server" ID="UserControlOcorrenciaNet" />

                                </div>
                            </div>
                        </ol>


                        <div class="box-footer">
                            <asp:UpdatePanel ID="upSalvar" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                <asp:LinkButton ID="btnSalvar" ToolTip="Salva as informações parcialmente" CausesValidation="false" runat="server" CssClass="btn btn-danger" OnClick="btnSalvar_Click"><i class="fa fa-save"></i> Salvar Parcial</asp:LinkButton>

                                    <asp:LinkButton ToolTip="Salva o formulário para a conclusão" Style="float: right;" ID="btnConcluir" runat="server" CssClass="btn btn-primary" OnClick="btnConcluir_Click"><i class="fa fa-check"></i> Salvar e Concluir</asp:LinkButton>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </div>
                    </div>
                </div>
            </div>
        </section>
        <uc1:UserControlUpdateProgress runat="server" ID="UserControlUpdateProgress" />
        <uc1:UserControlShowImage runat="server" ID="UserControlShowImage" />
    </form>
</body>
</html>
