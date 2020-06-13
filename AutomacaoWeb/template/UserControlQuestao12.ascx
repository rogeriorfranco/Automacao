<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao12.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao12" %>

<asp:Panel ID="pPrincipal12" runat="server" visible="false">
    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>12 – DESCRIÇÃO DA REANÁLISE DO CASO</strong></h5>
        </legend>
        <div class="row">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">Descrição da reanálise do caso:</asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtDescricaoReanalise" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDescricaoReanalise" runat="server" InitialValue="" ControlToValidate="txtDescricaoReanalise" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">Descrição do supervisor:</asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtDescricaoSupervisor" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDescricaoSupervisor" runat="server" InitialValue="" ControlToValidate="txtDescricaoSupervisor" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">Classificação de Má Qualidade(Supervisor):</asp:Label>
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