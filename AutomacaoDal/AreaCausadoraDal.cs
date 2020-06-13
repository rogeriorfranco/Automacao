using AutomacaoModel;
using System;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public class AreaCausadoraDal : GenericCrudDal<AreaCausadora>, IAreaCausadoraDal
    {

        public async Task<DataTable> listAsync()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                sql.Append("select id,nome from TbAreaCausadora");
                return await ConexaoAdo.ExecutaSqlRetornoAsync(sql.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

    }
}
