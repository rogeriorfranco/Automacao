<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao10.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao10" %>
<asp:Panel ID="pPrincipal10" runat="server" Visible="false">
    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>10 – DETALHAMENTO DA MÁ QUALIDADE - Histórico</strong></h5>
        </legend>
        <div class="row">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">Motivo:</asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="ddlMotivo" runat="Server">
                    <asp:ListItem Text="<< Selecione >>" Value="0" />
                    <asp:ListItem>Área Causadora Divergente</asp:ListItem>
                    <asp:ListItem>Centro de Custo Divergente</asp:ListItem>
                    <asp:ListItem>Considerações Divergentes (detalhar no campo "Detalhes")</asp:ListItem>
                    <asp:ListItem>Considerações Inconclusivas (detalhar no campo "Detalhes")</asp:ListItem>
                    <asp:ListItem>Formulário Anexado Diverso</asp:ListItem>
                    <asp:ListItem>Formulário Não Foi Anexado</asp:ListItem>
                    <asp:ListItem>Formulário Sem Tratamento</asp:ListItem>
                    <asp:ListItem>Improcedente Indevido (detalhar no campo "Detalhes")</asp:ListItem>
                    <asp:ListItem>Motivo e Sub-motivo Divergentes</asp:ListItem>
                    <asp:ListItem>Procedente Indevido (detalhar no campo "Detalhes")</asp:ListItem>
                    <asp:ListItem>Sem Área Causadora</asp:ListItem>
                    <asp:ListItem>Sem Centro de Custos</asp:ListItem>
                    <asp:ListItem>Sem Motivo e Sub-motivo</asp:ListItem>
                    <asp:ListItem>Sol Anterior Não Atendida (detalhar no campo "Detalhes")</asp:ListItem>
                    <asp:ListItem>Sub Tratado Linha Diver Inf (detalhar no campo "Detalhes")</asp:ListItem>
                    <asp:ListItem>Subsídio Incompleto (detalhar no campo "Detalhes")</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfvMotivo" runat="server" InitialValue="0" ControlToValidate="ddlMotivo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
        </div>
    </fieldset>
</asp:Panel>
