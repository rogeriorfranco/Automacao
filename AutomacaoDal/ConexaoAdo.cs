using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public class ConexaoAdo
    {
        public static string connectionString = ConfigurationManager.AppSettings["connectionString"];

        #region Métodos
        public static SqlConnection AbreConexao()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = connectionString;
                if (Con.State == ConnectionState.Closed)
                    Con.Open();

            }
            catch (Exception ex)
            {
                throw new Exception("ConnectionSqlDAL.AbreConexao(): " + ex.Message, ex.InnerException);
            }
            return Con;
        }
        public static void FechaConexao(SqlConnection ConParam)
        {
            try
            {
                ConParam.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ConnectionSqlDAL.FechaConexao(): " + ex.Message, ex.InnerException);
            }
        }
        public static async Task<DataTable> ExecutaSqlRetornoAsync(string Sql)
        {
            SqlConnection Conexao = AbreConexao();
            DataSet DadosRet = new DataSet();
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;

                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Comando;
                Adaptador.Fill(DadosRet);

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO ConnectionSql.ExecutaSqlRetorno(Sql): " + ex.Message, ex.InnerException);
            }
            finally
            {
                FechaConexao(Conexao);
            }
            return await Task.Run(() => { return DadosRet.Tables[0]; });
        }
        public static async Task<int> ExecutaSqlAsync(string Sql)
        {
            SqlTransaction Transacao = default(SqlTransaction);
            SqlConnection Conexao = AbreConexao();
            Transacao = Conexao.BeginTransaction();
            int N = -1;
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.Transaction = Transacao;
                N = await Comando.ExecuteNonQueryAsync();
                Transacao.Commit();
            }
            catch (Exception ex)
            {
                Transacao.Rollback();
                throw new Exception("ConnectionSqlDAL.ExecutaSql(Sql): " + ex.Message);
            }
            finally
            {
                FechaConexao(Conexao);
                Transacao.Dispose();
            }
            return N;
        }
        public static int ExecutaSql(string Sql)
        {
            SqlTransaction Transacao = default(SqlTransaction);
            SqlConnection Conexao = AbreConexao();
            Transacao = Conexao.BeginTransaction();
            int N = -1;
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;
                Comando.Transaction = Transacao;
                N = Comando.ExecuteNonQuery();
                Transacao.Commit();
            }
            catch (Exception ex)
            {
                Transacao.Rollback();
                throw new Exception("ConnectionSqlDAL.ExecutaSql(Sql): " + ex.Message);
            }
            finally
            {
                FechaConexao(Conexao);
                Transacao.Dispose();
            }
            return N;
        }
        public static DataRow ExecutaSqlRetornoRegistro(string Sql)
        {
            SqlConnection Conexao = AbreConexao();
            DataSet DadosRet = new DataSet();
            DataRow Reg = null;
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexao;
                comando.CommandType = CommandType.Text;
                comando.CommandText = Sql;

                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = comando;
                Adaptador.Fill(DadosRet);

                if (DadosRet.Tables[0].Rows.Count > 0)
                    Reg = DadosRet.Tables[0].Select()[0];

            }
            catch (Exception ex)
            {
                throw new Exception("ConnectionSqlDAL.ExecutaSqlRetornoRegistro(Sql): " + ex.Message, ex.InnerException);
            }
            finally
            {
                FechaConexao(Conexao);
            }

            return Reg;
        }
        public static DataTable ExecutaSqlRetorno(string Sql)
        {
            SqlConnection Conexao = AbreConexao();
            DataSet DadosRet = new DataSet();
            try
            {
                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Conexao;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = Sql;

                SqlDataAdapter Adaptador = new SqlDataAdapter();
                Adaptador.SelectCommand = Comando;
                Adaptador.Fill(DadosRet);

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO ConnectionSql.ExecutaSqlRetorno(Sql): " + ex.Message, ex.InnerException);
            }
            finally
            {
                FechaConexao(Conexao);
            }
            return DadosRet.Tables[0];
        }

        #endregion
    }
}
