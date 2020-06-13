using AutomacaoModel;
using System;
using System.Collections.Generic;
using AutomacaoBll;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Services;
using System.Threading.Tasks;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao7 : System.Web.UI.UserControl
    {
        public void Page_Load(object sender, EventArgs e)
        {

        }

        private void disabilitaCamposReabertura(string status)
        {
            StatusReaberturaBll srBll = new StatusReaberturaBll();

            if (srBll.listAll().Contains(status))
            {
                dvAcao.Visible = false;
                dvPendente.Visible = false;
                dvParceiro.Visible = false;
                dvConsideracoes.Visible = false;
                dvSolucao.Visible = false;
                dvFechamento.Visible = false;
            }
        }

        private async Task carregaParceiroOfensor()
        {
            try
            {
                ParceiroOfensorBll parceiroOfensorBll = new ParceiroOfensorBll();
                var list = await parceiroOfensorBll.listAsyncAll();
                Util.CarregaControle(ddlParceiroOfensor, list, false);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task carregaPendente(List<Pendente> list)
        {
            try
            {
                PendenteBLL pendenteBLL = new PendenteBLL();
                if (list == null)
                    list = await pendenteBLL.listAsyncAll();

                Util.CarregaControle(lbPendente, list, false, "Nome", "id", "");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool? _coprrecaoCobranca;
        public bool? CoprrecaoCobranca
        {
            get
            {
                return this._coprrecaoCobranca;
            }
            set
            {
                this._coprrecaoCobranca = value;
                cbCorrecaoCobrancaIndevida.Checked = _coprrecaoCobranca.HasValue ? _coprrecaoCobranca.Value : false;
            }
        }

        private bool? _cancelamentoIsencao;
        public bool? CancelamentoIsencao
        {
            get
            {
                return this._cancelamentoIsencao;
            }
            set
            {
                this._cancelamentoIsencao = value;
                cbCancelamentoIsencao.Checked = _cancelamentoIsencao.HasValue ? _cancelamentoIsencao.Value : false;
            }
        }

        private bool? _cancelamentoCobranca;
        public bool? CancelamentoCobranca
        {
            get
            {
                return this._cancelamentoCobranca;
            }
            set
            {
                this._cancelamentoCobranca = value;
                cbCancelamentoCobranca.Checked = _cancelamentoCobranca.HasValue ? _cancelamentoCobranca.Value : false;
            }
        }

        private bool? _exclusaoNegativa;
        public bool? ExclusaoNegativa
        {
            get
            {
                return this._exclusaoNegativa;
            }
            set
            {
                this._exclusaoNegativa = value;
                cbExclusaoNegaticao.Checked = _exclusaoNegativa.HasValue ? _exclusaoNegativa.Value : false;
            }
        }

        private int? _reclamacaoCliente;
        public int? ReclamacaoCliente
        {
            get
            {
                return this._reclamacaoCliente;
            }
            set
            {
                this._reclamacaoCliente = value;
                if (value != null)
                    ddlReclamacao.SelectedValue = value.ToString();
                else
                    ddlReclamacao.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private List<string> _pendente;
        public List<string> Pendente
        {
            get
            {
                return _pendente;
            }
            set
            {
                _pendente = value;
            }
        }


        private int? _parceiroOfensor;
        public int? ParceiroOfensor
        {
            get
            {
                return this._parceiroOfensor;
            }
            set
            {
                this._parceiroOfensor = value;
                if (value != null)
                    ddlParceiroOfensor.SelectedValue = value.ToString();
                else
                    if (ddlParceiroOfensor.Items.Count > 0)
                    ddlParceiroOfensor.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private int? _fechamento;
        public int? Fechamento
        {
            get
            {
                return this._fechamento;
            }
            set
            {
                this._fechamento = value;
                if (value != null)
                    ddlFechamento.SelectedValue = value.ToString();
                else
                    ddlFechamento.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private string _consideracoesFinais;
        public string ConsideracoesFinais
        {
            get
            {
                return this._consideracoesFinais;
            }
            set
            {
                this._consideracoesFinais = value;
                txtConsideracoesFinais.Text = value != null ? value.ToString() : String.Empty;
            }
        }

        private string _solucaoProblemas;
        public string SolucaoProblemas
        {
            get
            {
                return this._solucaoProblemas;
            }
            set
            {
                this._solucaoProblemas = value;
                txtSolucaoProblema.Text = value != null ? value.ToString() : String.Empty;
            }
        }

        public Panel panelGeralQuestao7
        {
            get
            {
                return pQ7;
            }
            set
            {
                pQ7 = value;
            }
        }


        public async Task populaCampos(int FormularioId, string status)
        {
            disabilitaCamposReabertura(status);
            await carregaParceiroOfensor();
            await carregaPendente(null);

            Questao7Bll questao7Bll = new Questao7Bll();
            var q = await questao7Bll.readAsync(FormularioId);
            if (q != null)
            {
                ViewState["idQuestao"] = q.id;
                this.ExclusaoNegativa = q.ExclusaoNegativacao;
                this.CoprrecaoCobranca = q.CorrecaoCobrancaIndevida;
                this.CancelamentoIsencao = q.CancelamentoIsencao;
                this.CancelamentoCobranca = q.CancelamentoCobranca;
                this.ReclamacaoCliente = q.ReclamacaoCliente;
                this.ParceiroOfensor = q.parceiroOfensorId;
                this.ConsideracoesFinais = q.ConsideracoesFinais;
                this.SolucaoProblemas = q.SolucaoProblemas;
                this.Fechamento = q.Fechamento;
                this.Pendente = q.Pendente.Split(',').ToList<string>(); // ToList();

                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "p7", "preenchePendente_7();", true);

            }
        }


        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao7Bll questao7Bll = new Questao7Bll();
                    Questao7 q = new Questao7();

                    q.id = Convert.ToInt32(ViewState["idQuestao"]);
                    q.formularioId = FormularioId;
                    q.ExclusaoNegativacao = cbExclusaoNegaticao.Checked;
                    q.CorrecaoCobrancaIndevida = cbCorrecaoCobrancaIndevida.Checked;
                    q.CancelamentoIsencao = cbCancelamentoIsencao.Checked;
                    q.CancelamentoCobranca = cbCancelamentoCobranca.Checked;
                    if (ddlReclamacao.SelectedValue != "0")
                        q.ReclamacaoCliente = Convert.ToInt32(ddlReclamacao.SelectedValue);
                    else
                        q.ReclamacaoCliente = null;
                    if (ddlParceiroOfensor.SelectedValue != "0")
                        q.parceiroOfensorId = Convert.ToInt32(ddlParceiroOfensor.SelectedValue);
                    else
                        q.parceiroOfensorId = null;
                    q.ConsideracoesFinais = txtConsideracoesFinais.Text.TrimEnd();
                    q.SolucaoProblemas = txtSolucaoProblema.Text.TrimEnd();
                    if (ddlFechamento.SelectedValue != "0")
                        q.Fechamento = Convert.ToInt32(ddlFechamento.SelectedValue);
                    else
                        q.Fechamento = null;

                    q.Pendente = "";
                    q.PendenteValor = "";
                    foreach (ListItem item in lbPendente.Items)
                    {
                        if (item.Selected)
                        {
                            q.Pendente += item.Text.ToString() + ","; //+ item.Value + "\\n";
                            q.PendenteValor += item.Value.ToString() + ",";
                        }
                    }

                    if (q.Pendente.EndsWith(","))
                        q.Pendente = q.Pendente.Remove(q.Pendente.Length - 1, 1);

                    if (q.PendenteValor.EndsWith(","))
                        q.PendenteValor = q.PendenteValor.Remove(q.PendenteValor.Length - 1, 1);

                    questao7Bll.save(q);
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