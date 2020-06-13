<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao7.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao7" %>

<asp:Panel runat="server" ID="pQ7">
    <fieldset style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>7 – CONCLUSÃO DO SUPORTE AO JURÍDICO SOBRE A RECLAMAÇÃO</strong></h5>
        </legend>

        <div id="dvAcao" runat="server">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <br />
                <br />
                <asp:Label runat="server" class="text-light-blue">
                                        Ações Executadas Pró Ativamente:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <label>
                    <asp:CheckBox ID="cbExclusaoNegaticao" runat="server" />
                    <span class="label-text">Execução da Negativação</span>
                </label>
                <br />
                <label>
                    <asp:CheckBox ID="cbCorrecaoCobrancaIndevida" runat="server" />
                    <span class="label-text">Correção Cobrança Indevida</span>
                </label>
                <br />
                <label>
                    <asp:CheckBox ID="cbCancelamentoIsencao" runat="server" />
                    <span class="label-text">Cancelamento e Isenção de Agregadores</span>
                </label>
                <br />
                <label>
                    <asp:CheckBox ID="cbCancelamentoCobranca" runat="server" />
                    <span class="label-text">Cancelamento de Cobrança/Pro-Rata</span>
                </label>
            </div>
        </div>

        <div class="col-sm-3" style="text-align: right; padding: 2px">
            <asp:Label runat="server" class="text-light-blue">
                                        Reclamação do Cliente:
            </asp:Label>
        </div>
        <div class="col-sm-9" style="padding: 2px">
            <asp:DropDownList ID="ddlReclamacao" runat="server" Width="200px">
                <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                <asp:ListItem Text="Procedente" Value="1" />
                <asp:ListItem Text="Improcedente" Value="2" />
                <asp:ListItem Text="Improcedente sem Provas" Value="3" />
            </asp:DropDownList>
            <asp:RequiredFieldValidator ID="rfReclamacao" runat="server" InitialValue="0" ControlToValidate="ddlReclamacao" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
        </div>

        <div id="dvPendente" runat="server">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Pendente com:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:ListBox ID="lbPendente" runat="server" SelectionMode="Multiple" Width="500px"></asp:ListBox>
            </div>
        </div>

        <div id="dvParceiro" runat="server">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Parceiro Ofensor:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="ddlParceiroOfensor" runat="server" Width="500px"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfParcOf" runat="server" InitialValue="0" ControlToValidate="ddlParceiroOfensor" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div id="dvConsideracoes" runat="server">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        <br />
                                        <br />
                                        Considerações Finais:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtConsideracoesFinais" runat="server" TextMode="MultiLine" Height="100px" Width="85%"></asp:TextBox>
            </div>
        </div>

        <div id="dvSolucao" runat="server">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        <br />
                                        Solução do problema (relato dos problemas identificados e quais soluções devem ser tomadas):
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:TextBox ID="txtSolucaoProblema" runat="server" TextMode="MultiLine" Height="100px" Width="85%"></asp:TextBox>
            </div>
        </div>

        <div id="dvFechamento" runat="server">
            <div class="col-sm-3" style="text-align: right; padding: 2px">
                <asp:Label runat="server" class="text-light-blue">
                                        Fechamento:
                </asp:Label>
            </div>
            <div class="col-sm-9" style="padding: 2px">
                <asp:DropDownList ID="ddlFechamento" runat="server" Width="400px">
                    <asp:ListItem Selected="True" Text="<< Selecione >>" Value="0" />
                    <asp:ListItem Text="Empresa divergente" Value="1" />
                    <asp:ListItem Text="Falta da inicial (Subsídio) / Sentença (Liminar / Cumprimento)" Value="2" />
                    <asp:ListItem Text="Inicial/Sentença divergente do cadastro no IW" Value="3" />
                    <asp:ListItem Text="Processo não cadastrado no EBTJuris" Value="4" />
                    <asp:ListItem Text="Sem resposta do escritório após 24 horas" Value="5" />
                    <asp:ListItem Text="Tipo de demanda divergente (subsídio x cumprimento)" Value="6" />
                    <asp:ListItem Text="Tratado" Value="7" />
                </asp:DropDownList>
                <asp:RequiredFieldValidator ID="rfFechamento" runat="server" InitialValue="0" ControlToValidate="ddlFechamento" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

        </div>
    </fieldset>
</asp:panel>


