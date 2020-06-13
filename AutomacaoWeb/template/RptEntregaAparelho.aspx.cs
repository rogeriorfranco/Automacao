using AutomacaoBll;
using Microsoft.Reporting.WebForms;
using System;
using System.Web.UI;

namespace AutomacaoWeb.template
{
    public partial class RptEntregaAparelho : System.Web.UI.Page
    {
        private void exportaPdf()
        {
            try
            {
                FormularioBll formularioBll = new FormularioBll();
                ImagemBll imagemBll = new ImagemBll();
                EntregaAparelhoBLL entregaAparelhoBLL = new EntregaAparelhoBLL();

                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"~\template\RptEntregaAparelho.rdlc");

                var listFormulario = formularioBll.cabecalhoPdf(Convert.ToInt32(Request.QueryString["id_caso"]), (int)Util.TFormulario.EntregaAparelho);
                int idEntregaAparelho = Convert.ToInt32(listFormulario.Rows[0]["id"]);
                var listEntregaAparelho = entregaAparelhoBLL.list(idEntregaAparelho);

                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptFormulario", listFormulario));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsRptEntregaAparelho", listEntregaAparelho));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_1", imagemBll.read(idEntregaAparelho, 1, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_2", imagemBll.read(idEntregaAparelho, 2, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_3", imagemBll.read(idEntregaAparelho, 3, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_4", imagemBll.read(idEntregaAparelho, 4, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_5", imagemBll.read(idEntregaAparelho, 5, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_6", imagemBll.read(idEntregaAparelho, 6, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_7", imagemBll.read(idEntregaAparelho, 7, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_8", imagemBll.read(idEntregaAparelho, 8, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_9", imagemBll.read(idEntregaAparelho, 9, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_10", imagemBll.read(idEntregaAparelho, 10, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_11", imagemBll.read(idEntregaAparelho, 11, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_12", imagemBll.read(idEntregaAparelho, 12, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_13", imagemBll.read(idEntregaAparelho, 13, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_14", imagemBll.read(idEntregaAparelho, 14, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_15", imagemBll.read(idEntregaAparelho, 15, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_16", imagemBll.read(idEntregaAparelho, 16, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_17", imagemBll.read(idEntregaAparelho, 17, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_18", imagemBll.read(idEntregaAparelho, 18, null)));
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsImagemQuestao_20", imagemBll.read(idEntregaAparelho, 20, null)));

                Warning[] warnings;
                string[] streamids;
                string mimeType;
                string encoding;
                string extension;

                byte[] bytes = ReportViewer1.LocalReport.Render("pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

                Response.Buffer = true;
                Response.Clear();
                Response.ContentType = mimeType.ToString();
                Response.AddHeader("content-disposition", "attachment; filename= " + string.Concat("Subsidio-EntregaAparelho-", DateTime.Now.ToString("ddMMyyyy"), ".pdf") + "");
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