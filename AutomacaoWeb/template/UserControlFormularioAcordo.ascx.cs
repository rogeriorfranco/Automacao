using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlFormularioAcordo : UserControl
    {

        public int tipoFormulario;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public async Task PopulaQuestion()
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            PopularDropDownEstado(await estadoBLL.listAsyncAll());
        }

        public void PopularDropDownEstado(List<Estado> listEstado)
        {
            ddlEstado.DataSource = listEstado;
            ddlEstado.DataValueField = "ID";
            ddlEstado.DataTextField = "uf";
            ddlEstado.DataBind();
            ddlEstado.Items.Insert(0, new ListItem("<< Selecione >>", "0"));
        }

        private DateTime? _dataAcordo;
        public DateTime? DataAcordo
        {
            get
            {
                return _dataAcordo;
            }
            set
            {
                this._dataAcordo = value;
                txtDtAcordo.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy") : String.Empty;
            }
        }

        private DateTime? _mes;
        public DateTime? Mes
        {
            get
            {
                return _mes;
            }
            set
            {
                if (value != null)
                {
                    this._mes = value;
                    txtMesAno.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy").ToString().Substring(3, 7) : String.Empty;
                }
            }
        }


        private DateTime? _dataUltimaAcao;
        public DateTime? DataUltimaAcao
        {
            get
            {
                return _dataUltimaAcao;
            }
            set
            {
                this._dataUltimaAcao = value;
                txtDataUltimaAcaoFA.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy") : DateTime.Now.ToShortDateString();
            }
        }

        private string _cenario;
        public string Cenario
        {
            get
            {
                return _cenario;
            }
            set
            {
                this._cenario = value;
                txtCenario.Text = value;
            }
        }

        private int? _motivoProcesso;
        public int? MotivoProcesso
        {
            get
            {
                return this._motivoProcesso;
            }
            set
            {
                this._motivoProcesso = value;
                if (value != null)
                    ddlMotivoProcesso.SelectedValue = value.ToString();
                else
                    ddlMotivoProcesso.Items.FindByValue(0.ToString()).Selected = true;
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

        private decimal? _valorSolicitado;
        public decimal? ValorSolicitado
        {
            get
            {
                return this._valorSolicitado;
            }
            set
            {
                this._valorSolicitado = value;
                txtValorSolicitadoFA.Text = value != null ? value.ToString() : 0.ToString();
            }
        }

        private decimal? _valorAlcada;
        public decimal? ValorAlcada
        {
            get
            {
                return this._valorAlcada;
            }
            set
            {
                this._valorAlcada = value;
                txtValorAlcadaFA.Text = value != null ? value.ToString() : 0.ToString();
            }
        }

        private decimal? _valorAcordoDanosMorais;
        public decimal? ValorAcordoDanosMorais
        {
            get
            {
                return this._valorAcordoDanosMorais;
            }
            set
            {
                this._valorAcordoDanosMorais = value;
                txtAcordoRealizadoMoralFA.Text = value != null ? value.ToString() : 0.ToString();
            }
        }

        private decimal? _valorAcordoDanosMateriais;
        public decimal? ValorAcordoDanosMateriais
        {
            get
            {
                return this._valorAcordoDanosMateriais;
            }
            set
            {
                this._valorAcordoDanosMateriais = value;
                txtAcordoRealizadoMaterialFA.Text = value != null ? value.ToString() : 0.ToString();
            }
        }

        private decimal? _valorAcordoObriogacao;
        public decimal? ValorAcordoObriogacao
        {
            get
            {
                return this._valorAcordoObriogacao;
            }
            set
            {
                this._valorAcordoObriogacao = value;
                txtAcordoRealizadoObricacaoFA.Text = value != null ? value.ToString() : 0.ToString();
            }
        }

        private int? _contatoCom;
        public int? ContatoCom
        {
            get
            {
                return this._contatoCom;
            }
            set
            {
                this._contatoCom = value;
                if (value != null)
                    ddlContatoCom.SelectedValue = value.ToString();
                else
                    ddlContatoCom.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private string _email;
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                this._email = value;
                txtEmailAdvogado.Text = value;
            }
        }

        private string _telefone;
        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {
                this._telefone = value;
                txtTelefoneFA.Text = value;
            }
        }

        private int? _alcada;
        public int? Alcada
        {
            get
            {
                return this._alcada;
            }
            set
            {
                this._alcada = value;
                if (value != null)
                    ddlAlcada.SelectedValue = value.ToString();
                else
                    ddlAlcada.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

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
                    ddlEstado.SelectedValue = value.ToString();
                else
                    ddlEstado.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private int? _critico;
        public int? Critico
        {
            get
            {
                return this._critico;
            }
            set
            {
                this._critico = value;
                if (value != null)
                    ddlCritico.SelectedValue = value.ToString();
                else
                    ddlCritico.Items.FindByValue(0.ToString()).Selected = true;
            }
        }

        private DateTime? _dataNascimento;
        public DateTime? DataNascimento
        {
            get
            {
                return _dataNascimento;
            }
            set
            {
                this._dataNascimento = value;
                txtDataNascimentoFA.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy") : String.Empty;
            }
        }

        public async Task populaCampos(int FormularioId)
        {
            await PopulaQuestion();
            FormularioAcordoBll formularioAcordoBll = new FormularioAcordoBll();
            var f = await formularioAcordoBll.readAsync(FormularioId);
            if (f != null)
            {
                this.DataAcordo = f.DataAcordo;
                this.Mes = f.Mes;
                this.DataUltimaAcao = f.DataUltimaAcao;
                this.Cenario = f.Cenario;
                this.MotivoProcesso = f.MotivoProcesso;
                this.Fechamento = f.Fechamento;
                this.ValorSolicitado = f.ValorSolicitado;
                this.ValorAlcada = f.ValorAlcada;
                this.ValorAcordoDanosMorais = f.ValorAcordoDanosMorais;
                this.ValorAcordoDanosMateriais = f.ValorAcordoDanosMateriais;
                this.ValorAcordoObriogacao = f.ValorAcordoObriogacao;
                this.ContatoCom = f.ContatoCom;
                this.Email = f.Email;
                this.Telefone = f.Telefone;
                this.Alcada = f.Alcada;
                this.Estado = f.Estado;
                this.Critico = f.Critico;
                this.DataNascimento = f.DataNascimento;
            }
        }

        public bool Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    FormularioAcordoBll formularioAcordoBll = new FormularioAcordoBll();
                    FormularioAcordo f;

                    f = formularioAcordoBll.read(FormularioId);
                    if (f == null)
                        f = new FormularioAcordo();

                    f.formularioId = FormularioId;
                    if (Util.ISDate(txtDtAcordo.Text))
                        f.DataAcordo = DateTime.Parse(txtDtAcordo.Text);
                    else
                        f.DataAcordo = null;
                    if (Util.ISDate(txtMesAno.Text))
                        f.Mes = DateTime.Parse(txtMesAno.Text);
                    else
                        f.Mes = null;
                    if (Util.ISDate(txtDataUltimaAcaoFA.Text))
                        f.DataUltimaAcao = DateTime.Parse(txtDataUltimaAcaoFA.Text);
                    else
                        f.DataUltimaAcao = null;

                    f.Cenario = txtCenario.Text.TrimEnd();
                    if (ddlMotivoProcesso.SelectedValue != "0")
                        f.MotivoProcesso = Convert.ToInt32(ddlMotivoProcesso.SelectedValue);
                    else
                        f.MotivoProcesso = null;
                    if (ddlFechamento.SelectedValue != "0")
                        f.Fechamento = Convert.ToInt32(ddlFechamento.SelectedValue);
                    else
                        f.Fechamento = null;

                    f.ValorSolicitado = txtValorSolicitadoFA.Text == "" ? 0 : Convert.ToDecimal(txtValorSolicitadoFA.Text.Replace("R$ ", ""));
                    f.ValorAlcada = txtValorAlcadaFA.Text == "" ? 0 : Convert.ToDecimal(txtValorAlcadaFA.Text.Replace("R$ ", ""));
                    f.ValorAcordoDanosMorais = txtAcordoRealizadoMoralFA.Text == "" ? 0 : Convert.ToDecimal(txtAcordoRealizadoMoralFA.Text.Replace("R$ ", ""));
                    f.ValorAcordoDanosMateriais = txtAcordoRealizadoMaterialFA.Text == "" ? 0 : Convert.ToDecimal(txtAcordoRealizadoMaterialFA.Text.Replace("R$ ", ""));
                    f.ValorAcordoObriogacao = txtAcordoRealizadoObricacaoFA.Text == "" ? 0 : Convert.ToDecimal(txtAcordoRealizadoObricacaoFA.Text.Replace("R$ ", ""));
                    if (ddlContatoCom.SelectedValue != "0")
                        f.ContatoCom = Convert.ToInt32(ddlContatoCom.SelectedValue);
                    else
                        f.ContatoCom = null;

                    f.Email = txtEmailAdvogado.Text.TrimEnd();
                    f.Telefone = txtTelefoneFA.Text.Replace(")", "").Replace("(", "").Replace("-", "").Replace(" ", "").Trim();

                    if (ddlAlcada.SelectedValue != "0")
                        f.Alcada = Convert.ToInt32(ddlAlcada.SelectedValue);
                    else
                        f.Alcada = null;

                    if (ddlEstado.SelectedValue != "0")
                        f.Estado = Convert.ToInt32(ddlEstado.SelectedValue);
                    else
                        f.Estado = null;

                    if (ddlCritico.SelectedValue != "0")
                        f.Critico = Convert.ToInt32(ddlCritico.SelectedValue);
                    else
                        f.Critico = null;

                    if (Util.ISDate(txtDataNascimentoFA.Text))
                        f.DataNascimento = DateTime.Parse(txtDataNascimentoFA.Text);
                    else
                        f.DataNascimento = null;

                    formularioAcordoBll.save(f);

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

    }
}