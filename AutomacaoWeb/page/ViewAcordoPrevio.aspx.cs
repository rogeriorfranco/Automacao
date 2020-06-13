using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI;

namespace AutomacaoWeb.page
{

    public partial class ViewAcordoPrevio : System.Web.UI.Page
    {
        private async Task populaCampos()
        {
            try
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id_caso"]))
                {
                    Formulario form = new Formulario();
                    FormularioBll formularioBll = new FormularioBll();

                    var id_caso = int.Parse(Util.Decrypt(Request.QueryString["id_caso"]));
                    lblSubTituloCaso.Text = id_caso.ToString();
                    form = await formularioBll.readAsync(id_caso, (int)Util.TFormulario.AcordoPrevio);
                    if (form != null)
                    {
                        UserControlHeader.cliente = form.cliente;
                        UserControlHeader.cpf = form.cpf;
                        UserControlHeader.linha = form.nro_linha;
                        UserControlHeader.contrato = form.nro_contrato;
                        UserControlHeader.processo = form.nro_processo;
                        UserControlHeader.reclamacaoCliente = form.reclamacao_cliente;
                        UserControlHeader.reclamacao = form.resumo_reclamacao;
                        UserControlHeader.obs = form.observacoes;
                        UserControlHeader.escritorio = form.escritorio;
                        UserControlHeader.dataAudiencia = form.dt_audiencia;
                        UserControlHeader.valorRequerido = form.valor_requerido != null ? string.Format("{0:C}", Convert.ToDecimal(form.valor_requerido)) : string.Empty;
                        hfFormularioId.Value = form.id.ToString();

                        if (form.status != null)
                            lblStatusReabertura.Text = string.Concat(" Reabertura: ", form.status);

                        AcordoPrevioBll acordoPrevioBll = new AcordoPrevioBll();
                        var f = await acordoPrevioBll.read(form.id);

                        if (f != null)
                        {
                            hfId.Value = f.id.ToString();
                            rbQuestao_1.SelectedValue = f.questao_1;
                            txtObsQuestao_1.Text = f.obs_questao_1;
                            rbQuestao_1_1_0.SelectedValue = f.questao_1_1;
                            txtObsQuestao_1_1.Text = f.obs_questao_1_1;
                            rbQuestao_1_2_0.SelectedValue = f.questao_1_2;
                            txtObsQuestao_1_2.Text = f.obs_questao_1_2;
                            rbQuestao_1_3_0.SelectedValue = f.questao_1_3;
                            txtObsQuestao_1_3.Text = f.obs_questao_1_3;
                            rbQuestao_1_4_0.SelectedValue = f.questao_1_4;
                            txtObsQuestao_1_4.Text = f.obs_questao_1_4;
                            txtObsQuestao_2.Text = f.obs_questao_2;
                            txtObsQuestao_3.Text = f.obs_questao_3;
                            rbQuestao_4.SelectedValue = f.questao_4;
                            txtObsQuestao_4.Text = f.obs_questao_4;
                            rbQuestao_5.SelectedValue = f.questao_5;
                            txtObsQuestao_5.Text = f.obs_questao_5;
                            txtObsQuestao_6.Text = f.obs_questao_6;
                            rbQuestao_6.SelectedValue = f.questao_6;
                            txtObsQuestao_7.Text = f.obs_questao_7;
                            rbQuestao_7.SelectedValue = f.questao_7;
                            txtObsQuestao_9.Text = f.obs_questao_9;
                            txtConsideracoesFinais.Text = f.consideracao;
                        }

                        UserControlExecQuestao1.tipoFormulario = Convert.ToInt16(Util.TFormulario.AcordoPrevio);                      
                        UserControlQuestao5.tipoFormulario = Convert.ToInt16(Util.TFormulario.AcordoPrevio);
                        UserControlFormularioAcordo.tipoFormulario = Convert.ToInt16(Util.TFormulario.AcordoPrevio);

                        await UserControlExecQuestao1.PopulaQuestao1(form.id, form.status, form.empresa, form.produto, form.estado, form.cidade);
                        await UserControlQuestao3_4.populaCampos(form.id, form.status, form.tipoFormularioId);
                        await UserControlQuestao5.populaCampos(form.id, form.status, form.id_caso, form.tipo_demanda);
                        await UserControlQuestao6.populaCampos(form.id, form.status);
                        await UserControlQuestao7.populaCampos(form.id, form.status);
                        await UserControlFormularioAcordo.populaCampos(form.id);

                        await UserControlQuestao11.populaCampos(form.id, form.status);
                        await UserControlQuestao12.populaCampos(form.id, form.status);
                        await UserControlQuestao14.populaCampos(form.id, form.status);
                    }
                    else { ScriptManager.RegisterStartupScript(Page, Page.GetType(), "closeWindow", "window.close();", true); }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        private void update(AcordoPrevio a)
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                AcordoPrevioBll acordoPrevioBll = new AcordoPrevioBll();

                a.id = string.IsNullOrEmpty(hfId.Value) ? 0 : Convert.ToInt32(hfId.Value);
                a.formularioId = Convert.ToInt32(hfFormularioId.Value);
                a.questao_1 = rbQuestao_1.SelectedValue;
                a.obs_questao_1 = string.IsNullOrEmpty(txtObsQuestao_1.Text) ? null : txtObsQuestao_1.Text;
                a.questao_1_1 = rbQuestao_1_1_0.SelectedValue;
                a.obs_questao_1_1 = string.IsNullOrEmpty(txtObsQuestao_1_1.Text) ? null : txtObsQuestao_1_1.Text;
                a.questao_1_2 = rbQuestao_1_2_0.SelectedValue;
                a.obs_questao_1_2 = string.IsNullOrEmpty(txtObsQuestao_1_2.Text) ? null : txtObsQuestao_1_2.Text;
                a.questao_1_3 = rbQuestao_1_3_0.SelectedValue;
                a.obs_questao_1_3 = string.IsNullOrEmpty(txtObsQuestao_1_3.Text) ? null : txtObsQuestao_1_3.Text;
                a.questao_1_4 = rbQuestao_1_4_0.SelectedValue;
                a.obs_questao_1_4 = string.IsNullOrEmpty(txtObsQuestao_1_4.Text) ? null : txtObsQuestao_1_4.Text;
                a.obs_questao_2 = string.IsNullOrEmpty(txtObsQuestao_2.Text) ? null : txtObsQuestao_2.Text;
                a.obs_questao_3 = string.IsNullOrEmpty(txtObsQuestao_3.Text) ? null : txtObsQuestao_3.Text;
                a.obs_questao_4 = string.IsNullOrEmpty(txtObsQuestao_4.Text) ? null : txtObsQuestao_4.Text;
                a.questao_4 = rbQuestao_4.SelectedValue;
                a.obs_questao_5 = string.IsNullOrEmpty(txtObsQuestao_5.Text) ? null : txtObsQuestao_5.Text;
                a.questao_5 = rbQuestao_5.SelectedValue;
                a.obs_questao_6 = string.IsNullOrEmpty(txtObsQuestao_6.Text) ? null : txtObsQuestao_6.Text;
                a.questao_6 = rbQuestao_6.SelectedValue;
                a.obs_questao_7 = string.IsNullOrEmpty(txtObsQuestao_7.Text) ? null : txtObsQuestao_7.Text;
                a.questao_7 = rbQuestao_7.SelectedValue;
                a.consideracao = string.IsNullOrEmpty(txtConsideracoesFinais.Text) ? null : txtConsideracoesFinais.Text;
                a.obs_questao_9 = string.IsNullOrEmpty(txtObsQuestao_9.Text) ? null : txtObsQuestao_9.Text;

                acordoPrevioBll.save(a);
                formularioBll.update(a.formularioId, UserControlHeader.linha, UserControlHeader.contrato, (a.preenchimentoCompleto == true ? true : false));

                UserControlExecQuestao1.Salvar(a.formularioId);

                if (UserControlQuestao3_4.panelPrincipal3.Visible)
                    UserControlQuestao3_4.SaveQuestao3_4(a.formularioId);

                if (UserControlQuestao5.panelPrincipal5.Visible)
                    UserControlQuestao5.Salvar(a.formularioId);

                if (UserControlQuestao6.panelPrincipal6.Visible)
                    UserControlQuestao6.Salvar(a.formularioId);

                UserControlQuestao7.Salvar(a.formularioId);

                UserControlFormularioAcordo.Salvar(a.formularioId);

                if (UserControlQuestao11.panelPrincipal11.Visible)
                    UserControlQuestao11.Salvar(a.formularioId);

                if (UserControlQuestao12.panelPrincipal12.Visible)
                    UserControlQuestao12.Salvar(a.formularioId);

                if (UserControlQuestao14.panelPrincipal14.Visible)
                    UserControlQuestao14.Salvar(a.formularioId);

                Util.Alertbootsrap("Dados atualizados", this, upSalvar);

            }
            catch (Exception ex)
            {
                Util.Alertbootsrap(string.Concat(ex.Message, " - ", ex.InnerException), this, upSalvar);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Page.IsPostBack)
                {
                    RegisterAsyncTask(new PageAsyncTask(populaCampos));
                }

            }
            catch (Exception ex)
            {
                Util.Alertbootsrap(ex.Message, this, upSalvar);
            }
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            AcordoPrevio a = new AcordoPrevio();
            a.preenchimentoCompleto = false;
            update(a);
        }

        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            AcordoPrevio a = new AcordoPrevio();
            a.preenchimentoCompleto = true;
            update(a);
        }
    }
}