using AutomacaoModel;
using System.Data;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public interface IAreaCausadoraDal : IGenericCrudDal<AreaCausadora>
    {
        Task<DataTable> listAsync();
    }
}
