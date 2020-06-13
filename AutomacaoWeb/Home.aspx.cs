using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Data;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AutomacaoWeb
{
    public partial class Home : System.Web.UI.Page
    {
        Formulario form = new Formulario();

        FormularioBll formBLL = new FormularioBll();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Util.Encrypt("12365659"));

            if (!Page.IsPostBack)
            {
                Page.Form.DefaultButton = lbPesquisar.UniqueID;
                selecionaSubsidio();
            }
        }
        protected void rbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "ScritpMask", "atribuiRadio();", true);
            cSubisidio.Visible = false;

            switch (rbList.SelectedValue)
            {
                case "2":
                    if (validaIdCaso())
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewAcordoPrevio?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "3":
                    if (validaIdCaso())
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewExecLimiDesc?id_caso=" + Request.QueryString["id_caso"] + "&tipo=3','_blank');", true);
                    break;

                case "4":
                    if (validaIdCaso())
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewExecLimiDesc?id_caso=" + Request.QueryString["id_caso"] + "&tipo=4','_blank');", true);
                    break;

                case "5":
                    if (validaIdCaso())
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewExecLimiDesc?id_caso=" + Request.QueryString["id_caso"] + "&tipo=5','_blank');", true);
                    break;

                case "6":
                    cSubisidio.Visible = true;
                    break;
            }
        }
        private void atualizaSubsidio(int formularioId, bool remove)
        {
            if (remove)
            {
                Tuple<int, string, string> t = (Tuple<int, string, string>)ViewState["tCasoSubsidioExistente"];
                formBLL.deleteFormulario(t.Item1, t.Item3);
            }

            Formulario f = new Formulario();
            var id_caso = int.Parse(Util.Decrypt(Request.QueryString["id_caso"]));
            f = formBLL.read((int)id_caso);
            if (f != null)
            {
                if (f.tipoFormularioId != formularioId)
                {
                    f.tipoFormularioId = formularioId;
                    formBLL.save(f);
                }
                salvaLog(formularioId, id_caso);
            }
            else
            {
                throw new Exception("Sub não existe");
            }
        }
        private void salvaLog(int formularioId, int idCaso)
        {
            LogMudancaFormulariomBll logBll = new LogMudancaFormulariomBll();
            LogMudancaFormulario log = new LogMudancaFormulario();
            log.tipoFormularioId = formularioId;
            log.id_caso = idCaso;
            logBll.save(log);
        }
        protected void cSubisidio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cSubisidio.SelectedValue != "0")
                {
                    if (validaIdCaso())
                    {
                        Tuple<int, string, string> t = (Tuple<int, string, string>)ViewState["tCasoSubsidioExistente"];

                        if ((t != null) && !t.Item2.Equals(cSubisidio.SelectedItem.Text))
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendLine("$('.modal-body #textModalId').html('" + string.Concat("Este formulário já foi foi salvo como ", t.Item2.ToUpper(), ", a alteração para outro TIPO DE FORMULÁRIO irá REMOVER todos os dados já preenchidos, DESEJA CONTINUAR?") + "') ");
                            sb.AppendLine("$('#confirmModal').modal('show');");
                            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "showPop", sb.ToString(), true);
                        }
                        else
                        {
                            redirecionaFormularioSubsidio(false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Util.Alertbootsrap(ex.Message, this, upList);
            }
        }
        private void selecionaSubsidio()
        {
            if (Request.QueryString["subsidio"] != null)
            {
                rbList.SelectedValue = "6";
                rbList.Items.FindByValue("2").Enabled = false;
                rbList.Items.FindByValue("3").Enabled = false;
                rbList.Items.FindByValue("4").Enabled = false;
                rbList.Items.FindByValue("5").Enabled = false;
                cSubisidio.Visible = true;
            }
            if (Request.QueryString["id_caso"] != null)
            {
                lblSubTituloCaso.Text = Util.Decrypt(Request.QueryString["id_caso"]);
                checkCasoCadastrado(Convert.ToInt32(lblSubTituloCaso.Text));
            }

        }
        private bool validaIdCaso()
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id_caso"]))
            {
                return true;
            }
            else
            {
                Util.Alertbootsrap("ID do caso inexistente!", this, upSubisdio);
                return false;
            }
        }
        private void checkCasoCadastrado(int idCaso)
        {
            FormularioBll form = new FormularioBll();
            var f = form.subsidioPreenchido(idCaso);
            if (f != null)
                ViewState["tCasoSubsidioExistente"] = f;

            
            LogMudancaFormulariomBll logBll = new LogMudancaFormulariomBll();
            string tipo = logBll.readTipo(idCaso);

            if (!string.IsNullOrEmpty(tipo))
                rbList.Items.FindByValue("6").Text = string.Concat("Subsídio", "(", tipo, ")");


        }
        private void redirecionaFormularioSubsidio(bool remove)
        {
            switch (cSubisidio.SelectedValue)
            {
                case "1":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewFraude?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "6":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewAcidente?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "7":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewPortabilidade?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "8":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewProblemasComVendas?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "9":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewMigracaoIndevida?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "10":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewNegativacaoIndevida?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "11":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewCancelamento?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "12":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewEntregaAparelho?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "13":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewProblemasTecnicos?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;

                case "14":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewServicosAdicionais?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;
                case "16":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewRedeCobertura?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;
                case "17":
                    atualizaSubsidio(Convert.ToInt32(cSubisidio.SelectedValue), remove);
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewOutros?id_caso=" + Request.QueryString["id_caso"] + "','_blank');", true);
                    break;
            }
        }
        protected void btnProcess_Click(object sender, EventArgs e)
        {
            redirecionaFormularioSubsidio(true);
        }

        private void carregaGrid()
        {
            Session["sourceDt"] = formBLL.listaFormulario((string.IsNullOrEmpty(txtCaso.Text) ? 0 : Convert.ToInt32(txtCaso.Text)),
            (string.IsNullOrEmpty(txtCliente.Text) ? null : txtCliente.Text),
            (string.IsNullOrEmpty(txtCpf.Text) ? null : txtCpf.Text),
            ddlTipo.SelectedValue);

            DataTable total = (DataTable)Session["sourceDt"];
            lblTotDemanda.Text = string.Concat("Total:  ", total.Rows.Count.ToString());

            gv.DataSource = Session["sourceDt"];
            gv.DataBind();
        }

        protected void lbPesquisar_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        protected void gv_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gv.DataSource = Session["sourceDt"];
            gv.PageIndex = e.NewPageIndex;
            gv.DataBind();
        }

        protected void gv_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                switch (Server.HtmlDecode(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text))
                {
                    case "Acordo Prévio":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewAcordoPrevio?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "Execução":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewExecLimiDesc?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "&tipo=3','_blank');", true);
                        break;

                    case "Liminar":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewExecLimiDesc?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "&tipo=4','_blank');", true);
                        break;

                    case "Descumprimento":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewExecLimiDesc?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "&tipo=5','_blank');", true);
                        break;

                    case "Fraude":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewFraude?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "Acidente":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewAcidente?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "Portabilidade":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewPortabilidade?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "ProblemasComVendas":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewProblemasComVendas?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "MigracaoIndevida":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewMigracaoIndevida?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "NegativacaoIndevida":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewNegativacaoIndevida?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "Cancelamento":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewCancelamento?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "EntregaAparelho":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewEntregaAparelho?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "ProblemaTecnico":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewProblemasTecnicos?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "ServicoAdicional":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewServicosAdicionais?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "RedeCobertura":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewRedeCobertura?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;

                    case "Outros":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('page/ViewOutros?id_caso=" + Util.Encrypt(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text) + "','_blank');", true);
                        break;
                }
            }

            if (e.CommandName == "Download")
            {
                switch (Server.HtmlDecode(gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[3].Text))
                {
                    case "Acordo Prévio":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptAcordoPrevio?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "Execução":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptExecLimiDesc?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "&tipo=3');", true);
                        break;

                    case "Liminar":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptExecLimiDesc?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "&tipo=4');", true);
                        break;

                    case "Descumprimento":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptExecLimiDesc?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "&tipo=5');", true);
                        break;

                    case "Fraude":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptFraude?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "Acidente":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptAcidente?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "Portabilidade":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptPortabilidade?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "ProblemasComVendas":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptProblemasComVendas?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "MigracaoIndevida":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptMigracaoIndevida?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "NegativacaoIndevida":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptNegativacaoIndevida?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "Cancelamento":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptCancelamento?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "EntregaAparelho":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptEntregaAparelho?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "ProblemaTecnico":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptProblemasTecnicos?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "ServicoAdicional":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptServicosAdicionais?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "RedeCobertura":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptRedeCobertura?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;

                    case "Outros":
                        ScriptManager.RegisterStartupScript(Page, Page.GetType(), "newWindow", "window.open('template/rptOutros?id_caso=" + gv.Rows[Convert.ToInt32(e.CommandArgument)].Cells[2].Text + "');", true);
                        break;
                }
            }

        }

        protected void gv_RowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                LinkButton lbEdit = (LinkButton)e.Row.FindControl("lbEdit");
                lbEdit.CommandArgument = e.Row.RowIndex.ToString();

                LinkButton lbPdf = (LinkButton)e.Row.FindControl("lbPdf");
                lbPdf.CommandArgument = e.Row.RowIndex.ToString();
            }
        }
    }
}