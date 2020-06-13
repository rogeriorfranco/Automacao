<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao6.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao6" %>
<link href="../content/bootstrap-select.min.css" rel="stylesheet" />
<script src="../scripts/bootstrap-select.min.js"></script>
<asp:Panel ID="pPrincipal6" runat="server">
    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>6 – INFORMAÇÕES DA ÁREA OFENSORA</strong></h5>
        </legend>
        <div class='row'>
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Centro de Custo:
                </asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="ddlCentroCusto" runat="server" Width="300px" class="selectpicker" data-live-search-style="begins" data-live-search="true"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfCentroCusto" runat="server" InitialValue="0" ControlToValidate="ddlCentroCusto" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>


            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Área Causadora:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">

                <asp:UpdatePanel ID="upQst6AreaCausadora" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlAreaCausadora" runat="server" Width="300px" AutoPostBack="true"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfAreaCaus" runat="server" InitialValue="0" ControlToValidate="ddlAreaCausadora" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>


            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Motivo:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:UpdatePanel ID="upQst6Motivo" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlMotivo" runat="server" Width="300px" AutoPostBack="true"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfMotivo" runat="server" InitialValue="0" ControlToValidate="ddlMotivo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Submotivo:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:UpdatePanel ID="upQst6SubMotivo" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <asp:DropDownList ID="ddlSubMotivo" runat="server" Width="400px" AutoPostBack="false"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfSubMotivo" runat="server" InitialValue="0" ControlToValidate="ddlSubMotivo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Qual o mês em que o problema ocorreu?
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="ddlMes" runat="server" Width="150px" AutoPostBack="false">
                    <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                    <asp:ListItem Text="Janeiro" Value="1" />
                    <asp:ListItem Text="Fevereiro" Value="2" />
                    <asp:ListItem Text="Março" Value="3" />
                    <asp:ListItem Text="Abril" Value="4" />
                    <asp:ListItem Text="Maio" Value="5" />
                    <asp:ListItem Text="Junho" Value="6" />
                    <asp:ListItem Text="Julho" Value="7" />
                    <asp:ListItem Text="Agosto" Value="8" />
                    <asp:ListItem Text="Setembro" Value="9" />
                    <asp:ListItem Text="Outubro" Value="10" />
                    <asp:ListItem Text="Novembro" Value="11" />
                    <asp:ListItem Text="Dezembro" Value="12" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfMes" runat="server" InitialValue="0" ControlToValidate="ddlMes" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Qual o ano em que o problema ocorreu?
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="ddlAno" runat="server" Width="150px" AutoPostBack="false"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfAno" runat="server" InitialValue="0" ControlToValidate="ddlAno" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Percurso de Cobrança está suspenso?
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="ddlPercursoCobranca" runat="server" Width="150px" AutoPostBack="false">
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfPercursoCobranca" runat="server" InitialValue="0" ControlToValidate="ddlPercursoCobranca" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Este cliente passou em algum Canal Crítico?
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:RadioButtonList ID="rbCanaisCriticos" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal" ClientIDMode="Static">
                    <asp:ListItem class="radio-inline" Value="1">Sim</asp:ListItem>
                    <asp:ListItem class="radio-inline" Value="0">Não</asp:ListItem>
                </asp:RadioButtonList>
                <asp:RequiredFieldValidator ID="rfCanaisCriticos" runat="server" InitialValue="" ControlToValidate="rbCanaisCriticos" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>


            <div id="CanalManifestoID" style="display: none" runat="server">

                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">
                                        Qual canal?
                    </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:DropDownList ID="ddlCanal" runat="server" Width="150px" AutoPostBack="false">
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="rfCanal" runat="server" InitialValue="0" ControlToValidate="ddlCanal" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">
                                        Qual o número de protocolo / manifesto?
                    </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:TextBox ID="txtProtocoloManifesto" runat="server" Width="120px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfProtocoloManifesto" runat="server" InitialValue="" ControlToValidate="txtProtocoloManifesto" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>

            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                        <br />
                        <br />
                                        Memorando de Atendimento e Protocolos sobre objeto de ação:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtMemorandoAtendimento" runat="server" TextMode="MultiLine" Height="100px" Width="85%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfMemorando" runat="server" InitialValue="" ControlToValidate="txtMemorandoAtendimento" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Nº da Conta:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtNumeroConta" runat="server" Width="120px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfNumeroConta" runat="server" InitialValue="" ControlToValidate="txtNumeroConta" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

        </div>
    </fieldset>
</asp:Panel>
