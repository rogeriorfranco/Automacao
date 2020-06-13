using AutomacaoModel;
using System.Collections.Generic;

namespace AutomacaoDal
{
    public interface IStatusReaberturaDal : IGenericCrudDal<StatusReabertura>
    {
        List<string> listAll();
    }
}
