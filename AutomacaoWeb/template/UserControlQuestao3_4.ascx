<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControlQuestao3_4.ascx.cs" Inherits="AutomacaoWeb.template.UserControlQuestao3_4" %>

<asp:Panel ID="pPrincipal3" runat="server">
    <asp:UpdatePanel ID="upq3" runat="server" UpdateMode="Conditional">
        <ContentTemplate>
            <fieldset style="text-align: left; margin: 15px;">
                <legend>
                    <h5 class="text-primary" style="text-align: left;"><strong>3 – INFORMAÇÕES DO MOTIVO DE CONTESTAÇÃO</strong></h5>
                </legend>
                <div class="row">
                    <div class="col-sm-3" style="text-align: right; padding: 2px">
                        <asp:Label runat="server" class="text-light-blue" for="ddlMotivo">
                                            Motivo:
                        </asp:Label>
                    </div>
                    <div class="col-sm-9" style="padding: 2px">
                        <asp:DropDownList ID="ddlMotivo" runat="server" Width="400px" AutoPostBack="true"></asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfMotivo" runat="server" InitialValue="0" ControlToValidate="ddlMotivo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </fieldset>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="ddlMotivo" EventName="SelectedIndexChanged" />
        </Triggers>
    </asp:UpdatePanel>
</asp:Panel>

