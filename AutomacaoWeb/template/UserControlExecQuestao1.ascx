<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlExecQuestao1.ascx.cs" Inherits="AutomacaoWeb.template.UserControlExecQuestao1" %>

<asp:Panel ID="pPrincipal1" runat="server">
    <h4 class="text-primary" style="text-align: center;"><strong>FORMULÁRIO DE SOLICITAÇÃO</strong></h4>
    <asp:HiddenField ID="hfId" runat="server" ClientIDMode="Static" />

    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>1 – INFORMAÇÕES BÁSICAS / NECESSÁRIAS</strong></h5>
        </legend>
        <div id="dvEstado" runat="server" class="row">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">UF: </asp:Label>
            </div>
            <asp:UpdatePanel runat="server" ID="upEstado">
                <ContentTemplate>
                    <div class="col-sm-9" style="padding: 2px">
                        <asp:DropDownList OnSelectedIndexChanged="estado_SelectedIndexChanged" AutoPostBack="True" ID="drpEstado" runat="Server" Width="120px">
                        </asp:DropDownList>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div id="dvCidade" runat="server" class="row">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue" for="drpCidDomicilio">
                                    Cidade Domícilio:
                </asp:Label>
            </div>
            <asp:UpdatePanel runat="server" ID="upCidade">
                <ContentTemplate>
                    <div class="col-sm-9" style="padding: 2px">
                        <asp:DropDownList ID="drpCidDomicilio" runat="Server">
                        </asp:DropDownList>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
        <div id="dvMsisdn" runat="server" class="row">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue" for="txtTelefone">
                                    MSISDN / NTC:
                </asp:Label>

            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtTelefone" runat="server" Width="120px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfTel" runat="server" InitialValue="" ControlToValidate="txtTelefone" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                <label>
                    <asp:CheckBox ID="chkCliente" runat="server" />
                    <span class="label-text">Não é cliente</span>
                </label>
            </div>
        </div>
    </fieldset>

</asp:Panel>
