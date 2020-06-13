using AutomacaoModel;
using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public class MotivoDal : GenericCrudDal<Motivo>, IMotivoDal
    {

        public async Task<DataTable> listAsync(int areaCausadoraId)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select id, nome from TbMotivo where areaCausadoraId=" + areaCausadoraId);                         
                return await ConexaoAdo.ExecutaSqlRetornoAsync(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
