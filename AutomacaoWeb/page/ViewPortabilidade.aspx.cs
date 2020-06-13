using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Threading.Tasks;
using System.Web.UI;

namespace AutomacaoWeb.page
{
    public partial class ViewPortabilidade : System.Web.UI.Page
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
                    form = await formularioBll.readAsync(id_caso, (int)Util.TFormulario.Portabilidade);
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

                        PortabilidadeBLL portabilidadeBll = new PortabilidadeBLL();
                        var f = await portabilidadeBll.read(form.id);
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
                            rbQuestao_2.SelectedValue = f.questao_2;
                            txtObsQuestao_2.Text = f.obs_questao_2;
                            txtDtInsQuestao_3.Text = f.dtInsQuestao_3.ToString();
                            txtObsQuestao_3.Text = f.obs_questao_3;
                            txtQuestao_4.Text = f.questao_4;
                            txtObsQuestao_4.Text = f.obs_questao_4;
                            txtQuestao_5.Text = f.questao_5;
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
                            rbQuestao_21.SelectedValue = f.questao_21;
                            txtObsQuestao_21.Text = f.obs_questao_21;
                            rbQuestao_22.SelectedValue = f.questao_22;
                            txtObsQuestao_22.Text = f.obs_questao_22;
                            rbQuestao_23.SelectedValue = f.questao_23;
                            txtObsQuestao_23.Text = f.obs_questao_23;
                            rbQuestao_24.SelectedValue = f.questao_24;
                            txtObsQuestao_24.Text = f.obs_questao_24;
                            rbQuestao_25.SelectedValue = f.questao_25;
                            txtObsQuestao_25.Text = f.obs_questao_25;
                            rbQuestao_25.SelectedValue = f.questao_25;
                            txtObsQuestao_25.Text = f.obs_questao_25;
                            rbQuestao_26.SelectedValue = f.questao_26;
                            txtObsQuestao_26.Text = f.obs_questao_26;
                            rbQuestao_27.SelectedValue = f.questao_27;
                            txtObsQuestao_27.Text = f.obs_questao_27;
                            rbQuestao_28.SelectedValue = f.questao_28;
                            txtObsQuestao_28.Text = f.obs_questao_28;
                            rbQuestao_29.SelectedValue = f.questao_29;
                            txtObsQuestao_29.Text = f.obs_questao_29;
                            txtConsideracoesFinais.Text = f.consideracao;
                            txtObsQuestao_31.Text = f.obs_questao_31;
                        }

                        UserControlExecQuestao1.tipoFormulario = Convert.ToInt16(Util.TFormulario.Portabilidade);
                        UserControlQuestao5.tipoFormulario = Convert.ToInt16(Util.TFormulario.Portabilidade);

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
        private void update(Portabilidade f)
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                PortabilidadeBLL portabilidadeBLL = new PortabilidadeBLL();

                f.id = string.IsNullOrEmpty(hfId.Value) ? 0 : Convert.ToInt32(hfId.Value);
                f.formularioId = Convert.ToInt32(hfFormularioId.Value);
                f.questao_1 = rbQuestao_1.SelectedValue;
                f.obs_questao_1 = string.IsNullOrEmpty(txtObsQuestao_1.Text) ? null : txtObsQuestao_1.Text;
                f.questao_1_1 = rbQuestao_1_1_0.SelectedValue;
                f.obs_questao_1_1 = string.IsNullOrEmpty(txtObsQuestao_1_1.Text) ? null : txtObsQuestao_1_1.Text;
                f.questao_1_2 = rbQuestao_1_2_0.SelectedValue;
                f.obs_questao_1_2 = string.IsNullOrEmpty(txtObsQuestao_1_2.Text) ? null : txtObsQuestao_1_2.Text;
                f.questao_1_3 = rbQuestao_1_3_0.SelectedValue;
                f.obs_questao_1_3 = string.IsNullOrEmpty(txtObsQuestao_1_3.Text) ? null : txtObsQuestao_1_3.Text;
                f.questao_1_4 = rbQuestao_1_4_0.SelectedValue;
                f.obs_questao_1_4 = string.IsNullOrEmpty(txtObsQuestao_1_4.Text) ? null : txtObsQuestao_1_4.Text;
                f.questao_2 = rbQuestao_2.Text;
                f.obs_questao_2 = string.IsNullOrEmpty(txtObsQuestao_2.Text) ? null : txtObsQuestao_2.Text;
                f.dtInsQuestao_3 = string.IsNullOrEmpty(txtDtInsQuestao_3.Text) ? (DateTime?)null : Convert.ToDateTime(txtDtInsQuestao_3.Text);
                f.obs_questao_3 = string.IsNullOrEmpty(txtObsQuestao_3.Text) ? null : txtObsQuestao_3.Text;
                f.questao_4 = txtQuestao_4.Text;
                f.obs_questao_4 = string.IsNullOrEmpty(txtObsQuestao_4.Text) ? null : txtObsQuestao_4.Text;
                f.questao_5 = txtQuestao_5.Text;
                f.obs_questao_5 = string.IsNullOrEmpty(txtObsQuestao_5.Text) ? null : txtObsQuestao_5.Text;
                f.questao_6 = rbQuestao_6.SelectedValue;
                f.obs_questao_6 = string.IsNullOrEmpty(txtObsQuestao_6.Text) ? null : txtObsQuestao_6.Text;
                f.questao_7 = rbQuestao_7.SelectedValue;
                f.obs_questao_7 = string.IsNullOrEmpty(txtObsQuestao_7.Text) ? null : txtObsQuestao_7.Text;
                f.questao_8 = rbQuestao_8.SelectedValue;
                f.obs_questao_8 = string.IsNullOrEmpty(txtObsQuestao_8.Text) ? null : txtObsQuestao_8.Text;
                f.questao_9 = rbQuestao_9.SelectedValue;
                f.obs_questao_9 = string.IsNullOrEmpty(txtObsQuestao_9.Text) ? null : txtObsQuestao_9.Text;
                f.questao_10 = rbQuestao_10.SelectedValue;
                f.obs_questao_10 = string.IsNullOrEmpty(txtObsQuestao_10.Text) ? null : txtObsQuestao_10.Text;
                f.questao_11 = rbQuestao_11.SelectedValue;
                f.obs_questao_11 = string.IsNullOrEmpty(txtObsQuestao_11.Text) ? null : txtObsQuestao_11.Text;
                f.questao_12 = rbQuestao_12.SelectedValue;
                f.obs_questao_12 = string.IsNullOrEmpty(txtObsQuestao_12.Text) ? null : txtObsQuestao_12.Text;
                f.questao_13 = rbQuestao_13.SelectedValue;
                f.obs_questao_13 = string.IsNullOrEmpty(txtObsQuestao_13.Text) ? null : txtObsQuestao_13.Text;
                f.questao_14 = rbQuestao_14.SelectedValue;
                f.obs_questao_14 = string.IsNullOrEmpty(txtObsQuestao_14.Text) ? null : txtObsQuestao_14.Text;
                f.questao_15 = rbQuestao_15.SelectedValue;
                f.obs_questao_15 = string.IsNullOrEmpty(txtObsQuestao_15.Text) ? null : txtObsQuestao_15.Text;
                f.questao_16 = rbQuestao_16.SelectedValue;
                f.obs_questao_16 = string.IsNullOrEmpty(txtObsQuestao_16.Text) ? null : txtObsQuestao_16.Text;
                f.questao_17 = rbQuestao_17.SelectedValue;
                f.obs_questao_17 = string.IsNullOrEmpty(txtObsQuestao_17.Text) ? null : txtObsQuestao_17.Text;
                f.questao_18 = rbQuestao_18.SelectedValue;
                f.obs_questao_18 = string.IsNullOrEmpty(txtObsQuestao_18.Text) ? null : txtObsQuestao_18.Text;
                f.questao_19 = rbQuestao_19.SelectedValue;
                f.obs_questao_19 = string.IsNullOrEmpty(txtObsQuestao_19.Text) ? null : txtObsQuestao_19.Text;
                f.questao_20 = rbQuestao_20.SelectedValue;
                f.obs_questao_20 = string.IsNullOrEmpty(txtObsQuestao_20.Text) ? null : txtObsQuestao_20.Text;
                f.questao_21 = rbQuestao_21.SelectedValue;
                f.obs_questao_21 = string.IsNullOrEmpty(txtObsQuestao_21.Text) ? null : txtObsQuestao_21.Text;
                f.questao_22 = rbQuestao_22.SelectedValue;
                f.obs_questao_22 = string.IsNullOrEmpty(txtObsQuestao_22.Text) ? null : txtObsQuestao_22.Text;
                f.questao_23 = rbQuestao_23.SelectedValue;
                f.obs_questao_23 = string.IsNullOrEmpty(txtObsQuestao_23.Text) ? null : txtObsQuestao_23.Text;
                f.questao_24 = rbQuestao_24.SelectedValue;
                f.obs_questao_24 = string.IsNullOrEmpty(txtObsQuestao_24.Text) ? null : txtObsQuestao_24.Text;
                f.questao_25 = rbQuestao_25.SelectedValue;
                f.obs_questao_25 = string.IsNullOrEmpty(txtObsQuestao_25.Text) ? null : txtObsQuestao_25.Text;
                f.questao_26 = rbQuestao_26.SelectedValue;
                f.obs_questao_26 = string.IsNullOrEmpty(txtObsQuestao_26.Text) ? null : txtObsQuestao_26.Text;
                f.questao_27 = rbQuestao_27.SelectedValue;
                f.obs_questao_27 = string.IsNullOrEmpty(txtObsQuestao_27.Text) ? null : txtObsQuestao_27.Text;
                f.questao_28 = rbQuestao_28.SelectedValue;
                f.obs_questao_28 = string.IsNullOrEmpty(txtObsQuestao_28.Text) ? null : txtObsQuestao_28.Text;
                f.questao_29 = rbQuestao_29.SelectedValue;
                f.obs_questao_29 = string.IsNullOrEmpty(txtObsQuestao_29.Text) ? null : txtObsQuestao_29.Text;
                f.consideracao = string.IsNullOrEmpty(txtConsideracoesFinais.Text) ? null : txtConsideracoesFinais.Text;
                f.obs_questao_31 = string.IsNullOrEmpty(txtObsQuestao_31.Text) ? null : txtObsQuestao_31.Text;

                portabilidadeBLL.save(f);
                formularioBll.update(f.formularioId, UserControlHeader.linha, UserControlHeader.contrato, (f.preenchimentoCompleto == true ? true : false));

                UserControlExecQuestao1.Salvar(f.formularioId);

                if (UserControlQuestao3_4.panelPrincipal3.Visible)
                    UserControlQuestao3_4.SaveQuestao3_4(f.formularioId);

                if (UserControlQuestao5.panelPrincipal5.Visible)
                    UserControlQuestao5.Salvar(f.formularioId);

                if (UserControlQuestao6.panelPrincipal6.Visible)
                    UserControlQuestao6.Salvar(f.formularioId);

                UserControlQuestao7.Salvar(f.formularioId);
                UserControlOcorrenciaNet.Salvar(f.formularioId);

                if (UserControlQuestao11.panelPrincipal11.Visible)
                    UserControlQuestao11.Salvar(f.formularioId);

                if (UserControlQuestao12.panelPrincipal12.Visible)
                    UserControlQuestao12.Salvar(f.formularioId);

                if (UserControlQuestao14.panelPrincipal14.Visible)
                    UserControlQuestao14.Salvar(f.formularioId);

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
            Portabilidade p = new Portabilidade();
            p.preenchimentoCompleto = true;
            update(p);
        }
        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            Portabilidade p = new Portabilidade();
            p.preenchimentoCompleto = true;
            update(p);
        }
    }
}