using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class PendenteBLL
    {
        IPendenteDal pendenteBll = new PendenteDal();
        public Pendente read(int id)
        {
            return pendenteBll.read().Where(x => x.id == id).FirstOrDefault();
        }

        public async Task<List<Pendente>> listAsyncAll()
        {
            return await pendenteBll.listAsyncAll();
        }
    }
}
