using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao6 : System.Web.UI.UserControl
    {
        public void Page_Load(object sender, EventArgs e)
        {

        }

        private void disabilitaCamposReabertura(string status)
        {
            StatusReaberturaBll srBll = new StatusReaberturaBll();

            if (srBll.listAll().Contains(status))
            {
                pPrincipal6.Visible = false;
            }
        }

        override protected void OnInit(EventArgs e)
        {
            this.ddlAreaCausadora.SelectedIndexChanged +=
            new System.EventHandler(ddlAreaCausadora_SelectedIndexChanged);
            this.ddlMotivo.SelectedIndexChanged +=
            new System.EventHandler(ddlMotivo_SelectedIndexChanged);
            base.OnInit(e);
        }

        private async Task carregaAreaCausadora()
        {
            try
            {
                AreaCausadoraBLL areaCausadoraBLL = new AreaCausadoraBLL();
                Util.CarregaControle(ddlAreaCausadora, await areaCausadoraBLL.listAsync(), false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task carregaCentroCusto()
        {
            try
            {
                CentroCustoBLL centroCustoBLL = new CentroCustoBLL();
                Util.CarregaControle(ddlCentroCusto, await centroCustoBLL.listAsync(), false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task carregaMotivo(int areaCausadoraId)
        {
            try
            {
                MotivoBll motivoBll = new MotivoBll();
                Util.CarregaControle(ddlMotivo, await motivoBll.listAsync(areaCausadoraId), false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task carregaSubMotivo(int motivoId)
        {
            try
            {
                SubMotivoBll subMotivoBll = new SubMotivoBll();
                Util.CarregaControle(ddlSubMotivo, await subMotivoBll.listAsync(motivoId), false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task carregaAno()
        {
            try
            {
                AnoBll anoBll = new AnoBll();
                var list = await anoBll.listAsyncAll();
                Util.CarregaControle(ddlAno, list, false, "Ano");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task carregaPercursoCobranca()
        {
            try
            {
                PercursoCobrancaBll percursoCobrancaBll = new PercursoCobrancaBll();
                var list = await percursoCobrancaBll.listAsyncAll();
                Util.CarregaControle(ddlPercursoCobranca, list, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task carregaCanal()
        {
            try
            {
                CanalBLL canalBLL = new CanalBLL();
                var list = await canalBLL.listAsyncAll();
                Util.CarregaControle(ddlCanal, list, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async void ddlAreaCausadora_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (ddlAreaCausadora.SelectedIndex > 0)
                await carregaMotivo(Convert.ToInt32(ddlAreaCausadora.SelectedValue));

            ddlSubMotivo.SelectedIndex = 0;
            upQst6Motivo.Update();
        }

        private async void ddlMotivo_SelectedIndexChanged(Object sender, EventArgs e)
        {
            if (ddlMotivo.SelectedIndex > 0)
                await carregaSubMotivo(Convert.ToInt32(ddlMotivo.SelectedValue));

            upQst6SubMotivo.Update();
        }

        private int? _areaCausadora;
        public int? AreaCausadora
        {
            get
            {
                return this._areaCausadora;
            }
            set
            {
                this._areaCausadora = value;
                if (value != null)
                    ddlAreaCausadora.SelectedValue = value.ToString();
                else
                    ddlAreaCausadora.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private int? _centroCusto;
        public int? CentroCusto
        {
            get
            {
                return this._centroCusto;
            }
            set
            {
                this._centroCusto = value;
                if (value != null)
                    ddlCentroCusto.SelectedValue = value.ToString();
                else
                    ddlCentroCusto.Items.FindByValue(0.ToString()).Selected = true;
            }
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
                    ddlMotivo.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private int? _subMotivo;
        public int? SubMotivo
        {
            get
            {
                return this._subMotivo;
            }
            set
            {
                this._subMotivo = value;
                if (value != null)
                    ddlSubMotivo.SelectedValue = value.ToString();
                else
                    ddlSubMotivo.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private int? _mes;
        public int? Mes
        {
            get
            {
                return this._mes;
            }
            set
            {
                this._mes = value;
                if (value != null)
                    ddlMes.SelectedValue = value.ToString();
                else
                    ddlMes.Items.FindByValue(0.ToString()).Selected = true;
            }
        }


        private int? _ano;
        public int? Ano
        {
            get
            {
                return this._ano;
            }
            set
            {
                this._ano = value;
                if (value != null)
                    ddlAno.SelectedValue = value.ToString();
                else
                    ddlAno.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private int? _percursoCobranca;
        public int? PercursoCobranca
        {
            get
            {
                return this._percursoCobranca;
            }
            set
            {
                this._percursoCobranca = value;
                if (value != null)
                    ddlPercursoCobranca.SelectedValue = value.ToString();
                else
                    ddlPercursoCobranca.Items.FindByValue(0.ToString()).Selected = true;
            }
        }


        private bool? _canalCritico;
        public bool? CanalCritico
        {
            get
            {
                return this._canalCritico;
            }
            set
            {
                this._canalCritico = value;
                if (value != null)
                    rbCanaisCriticos.SelectedValue = value == true ? 1.ToString() : 0.ToString();
                else
                    rbCanaisCriticos.SelectedValue = "";
            }
        }

        private string _memorando;
        public string Memorando
        {
            get
            {
                return this._memorando;
            }
            set
            {
                this._memorando = value;
                txtMemorandoAtendimento.Text = value != null ? value.ToString() : String.Empty;
            }
        }

        private string _conta;
        public string Conta
        {
            get
            {
                return this._conta;
            }
            set
            {
                this._conta = value;
                txtNumeroConta.Text = value != null ? value.ToString() : String.Empty;
            }
        }

        private int? _canal;
        public int? Canal
        {
            get
            {
                return this._canal;
            }
            set
            {
                this._canal = value;
                if (value != null)
                    ddlCanal.SelectedValue = value.ToString();
                else
                    ddlCanal.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private string _protocoloManifesto;
        public string ProtocoloManifesto
        {
            get
            {
                return this._protocoloManifesto;
            }
            set
            {
                this._protocoloManifesto = value;
                txtProtocoloManifesto.Text = value != null ? value.ToString() : String.Empty;
            }
        }

        public Panel panelPrincipal6
        {
            get
            {
                return pPrincipal6;
            }
            set
            {
                pPrincipal6 = value;
            }
        }

        public DropDownList MyText
        {
            get { return ddlCentroCusto; }
            set { ddlCentroCusto = value; }
        }

        public async Task populaCampos(int FormularioId, string status)
        {
            disabilitaCamposReabertura(status);
            await carregaAreaCausadora();
            await carregaCentroCusto();
            await carregaAno();
            await carregaPercursoCobranca();
            await carregaCanal();

            Questao6Bll questao6Bll = new Questao6Bll();
            var q = await questao6Bll.readAsync(FormularioId);
            if (q != null)
            {
                ViewState["idQuestao"] = q.id;
                this.AreaCausadora = q.areaCausadoraId;
                this.CentroCusto = q.centroCustoId;
                if (q.areaCausadoraId == null)
                {
                    q.areaCausadoraId = 0;
                    await carregaMotivo((int)q.areaCausadoraId);
                }
                else
                {
                    await carregaMotivo((int)q.areaCausadoraId);
                }
                if (q.motivoId == null)
                {
                    q.motivoId = 0;
                    await carregaSubMotivo((int)q.motivoId);
                }
                else
                {
                    await carregaSubMotivo((int)q.motivoId);
                }
                this.Motivo = q.motivoId;
                this.SubMotivo = q.subMotivoId;
                this.Mes = q.mes;
                this.Ano = q.anoId;
                this.PercursoCobranca = q.percursoCobrancaId;
                this.CanalCritico = q.CanalCritico;
                if (CanalCritico == true)
                {
                    CanalManifestoID.Style.Add("display", "block");
                }
                else
                {
                    rfCanal.Enabled = false;
                    rfProtocoloManifesto.Enabled = false;
                }

                this.Memorando = q.MemorandoAtendimento;
                this.Conta = q.NumeroConta;
                this.ProtocoloManifesto = q.ProtocoloManifesto;
                this.Canal = q.qualCanalID;
            }
        }

        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao6Bll questao6Bll = new Questao6Bll();
                    Questao6 q = new Questao6();

                    q.id = Convert.ToInt32(ViewState["idQuestao"]);

                    q.formularioId = FormularioId;
                    if (ddlAreaCausadora.SelectedValue != "0")
                        q.areaCausadoraId = Convert.ToInt32(ddlAreaCausadora.SelectedValue);
                    else
                        q.areaCausadoraId = null;
                    q.motivoId = null;
                    q.subMotivoId = null;
                    if (ddlCentroCusto.SelectedValue != "0")
                        q.centroCustoId = Convert.ToInt32(ddlCentroCusto.SelectedValue);
                    else
                        q.centroCustoId = null;
                    if (ddlMotivo.SelectedValue != "0" && ddlMotivo.SelectedValue != "")
                        q.motivoId = Convert.ToInt32(ddlMotivo.SelectedValue);
                    else
                        q.motivoId = null;
                    if (ddlSubMotivo.SelectedValue != "0" && ddlSubMotivo.SelectedValue != "")
                        q.subMotivoId = Convert.ToInt32(ddlSubMotivo.SelectedValue);
                    else
                        q.subMotivoId = null;
                    if (ddlMes.SelectedValue != "0")
                        q.mes = Convert.ToInt32(ddlMes.SelectedValue);
                    else
                        q.mes = null;
                    if (ddlAno.SelectedValue != "0")
                        q.anoId = Convert.ToInt32(ddlAno.SelectedValue);
                    else
                        q.anoId = null;
                    if (ddlPercursoCobranca.SelectedValue != "0")
                        q.percursoCobrancaId = Convert.ToInt32(ddlPercursoCobranca.SelectedValue);
                    else
                        q.percursoCobrancaId = null;

                    q.CanalCritico = rbCanaisCriticos.SelectedValue == "1" ? true : false;

                    if (q.CanalCritico == true)
                    {
                        if (ddlCanal.SelectedValue != "0")
                            q.qualCanalID = Convert.ToInt32(ddlCanal.SelectedValue);
                        else
                            q.qualCanalID = null;
                        q.ProtocoloManifesto = txtProtocoloManifesto.Text.TrimEnd();
                    }
                    else
                    {
                        q.qualCanalID = null;
                        q.ProtocoloManifesto = null;
                    }

                    q.MemorandoAtendimento = txtMemorandoAtendimento.Text.TrimEnd();
                    q.NumeroConta = txtNumeroConta.Text.TrimEnd();

                    questao6Bll.save(q);
                    ViewState["idQuestao"] = q.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

    }
}