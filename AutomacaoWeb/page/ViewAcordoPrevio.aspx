<%@ Page Async="true" Language="C#" AutoEventWireup="true" CodeBehind="ViewAcordoPrevio.aspx.cs" Inherits="AutomacaoWeb.page.ViewAcordoPrevio" %>

<%@ Register Src="~/template/UserControlHeader.ascx" TagPrefix="uc1" TagName="UserControlHeader" %>
<%@ Register Src="~/template/UserControlExecQuestao1.ascx" TagPrefix="uc4" TagName="UserControlExecQuestao1" %>
<%@ Register Src="~/template/UserControlQuestao5.ascx" TagPrefix="uc4" TagName="UserControlQuestao5" %>
<%@ Register Src="~/template/UserControlQuestao6.ascx" TagPrefix="uc4" TagName="UserControlQuestao6" %>
<%@ Register Src="~/template/UserControlQuestao7.ascx" TagPrefix="uc4" TagName="UserControlQuestao7" %>
<%@ Register Src="~/template/UserControlFormularioAcordo.ascx" TagPrefix="uc1" TagName="UserControlFormularioAcordo" %>
<%@ Register Src="~/template/UserControlQuestao3_4.ascx" TagPrefix="uc1" TagName="UserControlQuestao3_4" %>
<%@ Register Src="~/template/UserControlUpdateProgress.ascx" TagPrefix="uc1" TagName="UserControlUpdateProgress" %>
<%@ Register Src="~/template/UserControlShowImage.ascx" TagPrefix="uc1" TagName="UserControlShowImage" %>
<%@ Register Src="~/template/UserControlQuestao14.ascx" TagPrefix="uc1" TagName="UserControlQuestao14" %>
<%@ Register Src="~/template/UserControlQuestao11.ascx" TagPrefix="uc1" TagName="UserControlQuestao11" %>
<%@ Register Src="~/template/UserControlQuestao12.ascx" TagPrefix="uc1" TagName="UserControlQuestao12" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Automação</title>
    <link rel="shortcut icon" href="../images/favicon.ico" />
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
    <script src="../scripts/image.js"></script>
    <script src="../scripts/acordoprevio.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <section class="content-header">
            <h1>
                <asp:Label ID="lblTitulo" runat="server" Text="Acordo Prévio"></asp:Label><small><asp:Label ID="lblSubTituloCaso" runat="server"></asp:Label></small>
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

                            <li class="text-light-blue">Existe saldo devedor? (Anexar lista de faturas abertas)</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_1" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" InitialValue="" ControlToValidate="rbQuestao_1" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_1" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_1" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_1'>
                            </table>

                            <br />
                            <ol>
                                <li class="text-light-blue">Existe parcelamento de débito?</li>
                                <div class="pai">
                                    <div class="minhas-colunas">
                                        <asp:RadioButtonList ID="rbQuestao_1_1_0" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                            <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                    <div class="minhas-colunas" style="margin-top: 5px;">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" InitialValue="" ControlToValidate="rbQuestao_1_1_0" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <asp:TextBox ID="printQuestao_1__1" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_1_1" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                                <table id='tbl_printQuestao_1__1'>
                                </table>
                                <br />

                                <li class="text-light-blue">Cliente Negativado?</li>
                                <div class="pai">
                                    <div class="minhas-colunas">
                                        <asp:RadioButtonList ID="rbQuestao_1_2_0" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                            <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                    <div class="minhas-colunas" style="margin-top: 5px;">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" InitialValue="" ControlToValidate="rbQuestao_1_2_0" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <asp:TextBox ID="printQuestao_1__2" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_1_2" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                                <table id='tbl_printQuestao_1__2'>
                                </table>

                                <br />

                                <li class="text-light-blue">Cliente já foi negativado pelo grupo AMX?</li>
                                <div class="pai">
                                    <div class="minhas-colunas">
                                        <asp:RadioButtonList ID="rbQuestao_1_3_0" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                            <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                    <div class="minhas-colunas" style="margin-top: 5px;">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" InitialValue="" ControlToValidate="rbQuestao_1_3_0" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <asp:TextBox ID="printQuestao_1__3" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_1_3" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                                <table id='tbl_printQuestao_1__3'>
                                </table>
                                <br />

                                <li class="text-light-blue">Existe negativação por terceiros anterior a do grupo?</li>
                                <div class="pai">
                                    <div class="minhas-colunas">
                                        <asp:RadioButtonList ID="rbQuestao_1_4_0" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                            <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                            <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                        </asp:RadioButtonList>
                                    </div>
                                    <div class="minhas-colunas" style="margin-top: 5px;">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" InitialValue="" ControlToValidate="rbQuestao_1_4_0" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <asp:TextBox ID="printQuestao_1__4" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                                <asp:TextBox ID="txtObsQuestao_1_4" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                                <table id='tbl_printQuestao_1__4'>
                                </table>
                                <br />
                            </ol>

                            <li class="text-light-blue">PRÉ ANÁLISE e PROTOCOLOS</li>
                            <asp:TextBox ID="txtObsQuestao_2" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_2'>
                            </table>
                            <br />

                            <li class="text-light-blue">Dados do Advogado</li>
                            <asp:TextBox ID="txtObsQuestao_3" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_3'>
                            </table>
                            <br />

                            <li class="text-light-blue">Possui saldo devedor? </li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_4" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" InitialValue="" ControlToValidate="rbQuestao_4" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_4" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_4" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_4'>
                            </table>
                            <br />

                            <li class="text-light-blue">Possui acordo de pagamento?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_5" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" InitialValue="" ControlToValidate="rbQuestao_5" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_5" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_5" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_5'>
                            </table>
                            <br />

                            <li class="text-light-blue">Possui acordo  de pagamento quebrado?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_6" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" InitialValue="" ControlToValidate="rbQuestao_6" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_6" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_6" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_6'>
                            </table>
                            <br />

                           <li class="text-light-blue">Registro EBT JURIS?</li>
                            <div class="pai">
                                <div class="minhas-colunas">
                                    <asp:RadioButtonList ID="rbQuestao_7" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                                        <asp:ListItem class="radio-inline" Value="N/A">Não se Aplica</asp:ListItem>
                                    </asp:RadioButtonList>
                                </div>
                                <div class="minhas-colunas" style="margin-top: 5px;">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" InitialValue="" ControlToValidate="rbQuestao_7" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            <asp:TextBox ID="printQuestao_7" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_7" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_7'>
                            </table>
                            <br />

                            <li class="text-light-blue">ANÁLISE FINAL</li>
                            <asp:TextBox ID="txtConsideracoesFinais" runat="server" TextMode="MultiLine" Height="100px" Width="100%"></asp:TextBox>
                            <br />
                            <br>

                            <li class="text-light-blue">Telas Adicionais</li>
                            <asp:TextBox ID="printQuestao_9" CssClass="printImage" BorderStyle="Dashed" runat="server" TextMode="MultiLine" Height="50px" Width="100%" ClientIDMode="Static" placeholder="Printar Aqui ..."></asp:TextBox>
                            <asp:TextBox ID="txtObsQuestao_9" runat="server" TextMode="MultiLine" Height="50px" Width="100%" placeholder="Observações"></asp:TextBox>

                            <table id='tbl_printQuestao_9'>
                            </table>
                            <br />

                            <div class="box-header">
                                <h4 class="box-title">
                                    <a data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true">
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

                                    <hr />

                                    <uc1:UserControlFormularioAcordo runat="server" ID="UserControlFormularioAcordo" />
                                </div>
                            </div>
                        </ol>
                    </div>

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
        </section>
        <uc1:UserControlUpdateProgress runat="server" ID="UserControlUpdateProgress" />
        <uc1:UserControlShowImage runat="server" ID="UserControlShowImage" />
    </form>
</body>
</html>
