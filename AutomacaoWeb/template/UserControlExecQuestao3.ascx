<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlExecQuestao3.ascx.cs" Inherits="AutomacaoWeb.template.UserControlExecQuestao3" %>

<h4 class="text-primary" style="text-align: center;"><strong>FORMULÁRIO DE CUMPRIMENTO</strong></h4>

<fieldset style="text-align: left; margin: 15px;">
    <legend>
        <h5 class="text-primary" style="text-align: left;"><strong>3 – EXECUÇÃO DO CUMPRIMENTO</strong></h5>
    </legend>
    <div class="row">
        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue" for="txtdetalheExec">
                                            Detalhamento da execução do cumprimento:
            </asp:Label>
        </div>
        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtdetalheExec" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfDet" runat="server" InitialValue="" ControlToValidate="txtdetalheExec" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
        </div>

        <div id="respDescID" runat="server">

            <div id="respDescLblID" class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue" for="drprespDescumprimento">
                                            Responsável pelo descumprimento?
                </asp:Label>
            </div>
            <div id="respDescDdlID" class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="drprespDescumprimento" runat="Server">
                    <asp:ListItem Text="<< Selecione >>" Value="0" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfRespDesc" runat="server" InitialValue="0" ControlToValidate="drprespDescumprimento" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue" for="drpPendenteCom">
                                            Pendente com:
            </asp:Label>
        </div>
        <div class="col-sm-9" style="padding: 2px">

            <asp:ListBox ID="pendenteID" runat="server" SelectionMode="Multiple" Width="500px"></asp:ListBox>
        </div>
    </div>
</fieldset>

<%--<div id="dvReabertura" runat="server" visible="true">
                <fieldset style="text-align: left; margin: 15px;">
                    <legend>
                        <h5 class="text-primary" style="text-align: left;"><strong>4 – RESPOSTA MÁ QUALIDADE</strong></h5>
                    </legend>
                    <div class="row">
                        <div class="col-sm-3" style="text-align: right; padding: 2px">
                            <asp:Label runat="server" class="text-light-blue">Resposta de Má Qualidade:</asp:Label>
                        </div>

                        <div class="col-sm-9" style="padding: 2px">
                            <asp:TextBox ID="txtRespostaMaQualidade" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvRespostaMaQualidade" runat="server" InitialValue="" ControlToValidate="txtRespostaMaQualidade" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        </div>

                        <div class="col-sm-3" style="text-align: right; padding: 2px">
                            <asp:Label runat="server" class="text-light-blue">Classificação de Má Qualidade:</asp:Label>
                        </div>

                        <div class="col-sm-9" style="padding: 2px">
                            <asp:DropDownList ID="ddlClassificacaoMaQualidade" runat="Server">
                                <asp:ListItem Text="<< Selecione >>" Value="0" />
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvClassificacaoMaQualidade" runat="server" InitialValue="0" ControlToValidate="ddlClassificacaoMaQualidade" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </fieldset>

                <fieldset style="text-align: left; margin: 15px;">
                    <legend>
                        <h5 class="text-primary" style="text-align: left;"><strong>5 – DESCRIÇÃO DA REANÁLISE DO CASO</strong></h5>
                    </legend>
                    <div class="row">
                        <div class="col-sm-3" style="text-align: right; padding: 2px">
                            <asp:Label runat="server" class="text-light-blue">Descrição do Supervisor:</asp:Label>
                        </div>

                        <div class="col-sm-9" style="padding: 2px">
                            <asp:TextBox ID="txtDescricaoSupervisor" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvDescricaoSupervisor" runat="server" InitialValue="" ControlToValidate="txtDescricaoSupervisor" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        </div>

                        <div class="col-sm-3" style="text-align: right; padding: 2px">
                            <asp:Label runat="server" class="text-light-blue">Classificação de Má Qualidade(Supervisor):</asp:Label>
                        </div>

                        <div class="col-sm-9" style="padding: 2px">
                            <asp:DropDownList ID="ddlClassificacaoMaQualidadeSupervisor" runat="Server">
                                <asp:ListItem Text="<< Selecione >>" Value="0" />
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="rfvddlClassificacaoMaQualidadeSupervisor" runat="server" InitialValue="0" ControlToValidate="ddlClassificacaoMaQualidadeSupervisor" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </fieldset>

                <fieldset style="text-align: left; margin: 15px;">
                    <legend>
                        <h5 class="text-primary" style="text-align: left;"><strong>6 – SOLICITAÇÕES</strong></h5>
                    </legend>
                    <div class="row">

                        <div class="col-sm-3" style="text-align: right; padding: 2px">
                            <asp:Label runat="server" class="text-light-blue">
                                        Este cliente passou em algum Canal Crítico?
                            </asp:Label>
                        </div>
                        <div class="col-sm-9" style="padding: 2px">
                            <asp:RadioButtonList ID="rbSolicitacaoAtendida" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal" ClientIDMode="Static">
                                <asp:ListItem class="radio-inline" Value="1">Sim</asp:ListItem>
                                <asp:ListItem class="radio-inline" Value="0">Não</asp:ListItem>
                            </asp:RadioButtonList>
                            <asp:RequiredFieldValidator ID="rfSolicitacaoAtendida" runat="server" InitialValue="" ControlToValidate="rbSolicitacaoAtendida" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        </div>


                        <div class="col-sm-3" style="text-align: right; padding: 2px">
                            <asp:Label runat="server" class="text-light-blue">Solicitações foram atendidas:</asp:Label>
                        </div>

                        <div class="col-sm-9" style="padding: 2px">
                            <asp:TextBox ID="txtSolicitacoesAtendidas" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvtxtSolicitacoesAtendidas" runat="server" InitialValue="" ControlToValidate="txtSolicitacoesAtendidas" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </fieldset>
            </div>--%>
