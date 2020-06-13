using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlExecQuestao1 : System.Web.UI.UserControl
    {

        #region Properties
        Questao1 questao1 = new Questao1();
        Questao1BLL questao1BLL = new Questao1BLL();
        Empresa empresaModel = new Empresa();
        EmpresaBLL emprBLL = new EmpresaBLL();
        Produto produtoModel = new Produto();
        ProdutoBLL prodBLL = new ProdutoBLL();
        Estado estadoModel = new Estado();
        EstadoBLL estadoBLL = new EstadoBLL();
        CidadeBLL cidBLL = new CidadeBLL();
        public int tipoFormulario = 0;


        private int? _estado;
        public int? Estado
        {
            get
            {
                return this._estado;
            }
            set
            {
                this._estado = value;
                if (value != null)
                    drpEstado.SelectedValue = value.ToString();
                else
                    drpEstado.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private int? _cidade;
        public int? Cidade
        {
            get
            {
                return this._cidade;
            }
            set
            {
                this._cidade = value;
                if (value != null)
                {
                    drpCidDomicilio.SelectedValue = cidBLL.read(_cidade).id.ToString();
                }
            }
        }

        private string _telefone;
        public string Telefone
        {
            get
            {
                return this._telefone;
            }
            set
            {
                this._telefone = value;
                txtTelefone.Text = value != null ? value.ToString() : string.Empty;
            }
        }

        private bool _isCliente;
        public bool IsCliente
        {
            get
            {
                return this._isCliente;
            }
            set
            {
                this._isCliente = value;
                chkCliente.Checked = value;
                txtTelefone.Enabled = (value == true ? false : true);
                rfTel.Enabled = (value == true ? false : true);
            }
        }
        #endregion Properties

        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private void disabilitaCamposReabertura(string status)
        {
            StatusReaberturaBll srBll = new StatusReaberturaBll();

            if (srBll.listAll().Contains(status))
            {
                if (tipoFormulario == Convert.ToInt16(Util.TFormulario.Execucao) ||
                    tipoFormulario == Convert.ToInt16(Util.TFormulario.Liminar) ||
                    tipoFormulario == Convert.ToInt16(Util.TFormulario.Descumprimento))
                {
                    pPrincipal1.Visible = false;
                }

            }
        }

        #endregion Page Load

        #region Protected
        /// <summary>
        ///  Método de evento de seleção do dropdownlist Estado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected async void estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            await PopularDropDownCidade(Convert.ToInt32(drpEstado.SelectedValue));
        }

        private async Task populaCombosIniciais(string estado, string cidade)
        {
            if (estado != null)
            {
                drpEstado.SelectedValue = drpEstado.Items.FindByText(estado).Value;

                await PopularDropDownCidade(Convert.ToInt32(drpEstado.SelectedValue));

                drpCidDomicilio.SelectedValue = (drpCidDomicilio.Items.FindByText(cidade) == null ? "0" : drpCidDomicilio.Items.FindByText(cidade).Value);
            }

        }
        #endregion Protected

        #region Public 
        /// <summary>
        /// Popula questão 1.
        /// </summary>
        /// <param name="form"></param>
        /// <param name="questao1"></param>
        public async Task PopulaQuestao1(int id, string status, string empresa, string produto, string estado, string cidade)
        {
            disabilitaCamposReabertura(status);
            PopularDropDownEstado(await estadoBLL.listAsyncAll());
            questao1 = await questao1BLL.readAsync(id);
            if (questao1 != null)
            {
                ViewState["idQuestao"] = questao1.id;
                var cidEst = cidBLL.read(questao1.CidadeId);
                if (cidEst != null)
                {
                    Estado = cidEst.estadoId;
                    await PopularDropDownCidade(Convert.ToInt32(cidEst.estadoId));
                }

                Cidade = questao1.CidadeId;
                Telefone = questao1.telefone;
                IsCliente = questao1.iscliente;
            }
            else
            {
                await populaCombosIniciais( estado, cidade);
            }

        }

        /// <summary>
        /// Salvar questão 1 na tabela TbQuestao1.
        /// </summary>
        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao1BLL questao1BLL = new Questao1BLL();
                    Questao1 quest1 = new Questao1();

                    quest1.id = Convert.ToInt32(ViewState["idQuestao"]);
                    quest1.formularioId = FormularioId;

                    if (drpCidDomicilio.SelectedValue != "0" && drpCidDomicilio.SelectedValue != "")
                        quest1.CidadeId = Convert.ToInt32(drpCidDomicilio.SelectedValue);
                    else
                        quest1.CidadeId = null;

                    quest1.telefone = !string.IsNullOrWhiteSpace(txtTelefone.Text) ? txtTelefone.Text.Replace(")", "").Replace("(", "").Replace("-", "").Replace(" ", "").Trim() : null;
                    quest1.iscliente = chkCliente.Checked;

                    questao1BLL.save(quest1);
                    ViewState["idQuestao"] = quest1.id;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }

        /// <summary>
        ///  Método para popular dropdown Estado.
        /// </summary>
        /// <param name="listEstado"></param>
        public void PopularDropDownEstado(List<Estado> listEstado)
        {
            drpEstado.DataSource = listEstado;
            drpEstado.DataValueField = "ID";
            drpEstado.DataTextField = "uf";
            drpEstado.DataBind();
            drpEstado.Items.Insert(0, new ListItem("<< Selecione >>", "0"));
        }

        /// <summary>
        ///  Método para popular dropdown Cidade.
        /// </summary>
        /// <param name="listCidade"></param>
        public async Task PopularDropDownCidade(int estID)
        {
            Cidade cidade = new Cidade();
            CidadeBLL cidadeBLL = new CidadeBLL();
            drpCidDomicilio.DataSource = await cidadeBLL.listAsync(estID);
            drpCidDomicilio.DataValueField = "ID";
            drpCidDomicilio.DataTextField = "nome";
            drpCidDomicilio.DataBind();
            drpCidDomicilio.Items.Insert(0, new ListItem("<< Selecione >>", "0"));
        }

        #endregion Public            
    }
}