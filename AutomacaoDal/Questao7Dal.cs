using AutomacaoModel;
using System;
using System.Text;

namespace AutomacaoDal
{
    public class Questao7Dal : GenericCrudDal<Questao7>, IQuestao7Dal
    {

        public string readPendente(int id)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select PendenteValor from TbQuestao7 where formularioId=" + id + " ");
                return ConexaoAdo.ExecutaSqlRetornoRegistro(sql.ToString())["PendenteValor"].ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
