using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class ProblemasComVendasBLL
    {
        IProblemasComVendas problemaVendasBLL = new ProblemasComVendasDal();
        public async Task< ProblemasComVenda> read(int id)
        {
            return await problemaVendasBLL.readAsync(x => x.formularioId == id);
        }

        public List<ProblemasComVenda> list(int idCaso)
        {
            return problemaVendasBLL.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(ProblemasComVenda p)
        {
            if (p.id == 0)
                problemaVendasBLL.create(p);
            else
                problemaVendasBLL.update(p);
        }
    }
}
