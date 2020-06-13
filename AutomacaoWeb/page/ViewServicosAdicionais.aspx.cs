using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI;

namespace AutomacaoWeb.page
{
    public partial class ViewServicosAdicionais : System.Web.UI.Page
    {
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
                    form = await formularioBll.readAsync(id_caso, (int)Util.TFormulario.ServicosAdicionais);

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

                        ServicoAdicionalBll servicoAdicionalBll = new ServicoAdicionalBll();
                        var c = await servicoAdicionalBll.read(form.id);

                        if (c != null)
                        {

                            hfId.Value = c.id.ToString();
                            rbQuestao_1.SelectedValue = c.questao_1;
                            txtObsQuestao_1.Text = c.obs_questao_1;

                            rbQuestao_1_1_0.SelectedValue = c.questao_1_1;
                            txtObsQuestao_1_1.Text = c.obs_questao_1_1;

                            rbQuestao_1_2_0.SelectedValue = c.questao_1_2;
                            txtObsQuestao_1_2.Text = c.obs_questao_1_2;

                            rbQuestao_1_3_0.SelectedValue = c.questao_1_3;
                            txtObsQuestao_1_3.Text = c.obs_questao_1_3;

                            rbQuestao_1_4_0.SelectedValue = c.questao_1_4;
                            txtObsQuestao_1_4.Text = c.obs_questao_1_4;

                            rbQuestao_2.SelectedValue = c.questao_2;
                            txtObsQuestao_2.Text = c.obs_questao_2;

                            txtDtInsQuestao_3.Text = c.questao_3.ToString();
                            txtObsQuestao_3.Text = c.obs_questao_3;

                            rbQuestao_4.SelectedValue = c.questao_4;
                            txtObsQuestao_4.Text = c.obs_questao_4;

                            txtDataHabServAdc_5.Text = c.questao_5.ToString();
                            txtObsQuestao_5.Text = c.obs_questao_5;

                            rbQuestao_6.SelectedValue = c.questao_6;
                            txtObsQuestao_6.Text = c.obs_questao_6;

                            rbQuestao_7.SelectedValue = c.questao_7;
                            txtObsQuestao_7.Text = c.obs_questao_7;

                            rbQuestao_8.SelectedValue = c.questao_8;
                            txtObsQuestao_8.Text = c.obs_questao_8;

                            rbQuestao_9.SelectedValue = c.questao_9;
                            txtObsQuestao_9.Text = c.obs_questao_9;

                            rbQuestao_10.SelectedValue = c.questao_10;
                            txtObsQuestao_10.Text = c.obs_questao_10;

                            rbQuestao_11.SelectedValue = c.questao_11;
                            txtObsQuestao_11.Text = c.obs_questao_11;

                            rbQuestao_12.SelectedValue = c.questao_12;
                            txtObsQuestao_12.Text = c.obs_questao_12;

                            rbQuestao_13.SelectedValue = c.questao_13;
                            txtObsQuestao_13.Text = c.obs_questao_13;

                            rbQuestao_14.SelectedValue = c.questao_14;
                            txtObsQuestao_14.Text = c.obs_questao_14;

                            rbQuestao_15.SelectedValue = c.questao_15;
                            txtObsQuestao_15.Text = c.obs_questao_15;

                            rbQuestao_16.SelectedValue = c.questao_16;
                            txtObsQuestao_16.Text = c.obs_questao_16;

                            rbQuestao_17.SelectedValue = c.questao_17;
                            txtObsQuestao_17.Text = c.obs_questao_17;

                            rbQuestao_18.SelectedValue = c.questao_18;
                            txtObsQuestao_18.Text = c.obs_questao_18;

                            rbQuestao_19.SelectedValue = c.questao_19;
                            txtObsQuestao_19.Text = c.obs_questao_19;

                            rbQuestao_20.SelectedValue = c.questao_20;
                            txtObsQuestao_20.Text = c.obs_questao_20;

                            rbQuestao_21.SelectedValue = c.questao_21;
                            txtObsQuestao_21.Text = c.obs_questao_21;

                            rbQuestao_22.SelectedValue = c.questao_22;
                            txtObsQuestao_22.Text = c.obs_questao_22;

                            rbQuestao_23.SelectedValue = c.questao_23;
                            txtObsQuestao_23.Text = c.obs_questao_23;

                            rbQuestao_24.SelectedValue = c.questao_24;
                            txtObsQuestao_24.Text = c.obs_questao_24;

                            rbQuestao_25.SelectedValue = c.questao_25;
                            txtObsQuestao_25.Text = c.obs_questao_25;

                            txtObservacao.Text = c.consideracao;

                            txtObsQuestao_27.Text = c.obs_questao_27;
                        }

