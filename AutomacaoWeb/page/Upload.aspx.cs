using Microsoft.VisualBasic.FileIO;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace AutomacaoWeb.page
{
    public partial class Upload : System.Web.UI.Page
    {
        private void import(string nometabela, int indexFiltro_1, string[] filtro_1, string[] filtro_2)
        {
            lblCount.Text = string.Empty;
            string csvFilePath = string.Concat(Server.MapPath("~"), @"\upload\", FileUploadMalling.FileName);
            FileUploadMalling.SaveAs(csvFilePath);

            DataTable csvData = new DataTable();

            using (SqlConnection conn = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]))
            {
                conn.Open();

                using (TextFieldParser csvReader = new TextFieldParser(csvFilePath, Encoding.UTF7))
                {
                    csvReader.SetDelimiters(new string[] { ";" });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    int count = 0;
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        datecolumn.ColumnName = datecolumn.ColumnName + "_" + count.ToString();
                        csvData.Columns.Add(datecolumn);
                        count++;
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();

                        if (ckeckContains(fieldData[indexFiltro_1].ToString().ToLower(), filtro_1))
                            continue;

                        if (ckeckContains(fieldData[7].ToString().ToLower(), filtro_2))
                            continue;

                        if (nometabela.Equals("tbMailingBCCApartadoAcordoSubsidio") ||
                            nometabela.Equals("tbMailingBCCApartadoDEL") ||
                             nometabela.Equals("tbMailingBCCFinalizado"))
                        {
                            if (fieldData[0] != null && fieldData[0].ToString().Trim() == "")
                                fieldData[0] = null;

                            if (fieldData[19] != null && fieldData[19].ToString().Trim() == "")
                                fieldData[19] = null;

                            if (fieldData[20] != null && fieldData[20].ToString().Trim() == "")
                                fieldData[20] = null;

                            if (fieldData[21].ToString().Trim() == "")
                                fieldData[21] = null;

                            if (fieldData[22] != null && fieldData[22].ToString().Trim() == "")
                                fieldData[22] = null;

                            if (fieldData[23] != null && fieldData[23].ToString().Trim() == "")
                                fieldData[23] = null;

                            if (fieldData[65] != null && fieldData[65].ToString().Trim() == "")
                                fieldData[65] = null;

                            if (fieldData[84] != null && fieldData[84].ToString().Trim() == "")
                                fieldData[84] = null;

                            if (fieldData[88] != null && fieldData[88].ToString().Trim() == "")
                                fieldData[88] = null;

                            if (fieldData[150] != null && fieldData[150].ToString().Trim() == "")
                                fieldData[150] = null;

                            if (fieldData[152] != null && fieldData[152].ToString().Trim() == "")
                                fieldData[152] = null;

                            if (fieldData[154] != null && fieldData[154].ToString().Trim() == "")
                                fieldData[154] = null;
                        }

                        if (nometabela.Equals("tbMailingReabertura"))
                        {
                            if (fieldData[1] != null && fieldData[1].ToString().Trim() == "")
                                fieldData[1] = null;

                            if (fieldData[2] != null && fieldData[2].ToString().Trim() == "")
                                fieldData[2] = null;
                        }

                        using (SqlCommand cmd = new SqlCommand("spVerificarMailing", conn))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            SqlParameter idCaso = new SqlParameter("@idcaso", SqlDbType.BigInt);
                            idCaso.Direction = ParameterDirection.Input;
                            SqlParameter tabela = new SqlParameter("@nomeTabela", SqlDbType.VarChar);
                            idCaso.Direction = ParameterDirection.Input;

                            idCaso.Value = nometabela.Equals("tbMailingReabertura") ? fieldData[0] : fieldData[1];
                            tabela.Value = nometabela;

                            cmd.Parameters.Add(idCaso);
                            cmd.Parameters.Add(tabela);
                            cmd.ExecuteNonQuery();
                        }

                        csvData.Rows.Add(fieldData);
                    }

                    using (var connBulk = conn)
                    {
                        var bulkCopy = new SqlBulkCopy(conn);
                        bulkCopy.DestinationTableName = nometabela;
                        bulkCopy.BulkCopyTimeout = 360;
                        bulkCopy.WriteToServer(csvData);
                        lblCount.Text = string.Concat("Foram importadas ", csvData.Rows.Count.ToString(), " linhas");
          
                    }
                }
                File.Delete(csvFilePath);
            }
        }

        public bool ckeckContains(string field, params string[] values)
        {
            return values == null ? false : !values.Any(x => x == field);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFileUp_Click(object sender, EventArgs e)
        {
            switch (ddlTipoRelatorio.SelectedValue)
            {
                case "1 - 249: AcordoPrevio/Subsidio":
                    import("tbMailingBCCApartadoAcordoSubsidio", 3,
               new string[] { "incluir inf. operador", "executar cumprimento", "incluir atualização", "ajustar inf. demanda (cumprimento)", "ajustar inf. demanda (má qualidade)", "atualizar cumprimento" },
               new string[] { "acordo prévio", "subsídio" });
                    break;

                case "2 - 249: Execução/Liminar/Descumprimento":
                    import("tbMailingBCCApartadoDEL", 3,
               new string[] { "incluir inf. operador", "executar cumprimento", "incluir atualização", "ajustar inf. demanda (cumprimento)", "ajustar inf. demanda (má qualidade)", "atualizar cumprimento" },
               new string[] { "execução", "liminar", "descumprimento" });
                    break;

                case "3 - 249: Finalizados":
                    import("tbMailingBCCFinalizado", 3, null, null);
                    break;

                case "4 - Reabertura: Incluir Atualização":
                case "5 - Reabertura: Atualizar cumprimento":
                case "6 - Reabertura: Reanálise Má Qualidade":
                case "7 - Reabertura: Ajustar Inf. Demanda(Má Qualidade)":
                case "8 - Reabertura: Ajustar Inf. Demanda(Cumprimento)":
                case "9 - Reabertura: Executar Cumprimento":
                case "10 - Reabertura: Incluir Inf. Operador":
                    import("tbMailingReabertura", 4,
               new string[] { "incluir atualização", "atualizar cumprimento", "reanálise má qualidade", "ajustar inf. demanda (má qualidade)", "ajustar inf. demanda (cumprimento)", "executar cumprimento", "incluir inf. operador" },
               null);
                    break;

            }

        }
    }
}