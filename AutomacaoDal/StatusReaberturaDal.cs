using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;

namespace AutomacaoDal
{
    public class StatusReaberturaDal : GenericCrudDal<StatusReabertura>, IStatusReaberturaDal
    {
        public List<string> listAll()
        {
            return (from a in read()
                    select a.descricao).ToList();
        }
    }
}