                        UserControlExecQuestao1.tipoFormulario = Convert.ToInt16(Util.TFormulario.ServicosAdicionais);
                        UserControlQuestao5.tipoFormulario = Convert.ToInt16(Util.TFormulario.ServicosAdicionais);

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
        private void update(ServicoAdicional c)
        {
            try
            {
                ServicoAdicionalBll servicoAdicionalBll = new ServicoAdicionalBll();
                FormularioBll formularioBll = new FormularioBll();

                c.id = string.IsNullOrEmpty(hfId.Value) ? 0 : Convert.ToInt32(hfId.Value);
                c.formularioId = Convert.ToInt32(hfFormularioId.Value);
                c.questao_1 = rbQuestao_1.SelectedValue;
                c.obs_questao_1 = string.IsNullOrEmpty(txtObsQuestao_1.Text) ? null : txtObsQuestao_1.Text;
                c.questao_1_1 = rbQuestao_1_1_0.SelectedValue;
                c.obs_questao_1_1 = string.IsNullOrEmpty(txtObsQuestao_1_1.Text) ? null : txtObsQuestao_1_1.Text;
                c.questao_1_2 = rbQuestao_1_2_0.SelectedValue;
                c.obs_questao_1_2 = string.IsNullOrEmpty(txtObsQuestao_1_2.Text) ? null : txtObsQuestao_1_2.Text;
                c.questao_1_3 = rbQuestao_1_3_0.SelectedValue;
                c.obs_questao_1_3 = string.IsNullOrEmpty(txtObsQuestao_1_3.Text) ? null : txtObsQuestao_1_3.Text;
                c.questao_1_4 = rbQuestao_1_4_0.SelectedValue;
                c.obs_questao_1_4 = string.IsNullOrEmpty(txtObsQuestao_1_4.Text) ? null : txtObsQuestao_1_4.Text;
                c.questao_2 = rbQuestao_2.Text;
                c.obs_questao_2 = string.IsNullOrEmpty(txtObsQuestao_2.Text) ? null : txtObsQuestao_2.Text;
                c.questao_3 = (string.IsNullOrEmpty(txtDtInsQuestao_3.Text) ? (DateTime?)null : Convert.ToDateTime(txtDtInsQuestao_3.Text));
                c.obs_questao_3 = string.IsNullOrEmpty(txtObsQuestao_3.Text) ? null : txtObsQuestao_3.Text;
                c.questao_4 = rbQuestao_4.SelectedValue;
                c.obs_questao_4 = string.IsNullOrEmpty(txtObsQuestao_4.Text) ? null : txtObsQuestao_4.Text;
                c.questao_5 = (string.IsNullOrEmpty(txtDataHabServAdc_5.Text) ? (DateTime?)null : Convert.ToDateTime(txtDataHabServAdc_5.Text));
                c.obs_questao_5 = string.IsNullOrEmpty(txtObsQuestao_5.Text) ? null : txtObsQuestao_5.Text;
                c.questao_6 = rbQuestao_6.SelectedValue;
                c.obs_questao_6 = string.IsNullOrEmpty(txtObsQuestao_6.Text) ? null : txtObsQuestao_6.Text;
                c.questao_7 = rbQuestao_7.SelectedValue;
                c.obs_questao_7 = string.IsNullOrEmpty(txtObsQuestao_7.Text) ? null : txtObsQuestao_7.Text;
                c.questao_8 = rbQuestao_8.SelectedValue;
                c.obs_questao_8 = string.IsNullOrEmpty(txtObsQuestao_8.Text) ? null : txtObsQuestao_8.Text;
                c.questao_9 = rbQuestao_9.SelectedValue;
                c.obs_questao_9 = string.IsNullOrEmpty(txtObsQuestao_9.Text) ? null : txtObsQuestao_9.Text;
                c.questao_10 = rbQuestao_10.SelectedValue;
                c.obs_questao_10 = string.IsNullOrEmpty(txtObsQuestao_10.Text) ? null : txtObsQuestao_10.Text;
                c.questao_11 = rbQuestao_11.SelectedValue;
                c.obs_questao_11 = string.IsNullOrEmpty(txtObsQuestao_11.Text) ? null : txtObsQuestao_11.Text;
                c.questao_12 = rbQuestao_12.SelectedValue;
                c.obs_questao_12 = string.IsNullOrEmpty(txtObsQuestao_12.Text) ? null : txtObsQuestao_12.Text;
                c.questao_13 = rbQuestao_13.SelectedValue;
                c.obs_questao_13 = string.IsNullOrEmpty(txtObsQuestao_13.Text) ? null : txtObsQuestao_13.Text;
                c.questao_14 = rbQuestao_14.SelectedValue;
                c.obs_questao_14 = string.IsNullOrEmpty(txtObsQuestao_14.Text) ? null : txtObsQuestao_14.Text;
                c.questao_15 = rbQuestao_15.SelectedValue;
                c.obs_questao_15 = string.IsNullOrEmpty(txtObsQuestao_15.Text) ? null : txtObsQuestao_15.Text;
                c.questao_16 = rbQuestao_16.SelectedValue;
                c.obs_questao_16 = string.IsNullOrEmpty(txtObsQuestao_16.Text) ? null : txtObsQuestao_16.Text;
                c.questao_17 = rbQuestao_17.SelectedValue;
                c.obs_questao_17 = string.IsNullOrEmpty(txtObsQuestao_17.Text) ? null : txtObsQuestao_17.Text;
                c.questao_18 = rbQuestao_18.SelectedValue;
                c.obs_questao_18 = string.IsNullOrEmpty(txtObsQuestao_18.Text) ? null : txtObsQuestao_18.Text;
                c.questao_19 = rbQuestao_19.SelectedValue;
                c.obs_questao_19 = string.IsNullOrEmpty(txtObsQuestao_19.Text) ? null : txtObsQuestao_19.Text;
                c.questao_20 = rbQuestao_20.SelectedValue;
                c.obs_questao_20 = string.IsNullOrEmpty(txtObsQuestao_20.Text) ? null : txtObsQuestao_20.Text;
                c.questao_21 = rbQuestao_21.SelectedValue;
                c.obs_questao_21 = string.IsNullOrEmpty(txtObsQuestao_21.Text) ? null : txtObsQuestao_21.Text;
                c.questao_22 = rbQuestao_22.SelectedValue;
                c.obs_questao_22 = string.IsNullOrEmpty(txtObsQuestao_22.Text) ? null : txtObsQuestao_22.Text;
                c.questao_23 = rbQuestao_23.SelectedValue;
                c.obs_questao_23 = string.IsNullOrEmpty(txtObsQuestao_23.Text) ? null : txtObsQuestao_23.Text;
                c.questao_24 = rbQuestao_24.SelectedValue;
                c.obs_questao_24 = string.IsNullOrEmpty(txtObsQuestao_24.Text) ? null : txtObsQuestao_24.Text;
                c.questao_25 = rbQuestao_25.SelectedValue;
                c.obs_questao_25 = string.IsNullOrEmpty(txtObsQuestao_25.Text) ? null : txtObsQuestao_25.Text;
                c.consideracao = txtObservacao.Text;
                c.obs_questao_27 = string.IsNullOrEmpty(txtObsQuestao_27.Text) ? null : txtObsQuestao_27.Text;

                servicoAdicionalBll.save(c);
                formularioBll.update(c.formularioId, UserControlHeader.linha, UserControlHeader.contrato, (c.preenchimentoCompleto == true ? true : false));

                UserControlExecQuestao1.Salvar(c.formularioId);

                if (UserControlQuestao3_4.panelPrincipal3.Visible)
                    UserControlQuestao3_4.SaveQuestao3_4(c.formularioId);

                if (UserControlQuestao5.panelPrincipal5.Visible)
                    UserControlQuestao5.Salvar(c.formularioId);

                if (UserControlQuestao6.panelPrincipal6.Visible)
                    UserControlQuestao6.Salvar(c.formularioId);

                UserControlQuestao7.Salvar(c.formularioId);
                UserControlOcorrenciaNet.Salvar(c.formularioId);

                if (UserControlQuestao11.panelPrincipal11.Visible)
                    UserControlQuestao11.Salvar(c.formularioId);

                if (UserControlQuestao12.panelPrincipal12.Visible)
                    UserControlQuestao12.Salvar(c.formularioId);

                if (UserControlQuestao14.panelPrincipal14.Visible)
                    UserControlQuestao14.Salvar(c.formularioId);

                Util.Alertbootsrap("Dados atualizados", this, upSalvar);

            }
            catch (Exception ex)
            {
                Util.Alertbootsrap(string.Concat(ex.Message, " - ", ex.InnerException), this, upSalvar);
            }
        }
        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            ServicoAdicional s = new ServicoAdicional();
            s.preenchimentoCompleto = false;
            update(s);
        }
        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            ServicoAdicional s = new ServicoAdicional();
            s.preenchimentoCompleto = true;
            update(s);
        }
    }
}