<br />
<asp:Panel ID="pPrincipal4" runat="server">
    <fieldset id="fs4" style="text-align: left; margin: 15px;">
        <legend>
            <h5 class="text-primary" style="text-align: left;"><strong>4 – INFORMAÇÕES NECESSÁRIAS PARA ELABORAÇÃO DE DEFESA (Assinalar a opção desejada)</strong></h5>
        </legend>
        <div id="dvHistoricoClienteCampos" class="row">
            <div class="row-title">
                Histórico Cliente
            </div>
            <div id="dvHistoricoClienteCampo_Data">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue" for="txtDataInstalacao">
                                            Data da instalação/habilitação do produto:
                    </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:TextBox ID="txtDataInstalacao" runat="server" Width="120px"></asp:TextBox>
                </div>
            </div>
            <div id="dvHistoricoClienteCampo_Token">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Há token de aceite eletrônico ou transação do chat?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbToken" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbToken" runat="server" InitialValue="" ControlToValidate="rbToken" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvHistoricoClienteCampo_ContratoPeticao">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue" for="rbContratoPeticaoAutor">
                                            Contrato objeto da petição é do autor?
                    </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbContratoPeticaoAutor" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                </div>

            </div>
            <div id="dvHistoricoClienteCampo_Gravacao">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue" for="rbGravacao">
                                            Há gravação relacionada a serviços adicionais?
                    </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbGravacao" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
            <div id="dvmultaContratualCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Possui multa contratual?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbMultaContratual" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbMultaContratual" runat="server" InitialValue="" ControlToValidate="rbMultaContratual" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvprobQuebSigCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Houve problema relacionado à quebra de sigilo?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbQuebraSigilo" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbQuebraSigilo" runat="server" InitialValue="" ControlToValidate="rbQuebraSigilo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvgravacaoFavoravelCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Gravação é favorável a empresa?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbGravacaoFavoravel" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbGravacaoFavoravel" runat="server" InitialValue="" ControlToValidate="rbGravacaoFavoravel" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvBoletimOcorrenciaCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Há boletim de ocorrênca?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px" >
                    <asp:RadioButtonList ID="rbBoletimOcorrencia" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbBoletimOcorrencia" runat="server" InitialValue="" ControlToValidate="rbBoletimOcorrencia" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvRelTecEnvolvidoCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Temos o relato do técnico envolvido?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbRelatoTecEnvolvido" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbRelatoTecEnvolvido" runat="server" InitialValue="" ControlToValidate="rbRelatoTecEnvolvido" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvDanosRessarcidosCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Os danos foram ressarcidos?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbDanosRessarcidos" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbDanosRessarcidos" runat="server" InitialValue="" ControlToValidate="rbDanosRessarcidos" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvLaudoTecnicoCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Temos laudo técnico?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbLaudoTecnico" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbLaudoTecnico" runat="server" InitialValue="" ControlToValidate="rbLaudoTecnico" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvFoiAtropelamentoCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Foi atropelamento?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbFoiAtropelamento" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbFoiAtropelamento" runat="server" InitialValue="" ControlToValidate="rbFoiAtropelamento" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvBatidaAutomovelCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Foi batida de automóvel?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbBatidaAutomovel" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbBatidaAutomovel" runat="server" InitialValue="" ControlToValidate="rbQuebraSigilo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvFrotaDaEmpresaCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">O veículo é da frota da empresa? </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbFrotaDaEmpresa" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbFrotaDaEmpresa" runat="server" InitialValue="" ControlToValidate="rbFrotaDaEmpresa" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvVeicEmpTerceiraCampo">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">O veículo é da empresa terceira?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbVeicEmprTerceira" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbVeicEmprTerceira" runat="server" InitialValue="" ControlToValidate="rbVeicEmprTerceira" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvEmpresaTerceiraCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Qual é a empresa terceira?</asp:Label>
                </div>
                <asp:TextBox ID="txtEmpresaTerceira" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvtxtEmpresaTerceira" runat="server" InitialValue="" ControlToValidate="txtEmpresaTerceira" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div id="dvEmpresaAtivaCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">A parceira terceira encontra-se ativa?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbEmpresaAtiva" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbEmpresaAtiva" runat="server" InitialValue="" ControlToValidate="rbEmpresaAtiva" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvPlacaVeiculoCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">É possível identificar as placas dos veículos envolvidos?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbPlacaVeiculo" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbPlacaVeiculo" runat="server" InitialValue="" ControlToValidate="rbPlacaVeiculo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvAcionamentoSeguro">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Houve acionamento do seguro?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbAcionamentoSeguro" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbAcionamentoSeguro" runat="server" InitialValue="" ControlToValidate="rbAcionamentoSeguro" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvCulpaMotoristaCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue"> Houve culpa do motorista NET/Claro/prestador?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbCulpaMotorista" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbCulpaMotorista" runat="server" InitialValue="" ControlToValidate="rbCulpaMotorista" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvCaboSoltoCampo">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Foi cabo solto em via pública?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbCaboSolto" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbCaboSolto" runat="server" InitialValue="" ControlToValidate="rbCaboSolto" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvFaltaSinalCampo">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Há registro de falta de sinal na região? </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbFaltaSinal" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbFaltaSinal" runat="server" InitialValue="" ControlToValidate="rbFaltaSinal" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvInfraPredialCampo">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Foi Infraestrutura Predial?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbInfraPredial" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbInfraPredial" runat="server" InitialValue="" ControlToValidate="rbInfraPredial" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvInfraDoGrupoCampo">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Foi infraestrutura do grupo?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbInfraDoGrupo" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbInfraDoGrupo" runat="server" InitialValue="" ControlToValidate="rbInfraDoGrupo" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvInfraEmpresaTerceiraCampo">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Foi infraestrutura de empresa terceira?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbInfraEmpresaTerceira" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbInfraEmpresaTerceira" runat="server" InitialValue="" ControlToValidate="rbInfraEmpresaTerceira" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div id="dvEmpTerceiraInfra">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Qual é a empresa terceira? </asp:Label>
                </div>
                <asp:TextBox ID="txtEmpTerceiraInfra" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvtxtEmpTerceiraInfra" runat="server" InitialValue="" ControlToValidate="txtEmpTerceiraInfra" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>
            <div id="dvEmpAtivaInfra">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">A parceira terceira encontra-se ativa?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbEmAtivaInfra" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbEmAtivaInfra" runat="server" InitialValue="" ControlToValidate="rbEmAtivaInfra" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <div id="dvnroContratoCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Contrato relacionado ao problema</asp:Label>
                </div>
                <asp:TextBox ID="txtNroContrato" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvtxtNroContrato" runat="server" InitialValue="" ControlToValidate="txtNroContrato" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
            </div>

            <br />
        </div>
        <div id="dvDetalheProblema" class="row">
            <div class="row-title">
                Detalhamento Problema
            </div>
            <div id="dvDetalheProblemaCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue" for="rbFaturaPaga">
                                            Houve erro de terceira prestadora?
                    </asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbTerceiraPrestadora" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
            </div>
        </div>
        <div id="dvCobranca" class="row">
            <div class="row-title">
                Cobrança
            </div>
            <br />
            <div id="dvCobrancaCampos">
                <div class="col-sm-3" style="text-align: right; padding: 2px">
                    <asp:Label runat="server" class="text-light-blue">Possui fatura(s) paga(s) e não contestadas?</asp:Label>
                </div>
                <div class="col-sm-9" style="padding: 2px">
                    <asp:RadioButtonList ID="rbFaturaPaga" runat="server" class="radio" RepeatLayout="Flow" RepeatDirection="Horizontal">
                        <asp:ListItem class="radio-inline" Value="Sim">Sim</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="Nao">Não</asp:ListItem>
                        <asp:ListItem class="radio-inline" Value="N/A">N/A</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="rfvrbFaturaPaga" runat="server" InitialValue="" ControlToValidate="rbFaturaPaga" ErrorMessage="Campo Obrigatório !" CssClass="alert alert-danger" SetFocusOnError="true"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
    </fieldset>
</asp:Panel>
