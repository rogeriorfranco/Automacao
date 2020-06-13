using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.template
{
    public partial class UserControlQuestao5 : System.Web.UI.UserControl
    {
        public int tipoFormulario;
        public void Page_Load(object sender, EventArgs e)
        {
        }

        private void disabilitaCamposReabertura(string status)
        {
            StatusReaberturaBll srBll = new StatusReaberturaBll();

            if (srBll.listAll().Contains(status))
            {
                pPrincipal5.Visible = false;
            }
        }

        //private void escondeDivSubsidio(string tipo)
        //{
        //    if (tipo.Equals("Subsídio"))
        //        pPrincipal5.Visible = false;
        //}

        private async Task checkedAcordo(string tipo, long idCaso)
        {
            if ((tipo != null) && !tipo.Equals("Subsídio"))
            {
                Questao5Bll questao5Bll = new Questao5Bll();
                var q = await questao5Bll.readCheckAcordo(idCaso);
                if ((q != null) && q.AcordoPrevio == false)
                {
                    rbAcordoPrevio.SelectedValue = "0";

                    this.DataTentativa1 = q.DataTentativa1;
                    this.DataTentativa2 = q.DataTentativa2;
                    this.DataTentativa3 = q.DataTentativa3;
                    this.Hora1 = q.DataTentativa1.ToString();
                    this.Hora2 = q.DataTentativa2.ToString();
                    this.Hora3 = q.DataTentativa3.ToString();
                    this.ValorProposta1 = q.ValorProposta1;
                    this.ValorProposta2 = q.ValorProposta2;
                    this.ValorProposta3 = q.ValorProposta3;
                    //rfReclamacaoCliente.Enabled = false;
                    this.ValorPropostaAcordo = q.ValorPropostaAcordo;
                    this.Comentario1 = q.Comentario1;
                    this.Comentario2 = q.Comentario2;
                    this.Comentario3 = q.Comentario3;
                }
            }
            else
            { pPrincipal5.Visible = false; }
        }

        private DateTime? _dataTentativa1;
        public DateTime? DataTentativa1
        {
            get
            {
                return _dataTentativa1;
            }
            set
            {
                this._dataTentativa1 = value;
                txtDataHorario1.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy") : String.Empty;
            }
        }

        private DateTime? _dataTentativa2;
        public DateTime? DataTentativa2
        {
            get
            {
                return _dataTentativa2;
            }
            set
            {
                this._dataTentativa2 = value;
                txtDataHorario2.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy") : String.Empty;
            }
        }

        private DateTime? _dataTentativa3;
        public DateTime? DataTentativa3
        {
            get
            {
                return _dataTentativa3;
            }
            set
            {
                this._dataTentativa3 = value;
                txtDataHorario3.Text = !String.IsNullOrEmpty(value.ToString()) ? String.Format(value.ToString(), "dd/MM/yyyy") : String.Empty;
            }
        }

        private string _hora1;
        public string Hora1
        {
            get
            {
                return _hora1;
            }
            set
            {
                this._hora1 = value;
                txtHora1.Text = !String.IsNullOrEmpty(value) ? value.Substring(11, 5) : String.Empty;
            }
        }

        private string _hora2;
        public string Hora2
        {
            get
            {
                return _hora2;
            }
            set
            {
                this._hora2 = value;
                txtHora2.Text = !String.IsNullOrEmpty(value) ? value.Substring(11, 5) : String.Empty;
            }
        }

        private string _hora3;
        public string Hora3
        {
            get
            {
                return _hora3;
            }
            set
            {
                this._hora3 = value;
                txtHora3.Text = !String.IsNullOrEmpty(value) ? value.Substring(11, 5) : String.Empty;
            }
        }

        private Decimal? _valorProposta1;
        public Decimal? ValorProposta1
        {
            get
            {
                return _valorProposta1;
            }
            set
            {
                this._valorProposta1 = value;
                txtValorProposta1.Text = value != null ? value.ToString() : String.Empty;
            }
        }

        private Decimal? _valorProposta2;
        public Decimal? ValorProposta2
        {
            get
            {
                return _valorProposta2;
            }
            set
            {
                this._valorProposta2 = value;
                txtValorProposta2.Text = value != null ? value.ToString() : String.Empty;
            }
        }


        private Decimal? _valorProposta3;
        public Decimal? ValorProposta3
        {
            get
            {
                return _valorProposta3;
            }
            set
            {
                this._valorProposta3 = value;
                txtValorProposta3.Text = value != null ? value.ToString() : String.Empty;
            }
        }


        private Decimal? _valorPropostaAcordo;
        public Decimal? ValorPropostaAcordo
        {
            get
            {
                return _valorPropostaAcordo;
            }
            set
            {
                this._valorPropostaAcordo = value;
                txtValorPropostaAcordo.Text = value != null ? value.ToString() : String.Empty;
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
                    ddlReclamacaoCliente.SelectedValue = value.ToString();
                else
                    ddlReclamacaoCliente.Items.FindByValue(0.ToString()).Selected = true;

            }
        }


        private bool? _acordoPrevio;
        public bool? AcordoPrevio
        {
            get
            {
                return _acordoPrevio;
            }
            set
            {
                this._acordoPrevio = value;
                if (value != null)
                    rbAcordoPrevio.SelectedValue = value == true ? 1.ToString() : 0.ToString();
                else
                    rbAcordoPrevio.SelectedValue = "";
            }
        }

        private string _comentario1;
        public string Comentario1
        {
            get
            {
                return _comentario1;
            }
            set
            {
                this._comentario1 = value;
                txtComentario1.Text = value != null ? value.ToString() : string.Empty;
            }
        }

        private string _comentario2;
        public string Comentario2
        {
            get
            {
                return _comentario2;
            }
            set
            {
                this._comentario2 = value;
                txtComentario2.Text = value != null ? value.ToString() : string.Empty;
            }
        }

        private string _comentario3;
        public string Comentario3
        {
            get
            {
                return _comentario3;
            }
            set
            {
                this._comentario3 = value;
                txtComentario3.Text = value != null ? value.ToString() : string.Empty;
            }
        }

        public Panel panelPrincipal5
        {
            get
            {
                return pPrincipal5;
            }
            set
            {
                pPrincipal5 = value;
            }
        }

        private async Task carregaReclCliente()
        {
            try
            {
                ReclamacaoClienteBLL reclamacaoClienteBLL = new ReclamacaoClienteBLL();
                var list = await reclamacaoClienteBLL.listAsyncAll();
                Util.CarregaControle(ddlReclamacaoCliente, list, false);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task populaCampos(int FormularioId, string status, long idCaso, string tipoDemanda)
        {
            disabilitaCamposReabertura(status);
            await checkedAcordo(tipoDemanda, idCaso);

            if (pPrincipal5.Visible)
            {
                await carregaReclCliente();
                Questao5Bll questao5Bll = new Questao5Bll();
                var q = await questao5Bll.readAsync(FormularioId);
                if (q != null)
                {
                    ViewState["idQuestao"] = q.id;
                    this.DataTentativa1 = q.DataTentativa1;
                    this.DataTentativa2 = q.DataTentativa2;
                    this.DataTentativa3 = q.DataTentativa3;
                    this.Hora1 = q.DataTentativa1.ToString();
                    this.Hora2 = q.DataTentativa2.ToString();
                    this.Hora3 = q.DataTentativa3.ToString();
                    this.ValorProposta1 = q.ValorProposta1;
                    this.ValorProposta2 = q.ValorProposta2;
                    this.ValorProposta3 = q.ValorProposta3;
                    this.AcordoPrevio = q.AcordoPrevio;
                    if (AcordoPrevio == true)
                    {
                        dvAcordoPrevio.Style.Add("display", "block");
                        reclClienteID.Style.Add("display", "block");
                        dvAcordoPrevio.Style.Add("display", "block");
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "hide", "$('#UserControlQuestao3_4_pPrincipal4').hide();", true);
                    }
                    else
                    {
                        if (this.tipoFormulario == Convert.ToInt16(Util.TFormulario.AcordoPrevio))
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "hide", "$('#UserControlQuestao6_pPrincipal6').hide();", true);
                        //else
                        //    rfReclamacaoCliente.Enabled = false;
                    }

                    this.ValorPropostaAcordo = q.ValorPropostaAcordo;
                    this.ReclamacaoCliente = q.reclamacaoClienteId;

                    this.Comentario1 = q.Comentario1;
                    this.Comentario2 = q.Comentario2;
                    this.Comentario3 = q.Comentario3;
                }
            }
        }

        public void Salvar(int FormularioId)
        {
            try
            {
                if (FormularioId > 0)
                {
                    Questao5Bll questao5Bll = new Questao5Bll();
                    Questao5 q = new Questao5();

                    q.id = Convert.ToInt32(ViewState["idQuestao"]);
                    IFormatProvider culture = new CultureInfo("pt-BR", true);
                    q.formularioId = FormularioId;
                    if (Util.ISDate(txtDataHorario1.Text))
                        q.DataTentativa1 = DateTime.ParseExact(txtDataHorario1.Text + " " + (txtHora1.Text.Length == 5 ? txtHora1.Text + ":00" : "00:00:00"), "dd/MM/yyyy HH:mm:ss", culture);
                    else
                        q.DataTentativa1 = null;
                    if (Util.ISDate(txtDataHorario2.Text))
                        q.DataTentativa2 = DateTime.ParseExact(txtDataHorario2.Text + " " + (txtHora2.Text.Length == 5 ? txtHora2.Text + ":00" : "00:00:00"), "dd/MM/yyyy HH:mm:ss", culture);
                    else
                        q.DataTentativa2 = null;
                    if (Util.ISDate(txtDataHorario3.Text))
                        q.DataTentativa3 = DateTime.ParseExact(txtDataHorario3.Text + " " + (txtHora3.Text.Length == 5 ? txtHora3.Text + ":00" : "00:00:00"), "dd/MM/yyyy HH:mm:ss", culture);
                    else
                        q.DataTentativa3 = null;

                    if (ddlReclamacaoCliente.SelectedValue != "0")
                        q.reclamacaoClienteId = Convert.ToInt32(ddlReclamacaoCliente.SelectedValue);
                    else
                        q.reclamacaoClienteId = null;

                    q.ValorProposta1 = txtValorProposta1.Text == "" ? 0 : Convert.ToDecimal(txtValorProposta1.Text.Replace("R$ ", ""));
                    q.ValorProposta2 = txtValorProposta2.Text == "" ? 0 : Convert.ToDecimal(txtValorProposta2.Text.Replace("R$ ", ""));
                    q.ValorProposta3 = txtValorProposta3.Text == "" ? 0 : Convert.ToDecimal(txtValorProposta3.Text.Replace("R$ ", ""));
                    q.ValorPropostaAcordo = txtValorPropostaAcordo.Text == "" ? 0 : Convert.ToDecimal(txtValorPropostaAcordo.Text.Replace("R$ ", ""));
                    q.AcordoPrevio = rbAcordoPrevio.SelectedValue == "1" ? true : false;

                    if (q.AcordoPrevio == false)
                        q.reclamacaoClienteId = null;

                    q.Comentario1 = string.IsNullOrEmpty(txtComentario1.Text) ? null : txtComentario1.Text.TrimEnd();
                    q.Comentario2 = string.IsNullOrEmpty(txtComentario2.Text) ? null : txtComentario2.Text.TrimEnd();
                    q.Comentario3 = string.IsNullOrEmpty(txtComentario3.Text) ? null : txtComentario3.Text.TrimEnd();

                    questao5Bll.save(q);
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