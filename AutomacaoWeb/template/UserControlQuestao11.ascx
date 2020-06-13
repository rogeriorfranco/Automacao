<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao11.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao11" %>

<asp:Panel ID="pPrincipal11" runat="server" visible="false">
    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong><asp:Label ID="lblNroTitulo" runat="server"></asp:Label> – RESPOSTA MÁ QUALIDADE</strong></h5>
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
                    <asp:ListItem>Confirmada</asp:ListItem>
                    <asp:ListItem>Não confirmada</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvClassificacaoMaQualidade" runat="server" InitialValue="0" ControlToValidate="ddlClassificacaoMaQualidade" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
        </div>
    </fieldset>
</asp:Panel>