using AutomacaoBll;
using AutomacaoModel;
using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;

namespace AutomacaoWeb.template
{
    public partial class RptExecLimiDesc : System.Web.UI.Page
    {
        private void exportaPdf()
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                ImagemBll imagemBll = new ImagemBll();
                ExeLimiDescBll ExecLimiDescBLL = new ExeLimiDescBll();
                List<Imagem> listNull = new List<Imagem>();
                listNull.Add(null);

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\template\RptExecLimiDesc.rdlc");

                var listFormulario = formularioBll.cabecalhoPdf(Convert.ToInt32(Request.QueryString["id_caso"]), Convert.ToInt32(Request.QueryString["tipo"]));
                int idExecLimiDesc = Convert.ToInt32(listFormulario.Rows[0]["id"]);
                var listExecLimiDesc = ExecLimiDescBLL.list(idExecLimiDesc);

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptFormulario", listFormulario));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptExecLimiDesc", listExecLimiDesc));

                ReportParameter[] parametros = { new ReportParameter("ReportParameterTitulo", listExecLimiDesc.FirstOrDefault().Formulario.TipoFormulario.tipo) };
                ReportViewer1.LocalReport.SetParameters(parametros);

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_0", imagemBll.read(idExecLimiDesc, 0, null)));

                if (listExecLimiDesc.FirstOrDefault().questao_1 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1", imagemBll.read(idExecLimiDesc, 1, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_2 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_2", imagemBll.read(idExecLimiDesc, 2, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_2", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_3 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_3", imagemBll.read(idExecLimiDesc, 3, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_3", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_4 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_4", imagemBll.read(idExecLimiDesc, 4, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_4", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_5 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_5", imagemBll.read(idExecLimiDesc, 5, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_5", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_6 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_6", imagemBll.read(idExecLimiDesc, 6, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_6", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_7 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7", imagemBll.read(idExecLimiDesc, 7, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_8 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_8", imagemBll.read(idExecLimiDesc, 8, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_8", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_9 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_9", imagemBll.read(idExecLimiDesc, 9, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_9", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_10 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_10", imagemBll.read(idExecLimiDesc, 10, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_10", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_11 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_11", imagemBll.read(idExecLimiDesc, 11, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_11", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_12 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_12", imagemBll.read(idExecLimiDesc, 12, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_12", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_13 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_13", imagemBll.read(idExecLimiDesc, 13, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_13", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_14 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_14", imagemBll.read(idExecLimiDesc, 14, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_14", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_15 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_15", imagemBll.read(idExecLimiDesc, 15, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_15", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_16 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_16", imagemBll.read(idExecLimiDesc, 16, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_16", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_17 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_17", imagemBll.read(idExecLimiDesc, 17, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_17", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_18 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_18", imagemBll.read(idExecLimiDesc, 18, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_18", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_19 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_19", imagemBll.read(idExecLimiDesc, 19, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_19", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_20 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_20", imagemBll.read(idExecLimiDesc, 20, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_20", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_21 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_21", imagemBll.read(idExecLimiDesc, 21, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_21", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_22 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_22", imagemBll.read(idExecLimiDesc, 22, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_22", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_23 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_23", imagemBll.read(idExecLimiDesc, 23, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_23", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_24 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_24", imagemBll.read(idExecLimiDesc, 24, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_24", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_25 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_25", imagemBll.read(idExecLimiDesc, 25, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_25", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_26 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_26", imagemBll.read(idExecLimiDesc, 26, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_26", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_27 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_27", imagemBll.read(idExecLimiDesc, 27, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_27", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_28 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_28", imagemBll.read(idExecLimiDesc, 28, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_28", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_29 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_29", imagemBll.read(idExecLimiDesc, 29, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_29", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_30 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_30", imagemBll.read(idExecLimiDesc, 30, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_30", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_31 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_31", imagemBll.read(idExecLimiDesc, 31, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_31", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_32 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_32", imagemBll.read(idExecLimiDesc, 32, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_32", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_33 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_33", imagemBll.read(idExecLimiDesc, 33, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_33", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_34 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_34", imagemBll.read(idExecLimiDesc, 34, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_34", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_35 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_35", imagemBll.read(idExecLimiDesc, 35, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_35", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_36 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_36", imagemBll.read(idExecLimiDesc, 36, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_36", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_37 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_37", imagemBll.read(idExecLimiDesc, 37, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_37", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_38 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_38", imagemBll.read(idExecLimiDesc, 38, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_38", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_39 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_39", imagemBll.read(idExecLimiDesc, 39, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_39", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_40 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_40", imagemBll.read(idExecLimiDesc, 40, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_40", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_41 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_41", imagemBll.read(idExecLimiDesc, 41, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_41", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_42 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_42", imagemBll.read(idExecLimiDesc, 42, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_42", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_43 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_43", imagemBll.read(idExecLimiDesc, 43, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_43", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_44 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_44", imagemBll.read(idExecLimiDesc, 44, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_44", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_45 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_45", imagemBll.read(idExecLimiDesc, 45, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_45", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_46 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_46", imagemBll.read(idExecLimiDesc, 46, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_46", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_47 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_47", imagemBll.read(idExecLimiDesc, 47, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_47", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_48 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_48", imagemBll.read(idExecLimiDesc, 48, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_48", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_49 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_49", imagemBll.read(idExecLimiDesc, 49, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_49", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_50 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_50", imagemBll.read(idExecLimiDesc, 50, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_50", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_51 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_51", imagemBll.read(idExecLimiDesc, 51, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_51", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_52 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_52", imagemBll.read(idExecLimiDesc, 52, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_52", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_53 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_53", imagemBll.read(idExecLimiDesc, 53, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_53", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_54 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_54", imagemBll.read(idExecLimiDesc, 54, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_54", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_55 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_55", imagemBll.read(idExecLimiDesc, 55, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_55", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_56 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_56", imagemBll.read(idExecLimiDesc, 56, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_56", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_57 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_57", imagemBll.read(idExecLimiDesc, 57, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_57", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_58 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_58", imagemBll.read(idExecLimiDesc, 58, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_58", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_59 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_59", imagemBll.read(idExecLimiDesc, 59, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_59", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_60 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_60", imagemBll.read(idExecLimiDesc, 60, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_60", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_61 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_61", imagemBll.read(idExecLimiDesc, 61, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_61", listNull));

                if (listExecLimiDesc.FirstOrDefault().questao_62 != null)
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_62", imagemBll.read(idExecLimiDesc, 62, null)));
                else
                    ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_62", listNull));

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = ReportViewer1.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = mimeType.ToString();
                Response.AddHeader("content-disposition", "attachment; filename= " + string.Concat(listExecLimiDesc.FirstOrDefault().Formulario.TipoFormulario.tipo.Replace("ç","c").Replace("ã", "a"), "-", DateTime.Now.ToString("ddMMyyyy"), ".pdf") + "");
                Response.BinaryWrite(bytes);
                Response.Flush();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
                exportaPdf();
        }
    }
}