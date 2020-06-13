using AutomacaoBll;
using Microsoft.Reporting.WebForms;
using System;
using System.Linq;
using System.Web.UI;

namespace AutomacaoWeb.template
{
    public partial class RptPortabilidade : System.Web.UI.Page
    {
        private void exportaPdf()
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                ImagemBll imagemBll = new ImagemBll();
                PortabilidadeBLL portabilidadeBLL = new PortabilidadeBLL();

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\template\RptPortabilidade.rdlc");

                var listFormulario = formularioBll.cabecalhoPdf(Convert.ToInt32(Request.QueryString["id_caso"]), (int)Util.TFormulario.Portabilidade);
                int idPortabilidade = Convert.ToInt32(listFormulario.Rows[0]["id"]);
                var listNegativacao = portabilidadeBLL.list(idPortabilidade);

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptFormulario", listFormulario));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptPortabilidade", listNegativacao));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1", imagemBll.read(idPortabilidade, 1, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_1", imagemBll.read(idPortabilidade, 1, 1)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_2", imagemBll.read(idPortabilidade, 1, 2)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_3", imagemBll.read(idPortabilidade, 1, 3)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_4", imagemBll.read(idPortabilidade, 1, 4)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_2", imagemBll.read(idPortabilidade, 2, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_3", imagemBll.read(idPortabilidade, 3, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_4", imagemBll.read(idPortabilidade, 4, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_5", imagemBll.read(idPortabilidade, 5, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_6", imagemBll.read(idPortabilidade, 6, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7", imagemBll.read(idPortabilidade, 7, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_8", imagemBll.read(idPortabilidade, 8, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_9", imagemBll.read(idPortabilidade, 9, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_10", imagemBll.read(idPortabilidade, 10, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_11", imagemBll.read(idPortabilidade, 11, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_12", imagemBll.read(idPortabilidade, 12, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_13", imagemBll.read(idPortabilidade, 13, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_14", imagemBll.read(idPortabilidade, 14, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_15", imagemBll.read(idPortabilidade, 15, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_16", imagemBll.read(idPortabilidade, 16, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_17", imagemBll.read(idPortabilidade, 17, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_18", imagemBll.read(idPortabilidade, 18, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_19", imagemBll.read(idPortabilidade, 19, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_20", imagemBll.read(idPortabilidade, 20, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_21", imagemBll.read(idPortabilidade, 21, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_22", imagemBll.read(idPortabilidade, 22, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_23", imagemBll.read(idPortabilidade, 23, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_24", imagemBll.read(idPortabilidade, 24, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_25", imagemBll.read(idPortabilidade, 25, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_26", imagemBll.read(idPortabilidade, 26, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_27", imagemBll.read(idPortabilidade, 27, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_28", imagemBll.read(idPortabilidade, 28, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_29", imagemBll.read(idPortabilidade, 29, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_31", imagemBll.read(idPortabilidade, 31, null)));

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = ReportViewer1.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = mimeType.ToString();
                Response.AddHeader("content-disposition", "attachment; filename= " + string.Concat("Subsidio-Portabilidade-", DateTime.Now.ToString("ddMMyyyy"), ".pdf") + "");
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