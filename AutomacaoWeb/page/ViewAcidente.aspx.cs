using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI;

namespace AutomacaoWeb.page
{
    public partial class ViewAcidente : System.Web.UI.Page
    {
        private async Task populaCampos()
        {
            try
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id_caso"]))
                {
                    Formulario form = new Formulario();
                    FormularioBll formularioBll = new FormularioBll();
                    var id_caso  = int.Parse(Util.Decrypt(Request.QueryString["id_caso"]));
                    lblSubTituloCaso.Text = id_caso.ToString();

                    form = await formularioBll.readAsync(id_caso, (int)Util.TFormulario.Acidente);
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

                        AcidenteBLL acidenteBll = new AcidenteBLL();
                        var f = await acidenteBll.read(form.id);
                        if (f != null)
                        {
                            hfId.Value = f.id.ToString();

                            rbQuestao_1.SelectedValue = f.questao_1;
                            txtObsQuestao_1.Text = f.obs_questao_1;
                            rbQuestao_2.SelectedValue = f.questao_2;
                            txtObsQuestao_2.Text = f.obs_questao_2;
                            rbQuestao_3.SelectedValue = f.questao_3;
                            txtObsQuestao_3.Text = f.obs_questao_3;
                            rbQuestao_4.SelectedValue = f.questao_4;
                            txtObsQuestao_4.Text = f.obs_questao_4;
                            rbQuestao_5.SelectedValue = f.questao_5;
                            txtObsQuestao_5.Text = f.obs_questao_5;
                            rbQuestao_6.SelectedValue = f.questao_6;
                            txtObsQuestao_6.Text = f.obs_questao_6;
                            rbQuestao_7.SelectedValue = f.questao_7;
                            txtObsQuestao_7.Text = f.obs_questao_7;
                            rbQuestao_8.SelectedValue = f.questao_8;
                            txtObsQuestao_8.Text = f.obs_questao_8;
                            rbQuestao_9.SelectedValue = f.questao_9;
                            txtObsQuestao_9.Text = f.obs_questao_9;
                            rbQuestao_10.SelectedValue = f.questao_10;
                            txtObsQuestao_10.Text = f.obs_questao_10;
                            rbQuestao_11.SelectedValue = f.questao_11;
                            txtObsQuestao_11.Text = f.obs_questao_11;
                            rbQuestao_12.SelectedValue = f.questao_12;
                            txtObsQuestao_12.Text = f.obs_questao_12;
                            rbQuestao_13.SelectedValue = f.questao_13;
                            txtObsQuestao_13.Text = f.obs_questao_13;
                            rbQuestao_14.SelectedValue = f.questao_14;
                            txtObsQuestao_14.Text = f.obs_questao_14;
                            rbQuestao_15.SelectedValue = f.questao_15;
                            txtObsQuestao_15.Text = f.obs_questao_15;
                            rbQuestao_16.SelectedValue = f.questao_16;
                            txtObsQuestao_16.Text = f.obs_questao_16;
                            rbQuestao_17.SelectedValue = f.questao_17;
                            txtObsQuestao_17.Text = f.obs_questao_17;
                            rbQuestao_18.SelectedValue = f.questao_18;
                            txtObsQuestao_18.Text = f.obs_questao_18;
                            rbQuestao_19.SelectedValue = f.questao_19;
                            txtObsQuestao_19.Text = f.obs_questao_19;
                            rbQuestao_20.SelectedValue = f.questao_20;
                            txtObsQuestao_20.Text = f.obs_questao_20;
                            txtConsideracoesFinais.Text = f.consideracao;
                            txtObsQuestao_22.Text = f.obs_questao_22;
                        }

                        UserControlExecQuestao1.tipoFormulario = Convert.ToInt16(Util.TFormulario.Acidente);                      
                        UserControlQuestao5.tipoFormulario = Convert.ToInt16(Util.TFormulario.Acidente);


                        await UserControlExecQuestao1.PopulaQuestao1(form.id, form.status, form.empresa, form.produto, form.estado, form.cidade);
                        await UserControlQuestao3_4.populaCampos(form.id, form.status, form.tipoFormularioId);
                        await UserControlQuestao5.populaCampos(form.id, form.status, form.id_caso, form.tipo_demanda);
                        await UserControlQuestao6.populaCampos(form.id, form.status);
                        await UserControlQuestao7.populaCampos(form.id, form.status);

                        await UserControlQuestao11.populaCampos(form.id, form.status);
                        await UserControlQuestao12.populaCampos(form.id, form.status);
                        await UserControlQuestao14.populaCampos(form.id, form.status);
                        await UserControlOcorrenciaNet.populaCampos(form.id);

                    }
                    else { ScriptManager.RegisterStartupScript(Page, Page.GetType(), "closeWindow", "window.close();", true); }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void update(Acidente a)
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                AcidenteBLL acidenteBll = new AcidenteBLL();

                a.id = string.IsNullOrEmpty(hfId.Value) ? 0 : Convert.ToInt32(hfId.Value);
                a.formularioId = Convert.ToInt32(hfFormularioId.Value);
                a.questao_1 = rbQuestao_1.SelectedValue;
                a.obs_questao_1 = string.IsNullOrEmpty(txtObsQuestao_1.Text) ? null : txtObsQuestao_1.Text;
                a.questao_2 = rbQuestao_2.SelectedValue;
                a.obs_questao_2 = string.IsNullOrEmpty(txtObsQuestao_2.Text) ? null : txtObsQuestao_2.Text;
                a.obs_questao_3 = string.IsNullOrEmpty(txtObsQuestao_3.Text) ? null : txtObsQuestao_3.Text;
                a.questao_3 = rbQuestao_3.SelectedValue;
                a.obs_questao_4 = string.IsNullOrEmpty(txtObsQuestao_4.Text) ? null : txtObsQuestao_4.Text;
                a.questao_4 = rbQuestao_4.Text;
                a.obs_questao_5 = string.IsNullOrEmpty(txtObsQuestao_5.Text) ? null : txtObsQuestao_5.Text;
                a.questao_5 = rbQuestao_5.SelectedValue;
                a.questao_6 = rbQuestao_6.SelectedValue;
                a.obs_questao_6 = string.IsNullOrEmpty(txtObsQuestao_6.Text) ? null : txtObsQuestao_6.Text;
                a.questao_7 = rbQuestao_7.SelectedValue;
                a.obs_questao_7 = string.IsNullOrEmpty(txtObsQuestao_7.Text) ? null : txtObsQuestao_7.Text;
                a.questao_8 = rbQuestao_8.SelectedValue;
                a.obs_questao_8 = string.IsNullOrEmpty(txtObsQuestao_8.Text) ? null : txtObsQuestao_8.Text;
                a.questao_9 = rbQuestao_9.SelectedValue;
                a.obs_questao_9 = string.IsNullOrEmpty(txtObsQuestao_9.Text) ? null : txtObsQuestao_9.Text;
                a.questao_10 = rbQuestao_10.SelectedValue;
                a.obs_questao_10 = string.IsNullOrEmpty(txtObsQuestao_10.Text) ? null : txtObsQuestao_10.Text;
                a.questao_11 = rbQuestao_11.SelectedValue;
                a.obs_questao_11 = string.IsNullOrEmpty(txtObsQuestao_11.Text) ? null : txtObsQuestao_11.Text;
                a.questao_12 = rbQuestao_12.SelectedValue;
                a.obs_questao_12 = string.IsNullOrEmpty(txtObsQuestao_12.Text) ? null : txtObsQuestao_12.Text;
                a.questao_13 = rbQuestao_13.SelectedValue;
                a.obs_questao_13 = string.IsNullOrEmpty(txtObsQuestao_13.Text) ? null : txtObsQuestao_13.Text;
                a.questao_14 = rbQuestao_14.SelectedValue;
                a.obs_questao_14 = string.IsNullOrEmpty(txtObsQuestao_14.Text) ? null : txtObsQuestao_14.Text;
                a.questao_15 = rbQuestao_15.SelectedValue;
                a.obs_questao_15 = string.IsNullOrEmpty(txtObsQuestao_15.Text) ? null : txtObsQuestao_15.Text;
                a.questao_16 = rbQuestao_16.SelectedValue;
                a.obs_questao_16 = string.IsNullOrEmpty(txtObsQuestao_16.Text) ? null : txtObsQuestao_16.Text;
                a.questao_17 = rbQuestao_17.SelectedValue;
                a.obs_questao_17 = string.IsNullOrEmpty(txtObsQuestao_17.Text) ? null : txtObsQuestao_17.Text;
                a.questao_18 = rbQuestao_18.SelectedValue;
                a.obs_questao_18 = string.IsNullOrEmpty(txtObsQuestao_18.Text) ? null : txtObsQuestao_18.Text;
                a.questao_19 = rbQuestao_19.SelectedValue;
                a.obs_questao_19 = string.IsNullOrEmpty(txtObsQuestao_19.Text) ? null : txtObsQuestao_19.Text;
                a.questao_20 = rbQuestao_20.SelectedValue;
                a.obs_questao_20 = string.IsNullOrEmpty(txtObsQuestao_20.Text) ? null : txtObsQuestao_20.Text;
                a.consideracao = string.IsNullOrEmpty(txtConsideracoesFinais.Text) ? null : txtConsideracoesFinais.Text;
                a.obs_questao_22 = string.IsNullOrEmpty(txtObsQuestao_22.Text) ? null : txtObsQuestao_22.Text;

                acidenteBll.save(a);
                formularioBll.update(a.formularioId, UserControlHeader.linha, UserControlHeader.contrato, (a.preenchimentoCompleto == true ? true : false));

                UserControlExecQuestao1.Salvar(a.formularioId);

                if (UserControlQuestao3_4.panelPrincipal3.Visible)
                    UserControlQuestao3_4.SaveQuestao3_4(a.formularioId);

                if (UserControlQuestao5.panelPrincipal5.Visible)
                    UserControlQuestao5.Salvar(a.formularioId);

                if (UserControlQuestao6.panelPrincipal6.Visible)
                    UserControlQuestao6.Salvar(a.formularioId);

                UserControlQuestao7.Salvar(a.formularioId);
                UserControlOcorrenciaNet.Salvar(a.formularioId);

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
            Acidente a = new Acidente();
            a.preenchimentoCompleto = false;
            update(a);
        }

        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            Acidente a = new Acidente();
            a.preenchimentoCompleto = true;
            update(a);
        }
    }
}