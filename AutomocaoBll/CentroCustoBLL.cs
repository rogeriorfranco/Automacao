using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class CentroCustoBLL
    {
        ICentroCustoDal centroCustoDal = new CentroCustoDal();
        public CentroCusto read(int id)
        {
            return centroCustoDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<CentroCusto> list()
        {
            return centroCustoDal.read().ToList();
        }
        public async Task<List<CentroCusto>> listAsync()
        {
            return await centroCustoDal.listAsync(x => x.ativo == true);
        }

        public void save(CentroCusto f)
        {
            if (f.id == 0)
                centroCustoDal.create(f);
            else
                centroCustoDal.update(f);
        }
    }
}
