using AutomacaoBll;
using AutomacaoModel;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace AutomacaoWeb.page
{
    public partial class ViewExecLimiDesc : System.Web.UI.Page
    {
        FormularioBll formularioBll = new FormularioBll();
        ExeLimiDescBll exeLimiDescBll = new ExeLimiDescBll();
        private int idTipo;
        private void update(ExeLimiDesc e)
        {
            try
            {
                if (hfFormularioId.Value != "")
                {

                    e.id = string.IsNullOrEmpty(hfId.Value) ? 0 : Convert.ToInt32(hfId.Value);
                    e.formularioId = Convert.ToInt32(hfFormularioId.Value);

                    e.justificativa = string.IsNullOrEmpty(lblJustificativa.Text) ? null : lblJustificativa.Text;
                    e.informacaoComplementar = string.IsNullOrEmpty(lblInfoComplementares.Text) ? null : lblInfoComplementares.Text;
                    e.motivoCumprimento = string.IsNullOrEmpty(lblMotivoCumprimento.Text) ? null : lblMotivoCumprimento.Text;
                    e.descricao = string.IsNullOrEmpty(lblDescricao.Text) ? null : lblDescricao.Text;
                    e.orgao = string.IsNullOrEmpty(lblOrgao.Text) ? null : lblOrgao.Text;

                    e.detalhe_questao_0 = txtDetalheQuestao_0.Text != "" ? txtDetalheQuestao_0.Text : null;
                    e.consideracao = string.IsNullOrEmpty(txtFinalizacao.Text) ? null : txtFinalizacao.Text;
                    e.questao_1 = Request.Form["lblQuestao_1"] != "" ? Request.Form["lblQuestao_1"] : null;
                    e.obs_questao_1 = string.IsNullOrEmpty(txtObsQuestao_1.Text) ? null : txtObsQuestao_1.Text;
                    e.questao_2 = Request.Form["lblQuestao_2"] != "" ? Request.Form["lblQuestao_2"] : null;
                    e.obs_questao_2 = string.IsNullOrEmpty(txtObsQuestao_2.Text) ? null : txtObsQuestao_2.Text;
                    e.questao_3 = Request.Form["lblQuestao_3"] != "" ? Request.Form["lblQuestao_3"] : null;
                    e.obs_questao_3 = string.IsNullOrEmpty(txtObsQuestao_3.Text) ? null : txtObsQuestao_3.Text;
                    e.questao_4 = Request.Form["lblQuestao_4"] != "" ? Request.Form["lblQuestao_4"] : null;
                    e.obs_questao_4 = string.IsNullOrEmpty(txtObsQuestao_4.Text) ? null : txtObsQuestao_4.Text;
                    e.questao_5 = Request.Form["lblQuestao_5"] != "" ? Request.Form["lblQuestao_5"] : null;
                    e.obs_questao_5 = string.IsNullOrEmpty(txtObsQuestao_5.Text) ? null : txtObsQuestao_5.Text;
                    e.questao_6 = Request.Form["lblQuestao_6"] != "" ? Request.Form["lblQuestao_6"] : null;
                    e.obs_questao_6 = string.IsNullOrEmpty(txtObsQuestao_6.Text) ? null : txtObsQuestao_6.Text;
                    e.questao_7 = Request.Form["lblQuestao_7"] != "" ? Request.Form["lblQuestao_7"] : null;
                    e.obs_questao_7 = string.IsNullOrEmpty(txtObsQuestao_7.Text) ? null : txtObsQuestao_7.Text;
                    e.questao_8 = Request.Form["lblQuestao_8"] != "" ? Request.Form["lblQuestao_8"] : null;
                    e.obs_questao_8 = string.IsNullOrEmpty(txtObsQuestao_8.Text) ? null : txtObsQuestao_8.Text;
                    e.questao_9 = Request.Form["lblQuestao_9"] != "" ? Request.Form["lblQuestao_9"] : null;
                    e.obs_questao_9 = string.IsNullOrEmpty(txtObsQuestao_9.Text) ? null : txtObsQuestao_9.Text;
                    e.questao_10 = Request.Form["lblQuestao_10"] != "" ? Request.Form["lblQuestao_10"] : null;
                    e.obs_questao_10 = string.IsNullOrEmpty(txtObsQuestao_10.Text) ? null : txtObsQuestao_10.Text;
                    e.questao_11 = Request.Form["lblQuestao_11"] != "" ? Request.Form["lblQuestao_11"] : null;
                    e.obs_questao_11 = string.IsNullOrEmpty(txtObsQuestao_11.Text) ? null : txtObsQuestao_11.Text;
                    e.questao_12 = Request.Form["lblQuestao_12"] != "" ? Request.Form["lblQuestao_12"] : null;
                    e.obs_questao_12 = string.IsNullOrEmpty(txtObsQuestao_12.Text) ? null : txtObsQuestao_12.Text;
                    e.questao_13 = Request.Form["lblQuestao_13"] != "" ? Request.Form["lblQuestao_13"] : null;
                    e.obs_questao_13 = string.IsNullOrEmpty(txtObsQuestao_13.Text) ? null : txtObsQuestao_13.Text;
                    e.questao_14 = Request.Form["lblQuestao_14"] != "" ? Request.Form["lblQuestao_14"] : null;
                    e.obs_questao_14 = string.IsNullOrEmpty(txtObsQuestao_14.Text) ? null : txtObsQuestao_14.Text;
                    e.questao_15 = Request.Form["lblQuestao_15"] != "" ? Request.Form["lblQuestao_15"] : null;
                    e.obs_questao_15 = string.IsNullOrEmpty(txtObsQuestao_15.Text) ? null : txtObsQuestao_15.Text;
                    e.questao_16 = Request.Form["lblQuestao_16"] != "" ? Request.Form["lblQuestao_16"] : null;
                    e.obs_questao_16 = string.IsNullOrEmpty(txtObsQuestao_16.Text) ? null : txtObsQuestao_16.Text;
                    e.questao_17 = Request.Form["lblQuestao_17"] != "" ? Request.Form["lblQuestao_17"] : null;
                    e.obs_questao_17 = string.IsNullOrEmpty(txtObsQuestao_17.Text) ? null : txtObsQuestao_17.Text;
                    e.questao_18 = Request.Form["lblQuestao_18"] != "" ? Request.Form["lblQuestao_18"] : null;
                    e.obs_questao_18 = string.IsNullOrEmpty(txtObsQuestao_18.Text) ? null : txtObsQuestao_18.Text;
                    e.questao_19 = Request.Form["lblQuestao_19"] != "" ? Request.Form["lblQuestao_19"] : null;
                    e.obs_questao_19 = string.IsNullOrEmpty(txtObsQuestao_19.Text) ? null : txtObsQuestao_19.Text;
                    e.questao_20 = Request.Form["lblQuestao_20"] != "" ? Request.Form["lblQuestao_20"] : null;
                    e.obs_questao_20 = string.IsNullOrEmpty(txtObsQuestao_20.Text) ? null : txtObsQuestao_20.Text;
                    e.questao_21 = Request.Form["lblQuestao_21"] != "" ? Request.Form["lblQuestao_21"] : null;
                    e.obs_questao_21 = string.IsNullOrEmpty(txtObsQuestao_21.Text) ? null : txtObsQuestao_21.Text;
                    e.questao_22 = Request.Form["lblQuestao_22"] != "" ? Request.Form["lblQuestao_22"] : null;
                    e.obs_questao_22 = string.IsNullOrEmpty(txtObsQuestao_22.Text) ? null : txtObsQuestao_22.Text;
                    e.questao_23 = Request.Form["lblQuestao_23"] != "" ? Request.Form["lblQuestao_23"] : null;
                    e.obs_questao_23 = string.IsNullOrEmpty(txtObsQuestao_23.Text) ? null : txtObsQuestao_23.Text;
                    e.questao_24 = Request.Form["lblQuestao_24"] != "" ? Request.Form["lblQuestao_24"] : null;
                    e.obs_questao_24 = string.IsNullOrEmpty(txtObsQuestao_24.Text) ? null : txtObsQuestao_24.Text;
                    e.questao_25 = Request.Form["lblQuestao_25"] != "" ? Request.Form["lblQuestao_25"] : null;
                    e.obs_questao_25 = string.IsNullOrEmpty(txtObsQuestao_25.Text) ? null : txtObsQuestao_25.Text;
                    e.questao_26 = Request.Form["lblQuestao_26"] != "" ? Request.Form["lblQuestao_26"] : null;
                    e.obs_questao_26 = string.IsNullOrEmpty(txtObsQuestao_26.Text) ? null : txtObsQuestao_26.Text;
                    e.questao_27 = Request.Form["lblQuestao_27"] != "" ? Request.Form["lblQuestao_27"] : null;
                    e.obs_questao_27 = string.IsNullOrEmpty(txtObsQuestao_27.Text) ? null : txtObsQuestao_27.Text;
                    e.questao_28 = Request.Form["lblQuestao_28"] != "" ? Request.Form["lblQuestao_28"] : null;
                    e.obs_questao_28 = string.IsNullOrEmpty(txtObsQuestao_28.Text) ? null : txtObsQuestao_28.Text;
                    e.questao_29 = Request.Form["lblQuestao_29"] != "" ? Request.Form["lblQuestao_29"] : null;
                    e.obs_questao_29 = string.IsNullOrEmpty(txtObsQuestao_29.Text) ? null : txtObsQuestao_29.Text;
                    e.questao_30 = Request.Form["lblQuestao_30"] != "" ? Request.Form["lblQuestao_30"] : null;
                    e.obs_questao_30 = string.IsNullOrEmpty(txtObsQuestao_30.Text) ? null : txtObsQuestao_30.Text;
                    e.questao_31 = Request.Form["lblQuestao_31"] != "" ? Request.Form["lblQuestao_31"] : null;
                    e.obs_questao_31 = string.IsNullOrEmpty(txtObsQuestao_31.Text) ? null : txtObsQuestao_31.Text;
                    e.questao_32 = Request.Form["lblQuestao_32"] != "" ? Request.Form["lblQuestao_32"] : null;
                    e.obs_questao_32 = string.IsNullOrEmpty(txtObsQuestao_32.Text) ? null : txtObsQuestao_32.Text;
                    e.questao_33 = Request.Form["lblQuestao_33"] != "" ? Request.Form["lblQuestao_33"] : null;
                    e.obs_questao_33 = string.IsNullOrEmpty(txtObsQuestao_33.Text) ? null : txtObsQuestao_33.Text;
                    e.questao_34 = Request.Form["lblQuestao_34"] != "" ? Request.Form["lblQuestao_34"] : null;
                    e.obs_questao_34 = string.IsNullOrEmpty(txtObsQuestao_34.Text) ? null : txtObsQuestao_34.Text;
                    e.questao_35 = Request.Form["lblQuestao_35"] != "" ? Request.Form["lblQuestao_35"] : null;
                    e.obs_questao_35 = string.IsNullOrEmpty(txtObsQuestao_35.Text) ? null : txtObsQuestao_35.Text;
                    e.questao_36 = Request.Form["lblQuestao_36"] != "" ? Request.Form["lblQuestao_36"] : null;
                    e.obs_questao_36 = string.IsNullOrEmpty(txtObsQuestao_36.Text) ? null : txtObsQuestao_36.Text;
                    e.questao_37 = Request.Form["lblQuestao_37"] != "" ? Request.Form["lblQuestao_37"] : null;
                    e.obs_questao_37 = string.IsNullOrEmpty(txtObsQuestao_37.Text) ? null : txtObsQuestao_37.Text;
                    e.questao_38 = Request.Form["lblQuestao_38"] != "" ? Request.Form["lblQuestao_38"] : null;
                    e.obs_questao_38 = string.IsNullOrEmpty(txtObsQuestao_38.Text) ? null : txtObsQuestao_38.Text;
                    e.questao_39 = Request.Form["lblQuestao_39"] != "" ? Request.Form["lblQuestao_39"] : null;
                    e.obs_questao_39 = string.IsNullOrEmpty(txtObsQuestao_39.Text) ? null : txtObsQuestao_39.Text;
                    e.questao_40 = Request.Form["lblQuestao_40"] != "" ? Request.Form["lblQuestao_40"] : null;
                    e.obs_questao_40 = string.IsNullOrEmpty(txtObsQuestao_40.Text) ? null : txtObsQuestao_40.Text;
                    e.questao_41 = Request.Form["lblQuestao_41"] != "" ? Request.Form["lblQuestao_41"] : null;
                    e.obs_questao_41 = string.IsNullOrEmpty(txtObsQuestao_41.Text) ? null : txtObsQuestao_41.Text;
                    e.questao_42 = Request.Form["lblQuestao_42"] != "" ? Request.Form["lblQuestao_42"] : null;
                    e.obs_questao_42 = string.IsNullOrEmpty(txtObsQuestao_42.Text) ? null : txtObsQuestao_42.Text;
                    e.questao_43 = Request.Form["lblQuestao_43"] != "" ? Request.Form["lblQuestao_43"] : null;
                    e.obs_questao_43 = string.IsNullOrEmpty(txtObsQuestao_43.Text) ? null : txtObsQuestao_43.Text;
                    e.questao_44 = Request.Form["lblQuestao_44"] != "" ? Request.Form["lblQuestao_44"] : null;
                    e.obs_questao_44 = string.IsNullOrEmpty(txtObsQuestao_44.Text) ? null : txtObsQuestao_44.Text;
                    e.questao_45 = Request.Form["lblQuestao_45"] != "" ? Request.Form["lblQuestao_45"] : null;
                    e.obs_questao_45 = string.IsNullOrEmpty(txtObsQuestao_45.Text) ? null : txtObsQuestao_45.Text;
                    e.questao_46 = Request.Form["lblQuestao_46"] != "" ? Request.Form["lblQuestao_46"] : null;
                    e.obs_questao_46 = string.IsNullOrEmpty(txtObsQuestao_46.Text) ? null : txtObsQuestao_46.Text;
                    e.questao_47 = Request.Form["lblQuestao_47"] != "" ? Request.Form["lblQuestao_47"] : null;
                    e.obs_questao_47 = string.IsNullOrEmpty(txtObsQuestao_47.Text) ? null : txtObsQuestao_47.Text;
                    e.questao_48 = Request.Form["lblQuestao_48"] != "" ? Request.Form["lblQuestao_48"] : null;
                    e.obs_questao_48 = string.IsNullOrEmpty(txtObsQuestao_48.Text) ? null : txtObsQuestao_48.Text;
                    e.questao_49 = Request.Form["lblQuestao_49"] != "" ? Request.Form["lblQuestao_49"] : null;
                    e.obs_questao_49 = string.IsNullOrEmpty(txtObsQuestao_49.Text) ? null : txtObsQuestao_49.Text;
                    e.questao_50 = Request.Form["lblQuestao_50"] != "" ? Request.Form["lblQuestao_50"] : null;
                    e.obs_questao_50 = string.IsNullOrEmpty(txtObsQuestao_50.Text) ? null : txtObsQuestao_50.Text;
                    e.questao_51 = Request.Form["lblQuestao_51"] != "" ? Request.Form["lblQuestao_51"] : null;
                    e.obs_questao_51 = string.IsNullOrEmpty(txtObsQuestao_51.Text) ? null : txtObsQuestao_51.Text;
                    e.questao_52 = Request.Form["lblQuestao_52"] != "" ? Request.Form["lblQuestao_52"] : null;
                    e.obs_questao_52 = string.IsNullOrEmpty(txtObsQuestao_52.Text) ? null : txtObsQuestao_52.Text;
                    e.questao_53 = Request.Form["lblQuestao_53"] != "" ? Request.Form["lblQuestao_53"] : null;
                    e.obs_questao_53 = string.IsNullOrEmpty(txtObsQuestao_53.Text) ? null : txtObsQuestao_53.Text;
                    e.questao_54 = Request.Form["lblQuestao_54"] != "" ? Request.Form["lblQuestao_54"] : null;
                    e.obs_questao_54 = string.IsNullOrEmpty(txtObsQuestao_54.Text) ? null : txtObsQuestao_54.Text;
                    e.questao_55 = Request.Form["lblQuestao_55"] != "" ? Request.Form["lblQuestao_55"] : null;
                    e.obs_questao_55 = string.IsNullOrEmpty(txtObsQuestao_55.Text) ? null : txtObsQuestao_55.Text;
                    e.questao_56 = Request.Form["lblQuestao_56"] != "" ? Request.Form["lblQuestao_56"] : null;
                    e.obs_questao_56 = string.IsNullOrEmpty(txtObsQuestao_56.Text) ? null : txtObsQuestao_56.Text;
                    e.questao_57 = Request.Form["lblQuestao_57"] != "" ? Request.Form["lblQuestao_57"] : null;
                    e.obs_questao_57 = string.IsNullOrEmpty(txtObsQuestao_57.Text) ? null : txtObsQuestao_57.Text;
                    e.questao_58 = Request.Form["lblQuestao_58"] != "" ? Request.Form["lblQuestao_58"] : null;
                    e.obs_questao_58 = string.IsNullOrEmpty(txtObsQuestao_58.Text) ? null : txtObsQuestao_58.Text;
                    e.questao_59 = Request.Form["lblQuestao_59"] != "" ? Request.Form["lblQuestao_59"] : null;
                    e.obs_questao_59 = string.IsNullOrEmpty(txtObsQuestao_59.Text) ? null : txtObsQuestao_59.Text;
                    e.questao_60 = Request.Form["lblQuestao_60"] != "" ? Request.Form["lblQuestao_60"] : null;
                    e.obs_questao_60 = string.IsNullOrEmpty(txtObsQuestao_60.Text) ? null : txtObsQuestao_60.Text;
                    e.questao_61 = Request.Form["lblQuestao_61"] != "" ? Request.Form["lblQuestao_61"] : null;
                    e.obs_questao_61 = string.IsNullOrEmpty(txtObsQuestao_61.Text) ? null : txtObsQuestao_61.Text;
                    e.questao_62 = Request.Form["lblQuestao_62"] != "" ? Request.Form["lblQuestao_62"] : null;
                    e.obs_questao_62 = string.IsNullOrEmpty(txtObsQuestao_62.Text) ? null : txtObsQuestao_62.Text;
                    exeLimiDescBll.save(e);

                    formularioBll.update(e.formularioId, UserControlHeader.linha, UserControlHeader.contrato, (e.preenchimentoCompleto == true ? true : false));

                    UserControlExecQuestao1.Salvar(e.formularioId);
                    UserControlExecQuestao3.SaveQuestao3(e.formularioId);

                    if (UserControlQuestao11.panelPrincipal11.Visible)
                        UserControlQuestao11.Salvar(e.formularioId);

                    if (UserControlQuestao13.panelPrincipal13.Visible)
                        UserControlQuestao13.Salvar(e.formularioId);

                    if (UserControlQuestao14.panelPrincipal14.Visible)
                        UserControlQuestao14.Salvar(e.formularioId);


                    if (pPrincipalRespostaCumprimento.Visible == true)
                    {
                        RespostaOperacaoBll rBll = new RespostaOperacaoBll();
                        RespostaOperacao r = new RespostaOperacao();
                        r.id = Convert.ToInt32(ViewState["idRespostaOperacao"]);
                        r.formularioId = Convert.ToInt32(hfFormularioId.Value);
                        r.respostaOperacao = txtRespostaOperacao.Text;
                        r.solicitacaoEscritorio = txtSolicitacaoEscritorio.Text;
                        rBll.save(r);
                    }

                    Util.Alertbootsrap("Dados atualizados", this, upSalvar);
                }

            }
            catch (Exception ex)
            {
                Util.Alertbootsrap(string.Concat(ex.Message), this, upSalvar);
            }
        }
        private void habilitaPanel(string questao, HtmlGenericControl div, TextBox txt)
        {
            if (!string.IsNullOrEmpty(questao))
            {
                div.Attributes.Remove("style");
                cbList.Items.FindByText(questao).Selected = true;
                txt.Text = questao;
            }
        }
        private async Task populaCampos()
        {
            try
            {
                if (!string.IsNullOrEmpty(Request.QueryString["id_caso"]))
                {

                    var id_caso = int.Parse(Util.Decrypt(Request.QueryString["id_caso"]));
                    lblSubTituloCaso.Text = id_caso.ToString();

                    if (Request.QueryString.ToString().Contains("tipo"))
                        idTipo = Convert.ToInt32(Request.QueryString["tipo"]);
                    else
                        idTipo = 0;

                    UserControlExecQuestao1.tipoFormulario = idTipo;
                    UserControlExecQuestao3.tipoFormulario = idTipo;
                    UserControlQuestao11.tipoFormulario = idTipo;

                    Formulario form = new Formulario();

                    form = await formularioBll.readAsync(id_caso, idTipo);

                    if (form != null)
                    {
                        lblTitulo.Text = form.TipoFormulario.tipo;
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
                        UserControlHeader.valorRequerido = form.valor_requerido != null ? string.Format("{0:C}", Convert.ToDecimal(form.valor_requerido)) : string.Empty; ;
                        hfFormularioId.Value = form.id.ToString();

                        if (form.status != null)
                        {
                            lblStatusReabertura.Text = string.Concat(" Reabertura: ", form.status);
                            if (form.status.Equals("Atualizar cumprimento"))
                            {
                                pPrincipalRespostaCumprimento.Visible = true;
                                RespostaOperacaoBll rBll = new RespostaOperacaoBll();
                                var r = await rBll.readAsync(form.id);
                                if (r != null)
                                {
                                    ViewState["idRespostaOperacao"] = r.id;
                                    txtRespostaOperacao.Text = r.respostaOperacao;
                                    txtSolicitacaoEscritorio.Text = r.solicitacaoEscritorio;
                                }
                            }
                        }


                        ExeLimiDescBll exeLimiDescBll = new ExeLimiDescBll();
                        var e = exeLimiDescBll.read(form.id);
                        if (e != null)
                        {
                            hfId.Value = e.id.ToString();

                            lblJustificativa.Text = e.justificativa;
                            lblInfoComplementares.Text = e.informacaoComplementar;
                            lblMotivoCumprimento.Text = e.motivoCumprimento;
                            lblDescricao.Text = e.descricao;
                            lblOrgao.Text = e.orgao;

                            txtDetalheQuestao_0.Text = e.detalhe_questao_0;
                            txtObsQuestao_1.Text = e.obs_questao_1;
                            habilitaPanel(e.questao_1, pQuestao_1, lblQuestao_1);
                            txtObsQuestao_2.Text = e.obs_questao_2;
                            habilitaPanel(e.questao_2, pQuestao_2, lblQuestao_2);
                            txtObsQuestao_3.Text = e.obs_questao_3;
                            habilitaPanel(e.questao_3, pQuestao_3, lblQuestao_3);
                            txtObsQuestao_4.Text = e.obs_questao_4;
                            habilitaPanel(e.questao_4, pQuestao_4, lblQuestao_4);
                            txtObsQuestao_5.Text = e.obs_questao_5;
                            habilitaPanel(e.questao_5, pQuestao_5, lblQuestao_5);
                            txtObsQuestao_6.Text = e.obs_questao_6;
                            habilitaPanel(e.questao_6, pQuestao_6, lblQuestao_6);
                            txtObsQuestao_7.Text = e.obs_questao_7;
                            habilitaPanel(e.questao_7, pQuestao_7, lblQuestao_7);
                            txtObsQuestao_8.Text = e.obs_questao_8;
                            habilitaPanel(e.questao_8, pQuestao_8, lblQuestao_8);
                            txtObsQuestao_9.Text = e.obs_questao_9;
                            habilitaPanel(e.questao_9, pQuestao_9, lblQuestao_9);
                            txtObsQuestao_10.Text = e.obs_questao_10;
                            habilitaPanel(e.questao_10, pQuestao_10, lblQuestao_10);
                            txtObsQuestao_11.Text = e.obs_questao_11;
                            habilitaPanel(e.questao_11, pQuestao_11, lblQuestao_11);
                            txtObsQuestao_12.Text = e.obs_questao_12;
                            habilitaPanel(e.questao_12, pQuestao_12, lblQuestao_12);
                            txtObsQuestao_13.Text = e.obs_questao_13;
                            habilitaPanel(e.questao_13, pQuestao_13, lblQuestao_13);
                            txtObsQuestao_14.Text = e.obs_questao_14;
                            habilitaPanel(e.questao_14, pQuestao_14, lblQuestao_14);
                            txtObsQuestao_15.Text = e.obs_questao_15;
                            habilitaPanel(e.questao_15, pQuestao_15, lblQuestao_15);
                            txtObsQuestao_16.Text = e.obs_questao_16;
                            habilitaPanel(e.questao_16, pQuestao_16, lblQuestao_16);
                            txtObsQuestao_17.Text = e.obs_questao_17;
                            habilitaPanel(e.questao_17, pQuestao_17, lblQuestao_17);
                            txtObsQuestao_18.Text = e.obs_questao_18;
                            habilitaPanel(e.questao_18, pQuestao_18, lblQuestao_18);
                            txtObsQuestao_19.Text = e.obs_questao_19;
                            habilitaPanel(e.questao_19, pQuestao_19, lblQuestao_19);
                            txtObsQuestao_20.Text = e.obs_questao_20;
                            habilitaPanel(e.questao_20, pQuestao_20, lblQuestao_20);
                            txtObsQuestao_21.Text = e.obs_questao_21;
                            habilitaPanel(e.questao_21, pQuestao_21, lblQuestao_21);
                            txtObsQuestao_22.Text = e.obs_questao_22;
                            habilitaPanel(e.questao_22, pQuestao_22, lblQuestao_22);
                            txtObsQuestao_23.Text = e.obs_questao_23;
                            habilitaPanel(e.questao_23, pQuestao_23, lblQuestao_23);
                            txtObsQuestao_24.Text = e.obs_questao_24;
                            habilitaPanel(e.questao_24, pQuestao_24, lblQuestao_24);
                            txtObsQuestao_25.Text = e.obs_questao_25;
                            habilitaPanel(e.questao_25, pQuestao_25, lblQuestao_25);
                            txtObsQuestao_26.Text = e.obs_questao_26;
                            habilitaPanel(e.questao_26, pQuestao_26, lblQuestao_26);
                            txtObsQuestao_27.Text = e.obs_questao_27;
                            habilitaPanel(e.questao_27, pQuestao_27, lblQuestao_27);
                            txtObsQuestao_28.Text = e.obs_questao_28;
                            habilitaPanel(e.questao_28, pQuestao_28, lblQuestao_28);
                            txtObsQuestao_29.Text = e.obs_questao_29;
                            habilitaPanel(e.questao_29, pQuestao_29, lblQuestao_29);
                            txtObsQuestao_30.Text = e.obs_questao_30;
                            habilitaPanel(e.questao_30, pQuestao_30, lblQuestao_30);
                            txtObsQuestao_31.Text = e.obs_questao_31;
                            habilitaPanel(e.questao_31, pQuestao_31, lblQuestao_31);
                            txtObsQuestao_32.Text = e.obs_questao_32;
                            habilitaPanel(e.questao_32, pQuestao_32, lblQuestao_32);
                            txtObsQuestao_33.Text = e.obs_questao_33;
                            habilitaPanel(e.questao_33, pQuestao_33, lblQuestao_33);
                            txtObsQuestao_34.Text = e.obs_questao_34;
                            habilitaPanel(e.questao_34, pQuestao_34, lblQuestao_34);
                            txtObsQuestao_35.Text = e.obs_questao_35;
                            habilitaPanel(e.questao_35, pQuestao_35, lblQuestao_35);
                            txtObsQuestao_36.Text = e.obs_questao_36;
                            habilitaPanel(e.questao_36, pQuestao_36, lblQuestao_36);
                            txtObsQuestao_37.Text = e.obs_questao_37;
                            habilitaPanel(e.questao_37, pQuestao_37, lblQuestao_37);
                            txtObsQuestao_38.Text = e.obs_questao_38;
                            habilitaPanel(e.questao_38, pQuestao_38, lblQuestao_38);
                            txtObsQuestao_39.Text = e.obs_questao_39;
                            habilitaPanel(e.questao_39, pQuestao_39, lblQuestao_39);
                            txtObsQuestao_40.Text = e.obs_questao_40;
                            habilitaPanel(e.questao_40, pQuestao_40, lblQuestao_40);
                            txtObsQuestao_41.Text = e.obs_questao_41;
                            habilitaPanel(e.questao_41, pQuestao_41, lblQuestao_41);
                            txtObsQuestao_42.Text = e.obs_questao_42;
                            habilitaPanel(e.questao_42, pQuestao_42, lblQuestao_42);
                            txtObsQuestao_43.Text = e.obs_questao_43;
                            habilitaPanel(e.questao_43, pQuestao_43, lblQuestao_43);
                            txtObsQuestao_44.Text = e.obs_questao_44;
                            habilitaPanel(e.questao_44, pQuestao_44, lblQuestao_44);
                            txtObsQuestao_45.Text = e.obs_questao_45;
                            habilitaPanel(e.questao_45, pQuestao_45, lblQuestao_45);
                            txtObsQuestao_46.Text = e.obs_questao_46;
                            habilitaPanel(e.questao_46, pQuestao_46, lblQuestao_46);
                            txtObsQuestao_47.Text = e.obs_questao_47;
                            habilitaPanel(e.questao_47, pQuestao_47, lblQuestao_47);
                            txtObsQuestao_48.Text = e.obs_questao_48;
                            habilitaPanel(e.questao_48, pQuestao_48, lblQuestao_48);
                            txtObsQuestao_51.Text = e.obs_questao_51;
                            habilitaPanel(e.questao_51, pQuestao_51, lblQuestao_51);
                            txtObsQuestao_49.Text = e.obs_questao_49;
                            habilitaPanel(e.questao_49, pQuestao_49, lblQuestao_49);
                            txtObsQuestao_50.Text = e.obs_questao_50;
                            habilitaPanel(e.questao_50, pQuestao_50, lblQuestao_50);
                            txtObsQuestao_51.Text = e.obs_questao_51;
                            habilitaPanel(e.questao_51, pQuestao_51, lblQuestao_51);
                            txtObsQuestao_52.Text = e.obs_questao_52;
                            habilitaPanel(e.questao_52, pQuestao_52, lblQuestao_52);
                            txtObsQuestao_53.Text = e.obs_questao_53;
                            habilitaPanel(e.questao_53, pQuestao_53, lblQuestao_53);
                            txtObsQuestao_53.Text = e.obs_questao_53;
                            habilitaPanel(e.questao_54, pQuestao_54, lblQuestao_54);
                            txtObsQuestao_54.Text = e.obs_questao_54;
                            habilitaPanel(e.questao_54, pQuestao_54, lblQuestao_54);
                            txtObsQuestao_55.Text = e.obs_questao_55;
                            habilitaPanel(e.questao_55, pQuestao_55, lblQuestao_55);
                            txtObsQuestao_55.Text = e.obs_questao_55;
                            habilitaPanel(e.questao_55, pQuestao_55, lblQuestao_55);
                            txtObsQuestao_56.Text = e.obs_questao_56;
                            habilitaPanel(e.questao_56, pQuestao_56, lblQuestao_56);
                            txtObsQuestao_57.Text = e.obs_questao_57;
                            habilitaPanel(e.questao_57, pQuestao_57, lblQuestao_57);
                            txtObsQuestao_58.Text = e.obs_questao_58;
                            habilitaPanel(e.questao_58, pQuestao_58, lblQuestao_58);
                            txtObsQuestao_59.Text = e.obs_questao_59;
                            habilitaPanel(e.questao_59, pQuestao_59, lblQuestao_59);
                            txtObsQuestao_60.Text = e.obs_questao_60;
                            habilitaPanel(e.questao_60, pQuestao_60, lblQuestao_60);
                            txtObsQuestao_61.Text = e.obs_questao_61;
                            habilitaPanel(e.questao_61, pQuestao_61, lblQuestao_61);
                            txtObsQuestao_62.Text = e.obs_questao_62;
                            habilitaPanel(e.questao_62, pQuestao_62, lblQuestao_62);
                            txtFinalizacao.Text = e.consideracao;
                        }

                        await UserControlExecQuestao1.PopulaQuestao1(form.id, form.status, form.empresa, form.produto, form.estado, form.cidade);
                        await UserControlExecQuestao3.PopulaQuestao3(form);

                        await UserControlQuestao11.populaCampos(form.id, form.status);
                        await UserControlQuestao13.populaCampos(form.id, form.status);
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
            ExeLimiDesc exec = new ExeLimiDesc();
            exec.preenchimentoCompleto = false;
            update(exec);
        }

        protected void btnConcluir_Click(object sender, EventArgs e)
        {
            ExeLimiDesc exec = new ExeLimiDesc();
            exec.preenchimentoCompleto = true;
            update(exec);
        }

    }
}


