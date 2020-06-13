using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao3_4 : System.Web.UI.UserControl
    {

        static List<MotivoContestacao> listaMotivoContest;
        MotivoContestacao motivo = null;
        protected void Page_Load(object sender, EventArgs ep)
        {

        }

        private void disabilitaCamposReabertura(string status)
        {
            StatusReaberturaBll srBll = new StatusReaberturaBll();

            if (srBll.listAll().Contains(status))
            {
                pPrincipal3.Visible = false;
                pPrincipal4.Visible = false;
            }
            //else
            //{
            //    desabilitaValidador();
            //}
        }

        private int? _motivo;
        public int? Motivo
        {
            get
            {
                return this._motivo;
            }
            set
            {
                this._motivo = value;
                if (value != null)
                    ddlMotivo.SelectedValue = value.ToString();
                else
                    ddlMotivo.SelectedValue = "0";

                // if (this.tipoFormulario == 2)
                carregaMotivoCampos();
            }
        }

        private string _token;
        public string Token
        {
            get
            {
                return this._token;
            }
            set
            {
                this._token = value;
                if (value != null)
                    rbToken.SelectedValue = value;
                else
                    rbToken.SelectedValue = "";
            }
        }

        private string _gravacaoServicoAdicional;
        public string GravacaoServicoAdicional
        {
            get
            {
                return this._gravacaoServicoAdicional;
            }
            set
            {
                this._gravacaoServicoAdicional = value;
                if (value != null)
                    rbGravacao.SelectedValue = value;
                else
                    rbGravacao.SelectedValue = "";
            }
        }

        private string _erroTerceiroPrestadora;
        public string ErroTerceiroPrestadora
        {
            get
            {
                return this._erroTerceiroPrestadora;
            }
            set
            {
                this._erroTerceiroPrestadora = value;
                if (value != null)
                    rbTerceiraPrestadora.SelectedValue = value;
                else
                    rbTerceiraPrestadora.SelectedValue = "";
            }
        }

        private string _faturaPagaNaoContestada;
        public string FaturaPagaNaoContestada
        {
            get
            {
                return this._faturaPagaNaoContestada;
            }
            set
            {
                this._faturaPagaNaoContestada = value;
                if (value != null)
                    rbFaturaPaga.SelectedValue = value;
                else
                    rbFaturaPaga.SelectedValue = "";
            }
        }

        private string _contratoObjetoAutor;
        public string ContratoObjetoAutor
        {
            get
            {
                return this._contratoObjetoAutor;
            }
            set
            {
                this._contratoObjetoAutor = value;
                if (value != null)
                    rbContratoPeticaoAutor.SelectedValue = value;
                else
                    rbContratoPeticaoAutor.SelectedValue = "";
            }
        }

        private DateTime? _dataIntalacao;
        public DateTime? DataIntalacao
        {
            get
            {
                return _dataIntalacao;
            }
            set
            {
                if (value != null)
                {
                    this._dataIntalacao = value;
                    txtDataInstalacao.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy") : String.Empty;
                }
            }
        }

        private string _problemaQuebraSigilo;
        public string ProblemaQuebraSigilo
        {
            get
            {
                return this._problemaQuebraSigilo;
            }
            set
            {
                this._problemaQuebraSigilo = value;
                if (value != null)
                    rbQuebraSigilo.SelectedValue = value;
                else
                    rbQuebraSigilo.SelectedValue = "";
            }
        }

        private string _nro_contratoRelacionado;
        public string NroContratoRelacionado
        {
            get
            {
                return this._nro_contratoRelacionado;
            }
            set
            {
                this._nro_contratoRelacionado = value;
                if (value != null)
                    txtNroContrato.Text = value;
                else
                    txtNroContrato.Text = "";
            }
        }

        private string _multaContratual;
        public string MultaContratual
        {
            get
            {
                return this._nro_contratoRelacionado;
            }
            set
            {
                this._multaContratual = value;
                if (value != null)
                    rbMultaContratual.SelectedValue = value;
                else
                    rbMultaContratual.SelectedValue = "";
            }
        }

        private string _gravacaoFavoravel;
        public string GravacaoFavoravel
        {
            get
            {
                return this._gravacaoFavoravel;
            }
            set
            {
                this._gravacaoFavoravel = value;
                if (value != null)
                    rbGravacaoFavoravel.SelectedValue = value;
                else
                    rbGravacaoFavoravel.SelectedValue = "";
            }
        }

        private string _haBoletimOcorrencia;
        public string HaBoletimOcorrencia
        {
            get
            {
                return this._haBoletimOcorrencia;
            }
            set
            {
                this._haBoletimOcorrencia = value;
                if (value != null)
                    rbBoletimOcorrencia.SelectedValue = value;
                else
                    rbBoletimOcorrencia.SelectedValue = "";
            }
        }

        private string _relatoTecnicoEnvolvido;
        public string RelatoTecnicoEnvolvido
        {
            get
            {
                return this._relatoTecnicoEnvolvido;
            }
            set
            {
                this._relatoTecnicoEnvolvido = value;
                if (value != null)
                    rbRelatoTecEnvolvido.SelectedValue = value;
                else
                    rbRelatoTecEnvolvido.SelectedValue = "";
            }
        }

        private string _danosRessarcidos;
        public string DanosRessarcidos
        {
            get
            {
                return this._danosRessarcidos;
            }
            set
            {
                this._danosRessarcidos = value;
                if (value != null)
                    rbDanosRessarcidos.SelectedValue = value;
                else
                    rbDanosRessarcidos.SelectedValue = "";
            }
        }

        private string _laudoTecnico;
        public string LaudoTecnico
        {
            get
            {
                return this._laudoTecnico;
            }
            set
            {
                this._laudoTecnico = value;
                if (value != null)
                    rbLaudoTecnico.SelectedValue = value;
                else
                    rbLaudoTecnico.SelectedValue = "";
            }
        }

        private string _acionamentoSeguro;
        public string AcionamentoSeguro
        {
            get
            {
                return this._acionamentoSeguro;
            }
            set
            {
                this._acionamentoSeguro = value;
                if (value != null)
                    rbAcionamentoSeguro.SelectedValue = value;
                else
                    rbAcionamentoSeguro.SelectedValue = "";
            }
        }

        private string _foiAtropelamento;
        public string FoiAtropelamento
        {
            get
            {
                return this._foiAtropelamento;
            }
            set
            {
                this._foiAtropelamento = value;
                if (value != null)
                    rbFoiAtropelamento.SelectedValue = value;
                else
                    rbFoiAtropelamento.SelectedValue = "";
            }
        }

        private string _batidaAutomovel;
        public string BatidaAutomovel
        {
            get
            {
                return this._batidaAutomovel;
            }
            set
            {
                this._batidaAutomovel = value;
                if (value != null)
                    rbBatidaAutomovel.SelectedValue = value;
                else
                    rbBatidaAutomovel.SelectedValue = "";
            }
        }

        private string _frotaDaEmpresa;
        public string FrotaDaEmpresa
        {
            get
            {
                return this._frotaDaEmpresa;
            }
            set
            {
                this._frotaDaEmpresa = value;
                if (value != null)
                    rbFrotaDaEmpresa.SelectedValue = value;
                else
                    rbFrotaDaEmpresa.SelectedValue = "";
            }
        }

        private string _veiculoEmpresaTerceira;
        public string VeiculoEmpresaTerceira
        {
            get
            {
                return this._veiculoEmpresaTerceira;
            }
            set
            {
                this._veiculoEmpresaTerceira = value;
                if (value != null)
                    rbVeicEmprTerceira.SelectedValue = value;
                else
                    rbVeicEmprTerceira.SelectedValue = "";
            }
        }

        private string _qualEmpresaTerceira;
        public string QualEmpresaterceira
        {
            get
            {
                return this._qualEmpresaTerceira;
            }
            set
            {
                this._qualEmpresaTerceira = value;
                if (value != null)
                    txtEmpresaTerceira.Text = value;
                else
                    txtEmpresaTerceira.Text = "";
            }
        }

        private string _empresaAtiva;
        public string EmpresaAtiva
        {
            get
            {
                return this._empresaAtiva;
            }
            set
            {
                this._empresaAtiva = value;
                if (value != null)
                    rbEmpresaAtiva.SelectedValue = value;
                else
                    rbEmpresaAtiva.SelectedValue = "";
            }
        }

        private string _placaVeiculo;
        public string PlacaVeiculo
        {
            get
            {
                return this._placaVeiculo;
            }
            set
            {
                this._placaVeiculo = value;
                if (value != null)
                    rbPlacaVeiculo.SelectedValue = value;
                else
                    rbPlacaVeiculo.SelectedValue = "";
            }
        }

        private string _culpaMotorista;
        public string CulpaMotorista
        {
            get
            {
                return this._culpaMotorista;
            }
            set
            {
                this._culpaMotorista = value;
                if (value != null)
                    rbCulpaMotorista.SelectedValue = value;
                else
                    rbCulpaMotorista.SelectedValue = "";
            }
        }


        private string _caboSolto;
        public string CaboSolto
        {
            get
            {
                return this._caboSolto;
            }
            set
            {
                this._caboSolto = value;
                if (value != null)
                    rbCaboSolto.SelectedValue = value;
                else
                    rbCaboSolto.SelectedValue = "";
            }
        }

        private string _faltaSinal;
        public string FaltaSinal
        {
            get
            {
                return this._faltaSinal;
            }
            set
            {
                this._faltaSinal = value;
                if (value != null)
                    rbFaltaSinal.SelectedValue = value;
                else
                    rbFaltaSinal.SelectedValue = "";
            }
        }

        private string _infraPedial;
        public string InfraPredial
        {
            get
            {
                return this._infraPedial;
            }
            set
            {
                this._infraPedial = value;
                if (value != null)
                    rbInfraPredial.SelectedValue = value;
                else
                    rbInfraPredial.SelectedValue = "";
            }
        }

        private string _infraDoGrupo;
        public string InfraDoGrupo
        {
            get
            {
                return this._infraDoGrupo;
            }
            set
            {
                this._infraDoGrupo = value;
                if (value != null)
                    rbInfraDoGrupo.SelectedValue = value;
                else
                    rbInfraDoGrupo.SelectedValue = "";
            }
        }

        private string _infraEmpresaTerceira;
        public string InfraEmpresaTerceira
        {
            get
            {
                return this._infraEmpresaTerceira;
            }
            set
            {
                this._infraEmpresaTerceira = value;
                if (value != null)
                    rbInfraEmpresaTerceira.SelectedValue = value;
                else
                    rbInfraEmpresaTerceira.SelectedValue = "";
            }
        }

        private string _empresaTerceiraInfra;
        public string EmpresaTerceiraInfra
        {
            get
            {
                return this._empresaTerceiraInfra;
            }
            set
            {
                this._empresaTerceiraInfra = value;
                if (value != null)
                    txtEmpTerceiraInfra.Text = value;
                else
                    txtEmpTerceiraInfra.Text = "";
            }
        }

        private string _empresaAtivaInfra;
        public string EmpresaAtivaInfra
        {
            get
            {
                return this._empresaAtivaInfra;
            }
            set
            {
                this._empresaAtivaInfra = value;
                if (value != null)
                    rbEmAtivaInfra.Text = value;
                else
                    rbEmAtivaInfra.Text = "";
            }
        }

        public Panel panelPrincipal3
        {
            get
            {
                return pPrincipal3;
            }
            set
            {
                pPrincipal3 = value;
            }
        }

        public async Task populaCampos(int FormularioId, string status, int tipoFormularioId)
        {
            disabilitaCamposReabertura(status);
            await carregaMotivo();
            selecionaMotivo(tipoFormularioId);

            Questao3_4_APSBll questao3_4_APSBll = new Questao3_4_APSBll();
            var q = await questao3_4_APSBll.readAsync(FormularioId);
            if (q != null)
            {
                ViewState["idQuestao"] = q.id;
                this.Motivo = q.motivoId;
                this.Token = q.token;
                this.GravacaoServicoAdicional = q.gravacaoServicoAdicional;
                this.ErroTerceiroPrestadora = q.erroTerceiroPrestadora;
                this.FaturaPagaNaoContestada = q.faturaPagaNaoContestada;
                this.ContratoObjetoAutor = q.contratoObjetoAutor;
                this.DataIntalacao = q.dataIntalacao;
                this.ProblemaQuebraSigilo = q.problemaQuebraSigilo;
                this.NroContratoRelacionado = q.nro_contratoRelacionado;
                this.MultaContratual = q.multaContratual;
                this.GravacaoFavoravel = q.gravacaoFavoravel;
                this.HaBoletimOcorrencia = q.haBoletimOcorrencia;
                this.RelatoTecnicoEnvolvido = q.relatoTecnicoEnvolvido;
                this.DanosRessarcidos = q.danosRessarcidos;
                this.LaudoTecnico = q.laudoTecnico;
                this.AcionamentoSeguro = q.acionamentoSeguro;
                this.FoiAtropelamento = q.foiAtropelamento;
                this.BatidaAutomovel = q.batidaAutomovel;
                this.FrotaDaEmpresa = q.frotaDaEmpresa;
                this.VeiculoEmpresaTerceira = q.veiculoEmpresaTerceira;
                this.QualEmpresaterceira = q.qualEmpresaTerceira;
                this.EmpresaAtiva = q.empresaAtiva;
                this.PlacaVeiculo = q.placaVeiculo;
                this.CulpaMotorista = q.culpaMotorista;
                this.CaboSolto = q.caboSolto;
                this.FaltaSinal = q.faltaSinal;
                this.InfraPredial = q.infraPedial;
                this.InfraDoGrupo = q.infraDoGrupo;
                this.InfraEmpresaTerceira = q.infraEmpresaTerceira;
                this.EmpresaTerceiraInfra = q.empresaTerceiraInfra;
                this.EmpresaAtivaInfra = q.empresaAtivaInfra;
            }
            else
            {
                // ScriptManager.RegisterStartupScript(Page, Page.GetType(), "HideAll", "$('#UserControlQuestao3_4_pPrincipal4').hide();", true);
                carregaMotivoCampos();
            }
        }

        public void SaveQuestao3_4(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao3_4_APSBll questao3_4_APSBll = new Questao3_4_APSBll();

                    Questao3_4_APS questao3_4 = new Questao3_4_APS();
                    questao3_4.id = Convert.ToInt32(ViewState["idQuestao"]);
                    questao3_4.formularioId = FormularioId;

                    questao3_4.motivoId = ddlMotivo.SelectedValue != "0" ? Convert.ToInt32(ddlMotivo.SelectedValue) : questao3_4.motivoId = null;
                    questao3_4.token = rbToken.SelectedValue;
                    questao3_4.gravacaoServicoAdicional = rbGravacao.SelectedValue;
                    questao3_4.erroTerceiroPrestadora = rbTerceiraPrestadora.SelectedValue;
                    questao3_4.faturaPagaNaoContestada = rbFaturaPaga.SelectedValue;
                    questao3_4.contratoObjetoAutor = rbContratoPeticaoAutor.SelectedValue;
                    questao3_4.problemaQuebraSigilo = rbQuebraSigilo.SelectedValue;
                    questao3_4.nro_contratoRelacionado = txtNroContrato.Text;
                    questao3_4.multaContratual = rbMultaContratual.SelectedValue;
                    questao3_4.gravacaoFavoravel = rbGravacaoFavoravel.SelectedValue;
                    questao3_4.haBoletimOcorrencia = rbBoletimOcorrencia.SelectedValue;
                    questao3_4.relatoTecnicoEnvolvido = rbRelatoTecEnvolvido.SelectedValue;
                    questao3_4.danosRessarcidos = rbDanosRessarcidos.SelectedValue;
                    questao3_4.laudoTecnico = rbLaudoTecnico.SelectedValue;
                    questao3_4.acionamentoSeguro = rbAcionamentoSeguro.SelectedValue;

                    questao3_4.foiAtropelamento = rbFoiAtropelamento.SelectedValue;
                    questao3_4.batidaAutomovel = rbBatidaAutomovel.SelectedValue;
                    questao3_4.frotaDaEmpresa = rbFrotaDaEmpresa.SelectedValue;
                    questao3_4.veiculoEmpresaTerceira = rbVeicEmprTerceira.SelectedValue;
                    questao3_4.qualEmpresaTerceira = txtEmpresaTerceira.Text;
                    questao3_4.empresaAtiva = rbEmpresaAtiva.SelectedValue;
                    questao3_4.placaVeiculo = rbPlacaVeiculo.SelectedValue;
                    questao3_4.culpaMotorista = rbCulpaMotorista.SelectedValue;

                    questao3_4.caboSolto = rbCaboSolto.SelectedValue;
                    questao3_4.faltaSinal = rbFaltaSinal.SelectedValue;
                    questao3_4.infraPedial = rbInfraPredial.SelectedValue;
                    questao3_4.infraDoGrupo = rbInfraDoGrupo.SelectedValue;
                    questao3_4.infraEmpresaTerceira = rbInfraEmpresaTerceira.SelectedValue;
                    questao3_4.empresaTerceiraInfra = txtEmpTerceiraInfra.Text;
                    questao3_4.empresaAtivaInfra = rbEmAtivaInfra.SelectedValue;
                    questao3_4.dataIntalacao = Util.ISDate(txtDataInstalacao.Text) ? DateTime.Parse(txtDataInstalacao.Text) : questao3_4.dataIntalacao = null;

                    questao3_4_APSBll.save(questao3_4);
                    ViewState["idQuestao"] = questao3_4.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private async Task carregaMotivo()
        {
            try
            {
                MotivoContestacaoBll motivoContestacaoBll = new MotivoContestacaoBll();
                listaMotivoContest = await motivoContestacaoBll.listAsyncAll();
                Util.CarregaControle(ddlMotivo, listaMotivoContest, false);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void selecionaMotivo(int tipoFormularioId)
        {
            if (1.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Fraude").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (14.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Serviços Adicionais (PPV, AGREGADORES E SERVIÇOS CLARO)").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (7.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Portabilidade").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (11.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Cancelamento").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (12.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Entrega de aparelho").Value;
                ddlMotivo.Enabled = false; return;
            }

            //if ("Cobrança indevida".Contains(tbTipoFormulario.Remove(5)))
            //{
            //    ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Cobrança indevida").Value;
            //    ddlMotivo.Enabled = false; return;
            //}

            if (16.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Rede / Cobertura").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (13.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Problemas técnicos").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (8.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Problemas com vendas").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (6.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Acidente").Value;
                desabilitaItemsAcidente();
                return;
            }

            if (9.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Migração indevida").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (10.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Cobrança indevida").Value;
                ddlMotivo.Enabled = false; return;
            }

            if (17.Equals(tipoFormularioId))
            {
                ddlMotivo.SelectedValue = ddlMotivo.Items.FindByText("Outros").Value;
                ddlMotivo.Enabled = false; return;
            }

        }

        private void desabilitaItemsAcidente()
        {
            ddlMotivo.Items[1].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[1].Attributes.Add("disabled", "true");

            ddlMotivo.Items[2].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[2].Attributes.Add("disabled", "true");

            ddlMotivo.Items[3].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[3].Attributes.Add("disabled", "true");

            ddlMotivo.Items[4].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[4].Attributes.Add("disabled", "true");

            ddlMotivo.Items[5].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[5].Attributes.Add("disabled", "true");

            ddlMotivo.Items[6].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[6].Attributes.Add("disabled", "true");

            ddlMotivo.Items[7].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[7].Attributes.Add("disabled", "true");

            ddlMotivo.Items[8].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[8].Attributes.Add("disabled", "true");

            ddlMotivo.Items[9].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[9].Attributes.Add("disabled", "true");

            ddlMotivo.Items[13].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[13].Attributes.Add("disabled", "true");

            ddlMotivo.Items[14].Attributes.Add("style", "color:gray;");
            ddlMotivo.Items[14].Attributes.Add("disabled", "true");
        }
        private void ddlMotivo_SelectedIndexChanged(Object sender, EventArgs e)
        {
            carregaMotivoCampos();
        }

        private void carregaMotivoCampos()
        {
            motivo = null;
            if (ddlMotivo.SelectedIndex > 0)
            {
                motivo = listaMotivoContest.Find(x => x.id == Convert.ToInt32(ddlMotivo.SelectedValue));

                if (motivo != null)
                {
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "HideAll", "if($('#UserControlQuestao3_4_pPrincipal4').is(':hidden')) $('#UserControlQuestao3_4_pPrincipal4').show();", true);
                    StringBuilder script = new StringBuilder();

                    if ((bool)motivo.historicoCliente)
                    {
                        script.Append("$('#UserControlQuestao3_4_pPrincipal4').show();");
                        script.Append("$('#dvHistoricoClienteCampos').show();");
                        if ((bool)motivo.dataHablitacao)
                            script.Append("$('#dvHistoricoClienteCampo_Data').show();");
                        else
                            script.Append("if($('#dvHistoricoClienteCampo_Data').is(':visible')) $('#dvHistoricoClienteCampo_Data').hide();");

                        if ((bool)motivo.token)
                            script.Append("$('#dvHistoricoClienteCampo_Token').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbToken')[0], true);");
                        else
                            script.Append("if($('#dvHistoricoClienteCampo_Token').is(':visible')) $('#dvHistoricoClienteCampo_Token').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbToken')[0], false);");

                        if ((bool)motivo.gravacaoRelacionda)
                            script.Append("$('#dvHistoricoClienteCampo_Gravacao').show();");
                        else
                            script.Append("if($('#dvHistoricoClienteCampo_Gravacao').is(':visible')) $('#dvHistoricoClienteCampo_Gravacao').hide();");

                        if ((bool)motivo.contratoObjetoAutor)
                            script.Append("$('#dvHistoricoClienteCampo_ContratoPeticao').show();");
                        else
                            script.Append("if($('#dvHistoricoClienteCampo_ContratoPeticao').is(':visible')) $('#dvHistoricoClienteCampo_ContratoPeticao').hide();");

                        if ((bool)motivo.problemaQuebraSigilo)
                            script.Append("$('#dvprobQuebSigCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbQuebraSigilo')[0], true);");
                        else
                            script.Append("if($('#dvprobQuebSigCampos').is(':visible')) $('#dvprobQuebSigCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbQuebraSigilo')[0], false); ");

                        if ((bool)motivo.nro_contratoRelacionado)
                            script.Append("$('#dvnroContratoCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvtxtNroContrato')[0], true);");
                        else
                            script.Append("if($('#dvnroContratoCampos').is(':visible')) $('#dvnroContratoCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvtxtNroContrato')[0], false);");

                        if ((bool)motivo.multaContratual)
                            script.Append("$('#dvmultaContratualCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbMultaContratual')[0], true);");
                        else
                            script.Append("if($('#dvmultaContratualCampos').is(':visible')) $('#dvmultaContratualCampos').hide();  ValidatorEnable($('#UserControlQuestao3_4_rfvrbMultaContratual')[0], false);");

                        if ((bool)motivo.gravacaoFavoravel)
                            script.Append("$('#dvgravacaoFavoravelCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbGravacaoFavoravel')[0], true);");
                        else
                            script.Append("if($('#dvgravacaoFavoravelCampos').is(':visible')) $('#dvgravacaoFavoravelCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbGravacaoFavoravel')[0], false);");

                        if ((bool)motivo.haBoletimOcorrencia)
                            script.Append("$('#dvBoletimOcorrenciaCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbBoletimOcorrencia')[0], true);");
                        else
                            script.Append("if($('#dvBoletimOcorrenciaCampos').is(':visible')) $('#dvBoletimOcorrenciaCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbBoletimOcorrencia')[0], false);");

                        if ((bool)motivo.relatoTecnicoEnvolvido)
                            script.Append("$('#dvRelTecEnvolvidoCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbRelatoTecEnvolvido')[0], true);");
                        else
                            script.Append("if($('#dvRelTecEnvolvidoCampos').is(':visible')) $('#dvRelTecEnvolvidoCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbRelatoTecEnvolvido')[0], false);");

                        if ((bool)motivo.danosRessarcidos)
                            script.Append("$('#dvDanosRessarcidosCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbDanosRessarcidos')[0], true);");
                        else
                            script.Append("if($('#dvDanosRessarcidosCampos').is(':visible')) $('#dvDanosRessarcidosCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbDanosRessarcidos')[0], false);");

                        if ((bool)motivo.laudoTecnico)
                            script.Append("$('#dvLaudoTecnicoCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbLaudoTecnico')[0], true);");
                        else
                            script.Append("if($('#dvLaudoTecnicoCampos').is(':visible')) $('#dvLaudoTecnicoCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbLaudoTecnico')[0], false);");

                        if ((bool)motivo.foiAtropelamento)
                            script.Append("$('#dvFoiAtropelamentoCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFoiAtropelamento')[0], true);");
                        else
                            script.Append("if($('#dvFoiAtropelamentoCampos').is(':visible')) $('#dvFoiAtropelamentoCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFoiAtropelamento')[0], false);");

                        if ((bool)motivo.batidaAutomovel)
                            script.Append("$('#dvBatidaAutomovelCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbBatidaAutomovel')[0], true);");
                        else
                            script.Append("if($('#dvBatidaAutomovelCampos').is(':visible')) $('#dvBatidaAutomovelCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbBatidaAutomovel')[0], false);");

                        if ((bool)motivo.frotaDaEmpresa)
                            script.Append("$('#dvFrotaDaEmpresaCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFrotaDaEmpresa')[0], true);");
                        else
                            script.Append("if($('#dvFrotaDaEmpresaCampos').is(':visible')) $('#dvFrotaDaEmpresaCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFrotaDaEmpresa')[0], false);");

                        if ((bool)motivo.veiculoEmpresaTerceira)
                            script.Append("$('#dvVeicEmpTerceiraCampo').show();  ValidatorEnable($('#UserControlQuestao3_4_rfvrbVeicEmprTerceira')[0], true);");
                        else
                            script.Append("if($('#dvVeicEmpTerceiraCampo').is(':visible')) $('#dvVeicEmpTerceiraCampo').hide();  ValidatorEnable($('#UserControlQuestao3_4_rfvrbVeicEmprTerceira')[0], false);");

                        if ((bool)motivo.qualEmpresaTerceira)
                            script.Append("$('#dvEmpresaTerceiraCampos').show();  ValidatorEnable($('#UserControlQuestao3_4_rfvtxtEmpresaTerceira')[0], true);");
                        else
                            script.Append("if($('#dvEmpresaTerceiraCampos').is(':visible')) $('#dvEmpresaTerceiraCampos').hide();  ValidatorEnable($('#UserControlQuestao3_4_rfvtxtEmpresaTerceira')[0], false);");

                        if ((bool)motivo.empresaAtiva)
                            script.Append("$('#dvEmpresaAtivaCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbEmpresaAtiva')[0], true);");
                        else
                            script.Append("if($('#dvEmpresaAtivaCampos').is(':visible')) $('#dvEmpresaAtivaCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbEmpresaAtiva')[0], false);");

                        if ((bool)motivo.placaVeiculo)
                            script.Append("$('#dvPlacaVeiculoCampos').show();  ValidatorEnable($('#UserControlQuestao3_4_rfvrbPlacaVeiculo')[0], true);");
                        else
                            script.Append("if($('#dvPlacaVeiculoCampos').is(':visible')) $('#dvPlacaVeiculoCampos').hide();  ValidatorEnable($('#UserControlQuestao3_4_rfvrbPlacaVeiculo')[0], false);");

                        if ((bool)motivo.culpaMotorista)
                            script.Append("$('#dvCulpaMotoristaCampos').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbCulpaMotorista')[0], true);");
                        else
                            script.Append("if($('#dvCulpaMotoristaCampos').is(':visible')) $('#dvCulpaMotoristaCampos').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbCulpaMotorista')[0], false);");

                        if ((bool)motivo.acionamentoSeguro)
                            script.Append("$('#dvAcionamentoSeguro').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbAcionamentoSeguro')[0], true);");
                        else
                            script.Append("if($('#dvAcionamentoSeguro').is(':visible')) $('#dvAcionamentoSeguro').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbAcionamentoSeguro')[0], false);");

                        if ((bool)motivo.caboSolto)
                            script.Append("$('#dvCaboSoltoCampo').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbCaboSolto')[0], true);");
                        else
                            script.Append("if($('#dvCaboSoltoCampo').is(':visible')) $('#dvCaboSoltoCampo').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbCaboSolto')[0], false);");

                        if ((bool)motivo.faltaSinal)
                            script.Append("$('#dvFaltaSinalCampo').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFaltaSinal')[0], true);");
                        else
                            script.Append("if($('#dvFaltaSinalCampo').is(':visible')) $('#dvFaltaSinalCampo').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFaltaSinal')[0], false);");

                        if ((bool)motivo.infraPedial)
                            script.Append("$('#dvInfraPredialCampo').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbInfraPredial')[0], true);");
                        else
                            script.Append("if($('#dvInfraPredialCampo').is(':visible')) $('#dvInfraPredialCampo').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbInfraPredial')[0], false);");

                        if ((bool)motivo.infraDoGrupo)
                            script.Append("$('#dvInfraDoGrupoCampo').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbInfraDoGrupo')[0], true);");
                        else
                            script.Append("if($('#dvInfraDoGrupoCampo').is(':visible')) $('#dvInfraDoGrupoCampo').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbInfraDoGrupo')[0], false);");

                        if ((bool)motivo.infraEmpresaTerceira)
                            script.Append("$('#dvInfraEmpresaTerceiraCampo').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbInfraEmpresaTerceira')[0], true);");
                        else
                            script.Append("if($('#dvInfraEmpresaTerceiraCampo').is(':visible')) $('#dvInfraEmpresaTerceiraCampo').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbInfraEmpresaTerceira')[0], false);");

                        if ((bool)motivo.empresaTerceiraInfra)
                            script.Append("$('#dvEmpTerceiraInfra').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvtxtEmpTerceiraInfra')[0], true);");
                        else
                            script.Append("if($('#dvEmpTerceiraInfra').is(':visible')) $('#dvEmpTerceiraInfra').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvtxtEmpTerceiraInfra')[0], false);");

                        if ((bool)motivo.empresaAtivaInfra)
                            script.Append("$('#dvEmpAtivaInfra').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbEmAtivaInfra')[0], true);");
                        else
                            script.Append("if($('#dvEmpAtivaInfra').is(':visible')) $('#dvEmpAtivaInfra').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbEmAtivaInfra')[0], false);");

                    }
                    else
                        script.Append("if($('#UserControlQuestao3_4_pPrincipal4').is(':visible')) $('#UserControlQuestao3_4_pPrincipal4').hide();");

                    if ((bool)motivo.detalhamentoProblema)
                    {
                        script.Append("$('#UserControlQuestao3_4_pPrincipal4').show();");
                        script.Append("$('#dvDetalheProblema').show();");
                    }
                    else
                        script.Append("if($('#dvDetalheProblema').is(':visible')) $('#dvDetalheProblema').hide();");

                    if ((bool)motivo.cobranca)
                    {
                        script.Append("$('#UserControlQuestao3_4_pPrincipal4').show();");
                        script.Append("$('#dvCobranca').show(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFaturaPaga')[0], true);");
                    }
                    else
                        script.Append("if($('#dvCobranca').is(':visible')) $('#dvCobranca').hide(); ValidatorEnable($('#UserControlQuestao3_4_rfvrbFaturaPaga')[0], false);");


                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "HideAll3_4", script.ToString(), true);

                    txtDataInstalacao.Text = String.Empty;

                    if (motivo.id == 15 || motivo.id == 10 || motivo.id == 11 || motivo.id == 12)
                        desabilitaItemsAcidente();
                }
                else
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "HideAll", "if($('#UserControlQuestao3_4_pPrincipal4').is(':visible')) $('#UserControlQuestao3_4_pPrincipal4').hide();", true);
            }
            else
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "HideAll", "if($('#UserControlQuestao3_4_pPrincipal4').is(':visible')) $('#UserControlQuestao3_4_pPrincipal4').hide();", true);

            //  this.up4.Update();
        }
        override protected void OnInit(EventArgs e)
        {
            this.ddlMotivo.SelectedIndexChanged +=
            new System.EventHandler(ddlMotivo_SelectedIndexChanged);
            base.OnInit(e);
        }

    }

}