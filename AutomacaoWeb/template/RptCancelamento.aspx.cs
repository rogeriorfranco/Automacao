using AutomacaoBll;
using Microsoft.Reporting.WebForms;
using System;
using System.Web.UI;

namespace AutomacaoWeb.template
{
    public partial class RptCancelamento : System.Web.UI.Page
    {
        private void exportaPdf()
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                ImagemBll imagemBll = new ImagemBll();
                CancelamentoBll cancelamentoBLL = new CancelamentoBll();

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\template\RptCancelamento.rdlc");

                var listFormulario = formularioBll.cabecalhoPdf(Convert.ToInt32(Request.QueryString["id_caso"]), (int)Util.TFormulario.Cancelamento);
                int idCancelamento = Convert.ToInt32(listFormulario.Rows[0]["id"]); 
                var listcancelamento = cancelamentoBLL.list(idCancelamento);

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptFormulario", listFormulario));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptCancelamento", listcancelamento));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1", imagemBll.read(idCancelamento, 1, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_1", imagemBll.read(idCancelamento, 1, 1)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_2", imagemBll.read(idCancelamento, 1, 2)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1_3", imagemBll.read(idCancelamento, 1, 3)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_2", imagemBll.read(idCancelamento, 2, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_3", imagemBll.read(idCancelamento, 3, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_4", imagemBll.read(idCancelamento, 4, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_5", imagemBll.read(idCancelamento, 5, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_6", imagemBll.read(idCancelamento, 6, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7", imagemBll.read(idCancelamento, 7, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_8", imagemBll.read(idCancelamento, 8, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_9", imagemBll.read(idCancelamento, 9, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_10", imagemBll.read(idCancelamento, 10, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_11", imagemBll.read(idCancelamento, 11, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_12", imagemBll.read(idCancelamento, 12, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_13", imagemBll.read(idCancelamento, 13, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_14", imagemBll.read(idCancelamento, 14, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_15", imagemBll.read(idCancelamento, 15, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_16", imagemBll.read(idCancelamento, 16, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_17", imagemBll.read(idCancelamento, 17, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_18", imagemBll.read(idCancelamento, 18, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_19", imagemBll.read(idCancelamento, 19, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_20", imagemBll.read(idCancelamento, 20, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_21", imagemBll.read(idCancelamento, 21, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_22", imagemBll.read(idCancelamento, 22, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_23", imagemBll.read(idCancelamento, 23, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_24", imagemBll.read(idCancelamento, 24, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_25", imagemBll.read(idCancelamento, 25, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_26", imagemBll.read(idCancelamento, 26, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_28", imagemBll.read(idCancelamento, 28, null)));

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = ReportViewer1.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = mimeType.ToString();
                Response.AddHeader("content-disposition", "attachment; filename= " + string.Concat("Subsidio-Cancelamento-", DateTime.Now.ToString("ddMMyyyy"), ".pdf") + "");
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