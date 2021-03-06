﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao14.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao14" %>
<asp:Panel ID="pPrincipal14" runat="server"  visible="false">
    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>14 – RESPOSTA DA SOLICITAÇÃO DE ATUALIZAÇÃO</strong></h5>
        </legend>
        <div class="row">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">Resposta da Solicitação de Atualização:</asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtDescricaoReanalise" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDescricaoReanalise" runat="server" InitialValue="" ControlToValidate="txtDescricaoReanalise" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
        </div>
    </fieldset>
</asp:Panel>
