<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlFormularioAcordo.ascx.cs" Inherits="AutomacaoWeb.template.UserControlFormularioAcordo" %>

<h4 class="text-primary" style="text-align: center;"><strong>FORMULÁRIO DE ACORDO</strong></h4>
<asp:HiddenField ID="hfId" runat="server" ClientIDMode="Static" />

<fieldset style="text-align: left; margin: 15px;">
    <div class="row">
        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue"> Data acordo:</asp:Label>
        </div>
        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtDtAcordo" runat="server" placeholder="Data"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Mês:</asp:Label>
        </div>
        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtMesAno" runat="server"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue" for="txtCenario">Cenário:</asp:Label>
        </div>
        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtCenario" runat="server" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Data da última ação:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtDataUltimaAcaoFA" runat="server" placeholder="Data" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Motivo do processo:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:DropDownList ID="ddlMotivoProcesso" runat="server" AutoPostBack="false" Width="400px">
                <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                <asp:ListItem Text="Anormalidade de rede 3G" Value="1" />
                <asp:ListItem Text="Atendimento SAC" Value="2" />
                <asp:ListItem Text="Atendimento técnico" Value="3" />
                <asp:ListItem Text="Cancelamento" Value="4" />
                <asp:ListItem Text="Cobrança" Value="5" />
                <asp:ListItem Text="Cobrança indevida" Value="6" />
                <asp:ListItem Text="Falha sistêmica" Value="7" />
                <asp:ListItem Text="Fraude" Value="8" />
                <asp:ListItem Text="Negativação" Value="9" />
                <asp:ListItem Text="Portabilidade" Value="10" />
                <asp:ListItem Text="Problema sinal" Value="11" />
                <asp:ListItem Text="Problemas com atendimento" Value="12" />
                <asp:ListItem Text="Problemas técnicos" Value="13" />
                <asp:ListItem Text="Produtos e serviços" Value="14" />
                <asp:ListItem Text="Reclamação - 3G" Value="15" />
                <asp:ListItem Text="Serviços de entretenimento / agregadores" Value="16" />
                <asp:ListItem Text="Suporte técnico reparos" Value="17" />
                <asp:ListItem Text="Vendas" Value="18" />
            </asp:DropDownList>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Fechamento:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:DropDownList ID="ddlFechamento" runat="server" AutoPostBack="false" Width="500px">
                <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                <asp:ListItem Text="Sub Devolvido" Value="1" />
                <asp:ListItem Text="Não aceitou acordo devido a alçada" Value="2" />
                <asp:ListItem Text="Não aceitou acordo, pois deseja aguardar a audiência" Value="3" />
                <asp:ListItem Text="Não se interessou em ouvir a proposta" Value="4" />
                <asp:ListItem Text="Não foi possível contato com autor/advogado (Não Atende)" Value="5" />
                <asp:ListItem Text="CNão foi possível contato com autor/advogado (Mensg. Op. Local/ Tel não encontrado)" Value="6" />
                <asp:ListItem Text="Reclamação Improcedente" Value="7" />
                <asp:ListItem Text="Serviço/produto/motivo fora do escopo da Solução Antecipada" Value="8" />
                <asp:ListItem Text="Audiência < 20 dias" Value="9" />
                <asp:ListItem Text="Autor do processo não é o titular" Value="10" />
                <asp:ListItem Text="Acordo realizado" Value="11" />
            </asp:DropDownList>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Valor solicitado pelo autor:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtValorSolicitadoFA" runat="server" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue" for="txtValorAlcada">Valor Alçada:
            </asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtValorAlcadaFA" runat="server" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Valor acordo realizado danos morais:
            </asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtAcordoRealizadoMoralFA" runat="server" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Valor acordo realizado danos materiais:
            </asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtAcordoRealizadoMaterialFA" runat="server" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Valor acordo realizado Obrigação de fazer:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtAcordoRealizadoObricacaoFA" runat="server" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Contato com:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:DropDownList ID="ddlContatoCom" runat="server" Width="155px" AutoPostBack="false">
                <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                <asp:ListItem Text="Autor / Cliente" Value="1" />
                <asp:ListItem Text="Advogado" Value="2" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfContatoCom" runat="server" InitialValue="0" ControlToValidate="ddlContatoCom" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Email autor / advogado:</asp:Label>
        </div>
        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtEmailAdvogado" runat="server" ClientIDMode="Static" Width="400px"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue" for="txtTelefone">Telefones:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtTelefoneFA" runat="server" ClientIDMode="Static"></asp:TextBox>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Alçada:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:DropDownList ID="ddlAlcada" runat="server" Width="155px" AutoPostBack="false">
                <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                <asp:ListItem Text="1º Nível" Value="1" />
                <asp:ListItem Text="2º Nível" Value="2" />
            </asp:DropDownList>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Crítico:
            </asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:DropDownList ID="ddlCritico" runat="server" AutoPostBack="false" Width="120px">
                <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                <asp:ListItem Text="Sim" Value="1" />
                <asp:ListItem Text="Não" Value="2" />
            </asp:DropDownList>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Estado:
            </asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:DropDownList AutoPostBack="false" ID="ddlEstado" runat="Server" Width="120px">
            </asp:DropDownList>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">Data de Nascimento:</asp:Label>
        </div>

        <div class="col-sm-9" style="padding: 2px">
            <asp:TextBox ID="txtDataNascimentoFA" runat="server" placeholder="Data" ClientIDMode="Static" MaxLength="10"></asp:TextBox>
        </div>
    </div>
</fieldset>
