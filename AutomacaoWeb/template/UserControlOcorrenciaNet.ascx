<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlOcorrenciaNet.ascx.cs" Inherits="AutomacaoWeb.template.UserControlOcorrenciaNet" %>

<fieldset style="text-align: left; margin: 15px;">
    <legend>
        <h5 class="text-primary" style="text-align: left;"><strong>Observação Ocorrência/Memo NETSMS / MOBILE</strong></h5>
    </legend>
    <div class="row">
        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Descrição:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtDescricao" runat="server" TextMode="MultiLine" Height="100px" Width="80%"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvtxtDescricao" runat="server" InitialValue="" ControlToValidate="txtDescricao" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
        </div>

    </div>
</fieldset>
