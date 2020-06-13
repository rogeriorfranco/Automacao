using AutomacaoModel;
using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public class SubMotivoDal : GenericCrudDal<SubMotivo>, ISubMotivoDal
    {
        public async Task<DataTable> listAsync(int motivoId)
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select id, nome from TbSubMotivo where motivoId=" + motivoId);
                return await ConexaoAdo.ExecutaSqlRetornoAsync(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
