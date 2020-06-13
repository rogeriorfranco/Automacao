<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlHeader.ascx.cs" Inherits="AutomacaoWeb.template.UserControlHeader" %>

<address>
    <label class="text-light-blue">Nome Do Cliente: </label>
    <asp:Label ID="lblCliente" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue">CPF/CNPJ: </label>
    <asp:Label ID="lblCPF" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue" style="padding-right: 20px;">N° da Linha: </label>
    <asp:TextBox ID="txtNroLinha" runat="server"></asp:TextBox>
    <br />
    <label class="text-light-blue">N° do Contrato: </label>
    <asp:TextBox ID="txtNroContrato" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvtxtNroContrato" runat="server" InitialValue="" ControlToValidate="txtNroContrato" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
    <br />
    <label class="text-light-blue">N° do Processo: </label>
    <asp:Label ID="lblNroProcesso" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue">Resumo da Reclamação: </label>
    <asp:Label ID="lblResumoReclamacao" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue">Reclamação do Cliente: </label>
    <asp:Label ID="lblReclamacaoCliente" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue">Observações: </label>
    <asp:Label ID="lblObs" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue">Escritório: </label>
    <asp:Label ID="lblEscritorio" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue">Data Audiência: </label>
    <asp:Label ID="lblDtAudiencia" runat="server"></asp:Label>
    <br />
    <label class="text-light-blue">Valor Requerido: </label>
    <asp:Label ID="lblValorRequerido" runat="server"></asp:Label>
    <br />
</address>
