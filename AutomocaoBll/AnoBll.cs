using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class AnoBll
    {
        IAnoDal anoDal = new AnoDal();
        public Ano read(int id)
        {
            return anoDal.read().Where(x => x.id == id).FirstOrDefault();
        }
   
        public List<Ano> list()
        {
            return anoDal.read().ToList();
        }
        public async Task<List<Ano>> listAsyncAll()
        {
            return await anoDal.listAsyncAll();
        }

    }
}
