using AutomacaoModel;
using System.Data;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public interface ISubMotivoDal : IGenericCrudDal<SubMotivo>
    {
        Task<DataTable> listAsync(int motivoId);
    }
}
