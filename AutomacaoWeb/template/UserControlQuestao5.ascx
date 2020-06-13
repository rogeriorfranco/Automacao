<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao5.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao5" %>

<asp:Panel ID="pPrincipal5" runat="server">
    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>5 – INFORMAÇÕES DO ACORDO PRÉVIO</strong></h5>
        </legend>
        <div class='row'>
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                    Data e horário da primeira tentativa:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtDataHorario1" runat="server" Width="120px"></asp:TextBox>
                <asp:TextBox ID="txtHora1" runat="server" Width="120px" PlaceHolder="00:00"></asp:TextBox>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                    Valor Proposta:
                </asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtValorProposta1" runat="server" Width="120px"></asp:TextBox>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">Comentário:</asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtComentario1" runat="server" TextMode="MultiLine" Height="100px" Width="85%"></asp:TextBox>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                    Data e horário da segunda tentativa:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtDataHorario2" runat="server" Width="120px"></asp:TextBox>
                <asp:TextBox ID="txtHora2" runat="server" Width="120px" PlaceHolder="00:00"></asp:TextBox>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                    Valor Proposta:
                </asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtValorProposta2" runat="server" Width="120px"></asp:TextBox>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">Comentário:</asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtComentario2" runat="server" TextMode="MultiLine" Height="100px" Width="85%"></asp:TextBox>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                    Data e horário da terceira tentativa:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtDataHorario3" runat="server" Width="120px"></asp:TextBox>
                <asp:TextBox ID="txtHora3" runat="server" Width="120px" PlaceHolder="00:00"></asp:TextBox>
            </div>
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                    Valor Proposta:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtValorProposta3" runat="server" Width="120px"></asp:TextBox>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                        Houve acordo Prévio:
                </asp:Label>
            </div>

            <div class="col-sm-9" style="padding: 2px">
                <asp:RadioButtonList ID="rbAcordoPrevio" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal" ClientIDMode="Static">
                    <asp:ListItem class="radio-inline" Value="1">Sim</asp:ListItem>
                    <asp:ListItem class="radio-inline" Value="0">Não</asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div id="dvAcordoPrevio" runat="server" style="display: none">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label ID="lblAcordoPrevio" runat="server" class="text-light-blue"></asp:Label>
                </div>

                <div class="col-sm-9" style="padding: 2px">
                    <asp:TextBox ID="txtValorPropostaAcordo" AutoPostBack="false" runat="server" Width="120px"></asp:TextBox>
<%--                    <asp:RequiredFieldValidator ID="rfPropostaAcordo" runat="server" InitialValue="R$ 0,00" ControlToValidate="txtValorPropostaAcordo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>--%>
                </div>
            </div>

            <div id="reclClienteID" runat="server" style="display: none">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">
                    Reclamação do Cliente:
                    </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:DropDownList ID="ddlReclamacaoCliente" AutoPostBack="false" runat="server" Width="300px"></asp:DropDownList>
                    <%--<asp:RequiredFieldValidator ID="rfReclamacaoCliente" runat="server" InitialValue="0" ControlToValidate="ddlReclamacaoCliente" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>--%>
                </div>
            </div>

            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                        Comentário:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtComentario3" runat="server" TextMode="MultiLine" Height="100px" Width="85%"></asp:TextBox>
            </div>
        </div>
    </fieldset>
</asp:Panel>
