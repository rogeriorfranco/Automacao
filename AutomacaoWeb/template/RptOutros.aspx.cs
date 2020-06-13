using AutomacaoBll;
using Microsoft.Reporting.WebForms;
using System;
using System.Web.UI;

namespace AutomacaoWeb.template
{
    public partial class RptOutros : System.Web.UI.Page
    {
        private void exportaWord()
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                ImagemBll imagemBll = new ImagemBll();
                OutrosBLL outrosBLL = new OutrosBLL();

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\template\RptOutros.rdlc");

                var listFormulario = formularioBll.cabecalhoPdf(Convert.ToInt32(Request.QueryString["id_caso"]), (int)Util.TFormulario.Outros);
                int idOutros = Convert.ToInt32(listFormulario.Rows[0]["id"]);
                var listOutros = outrosBLL.list(idOutros);

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptFormulario", listFormulario));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptOutros", listOutros));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1", imagemBll.read(idOutros, 1, null)));             
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_2", imagemBll.read(idOutros, 2, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_3", imagemBll.read(idOutros, 3, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_4", imagemBll.read(idOutros, 4, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_5", imagemBll.read(idOutros, 5, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_6", imagemBll.read(idOutros, 6, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7", imagemBll.read(idOutros, 7, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_8", imagemBll.read(idOutros, 8, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_9", imagemBll.read(idOutros, 9, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_10", imagemBll.read(idOutros, 10, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_11", imagemBll.read(idOutros, 11, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_12", imagemBll.read(idOutros, 12, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_13", imagemBll.read(idOutros, 13, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_14", imagemBll.read(idOutros, 14, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_15", imagemBll.read(idOutros, 15, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_16", imagemBll.read(idOutros, 16, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_17", imagemBll.read(idOutros, 17, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7_1", imagemBll.read(idOutros, 7, 1)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7_2", imagemBll.read(idOutros, 7, 2)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7_3", imagemBll.read(idOutros, 7, 3)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_18", imagemBll.read(idOutros, 18, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_19", imagemBll.read(idOutros, 19, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_20", imagemBll.read(idOutros, 20, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_21", imagemBll.read(idOutros, 21, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_22", imagemBll.read(idOutros, 22, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_23", imagemBll.read(idOutros, 23, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_24", imagemBll.read(idOutros, 24, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_25", imagemBll.read(idOutros, 25, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_26", imagemBll.read(idOutros, 26, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_27", imagemBll.read(idOutros, 27, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_28", imagemBll.read(idOutros, 28, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_30", imagemBll.read(idOutros, 30, null)));


                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = ReportViewer1.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = mimeType.ToString();
                Response.AddHeader("content-disposition", "attachment; filename= " + string.Concat("Subsidio-Outros-", DateTime.Now.ToString("ddMMyyyy"), ".pdf") + "");
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
                exportaWord();
        }
    }
}