using AutomacaoModel;
using System.Data;
using System.Threading.Tasks;

namespace AutomacaoDal
{
    public interface IMotivoDal : IGenericCrudDal<Motivo>
    {
        Task<DataTable> listAsync(int areaCausadoraId);
    }
}
