using AutomacaoBll;
using Microsoft.Reporting.WebForms;
using System;
using System.Web.UI;

namespace AutomacaoWeb.template
{
    public partial class RptProblemaTecnico : System.Web.UI.Page
    {
        private void exportaPdf()
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                ImagemBll imagemBll = new ImagemBll();
                ProblemaTecnicoBLL ProblemasTecnicosBLL = new ProblemaTecnicoBLL();

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\template\RptProblemaTecnico.rdlc");

                var listFormulario = formularioBll.cabecalhoPdf(Convert.ToInt32(Request.QueryString["id_caso"]), (int)Util.TFormulario.ProblemasTecnicos);
                int idProblemasTecnicos = Convert.ToInt32(listFormulario.Rows[0]["id"]);
                var listProblemasTecnicos = ProblemasTecnicosBLL.list(idProblemasTecnicos);

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptFormulario", listFormulario));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptProblemasTecnicos", listProblemasTecnicos));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1", imagemBll.read(idProblemasTecnicos, 1, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_1", imagemBll.read(idProblemasTecnicos, 1, 1)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_2", imagemBll.read(idProblemasTecnicos, 1, 2)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_3", imagemBll.read(idProblemasTecnicos, 1, 3)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_4", imagemBll.read(idProblemasTecnicos, 1, 4)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_2", imagemBll.read(idProblemasTecnicos, 2, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_3", imagemBll.read(idProblemasTecnicos, 3, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_4", imagemBll.read(idProblemasTecnicos, 4, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_5", imagemBll.read(idProblemasTecnicos, 5, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_6", imagemBll.read(idProblemasTecnicos, 6, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7", imagemBll.read(idProblemasTecnicos, 7, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_8", imagemBll.read(idProblemasTecnicos, 8, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_9", imagemBll.read(idProblemasTecnicos, 9, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_10", imagemBll.read(idProblemasTecnicos, 10, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_11", imagemBll.read(idProblemasTecnicos, 11, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_12", imagemBll.read(idProblemasTecnicos, 12, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_13", imagemBll.read(idProblemasTecnicos, 13, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_14", imagemBll.read(idProblemasTecnicos, 14, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_15", imagemBll.read(idProblemasTecnicos, 15, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_16", imagemBll.read(idProblemasTecnicos, 16, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_17", imagemBll.read(idProblemasTecnicos, 17, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_19", imagemBll.read(idProblemasTecnicos, 19, null)));

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = ReportViewer1.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);                

                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = mimeType.ToString();
                Response.AddHeader("content-disposition", "attachment; filename= " + string.Concat("Subsidio-ProblemasTecnicos-", DateTime.Now.ToString("ddMMyyyy"), ".pdf") + "");
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