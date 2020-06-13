using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class CancelamentoBll
    {
        ICancelamentoDal cancelamentoDal = new CancelamentoDal();
        public async Task<Cancelamento> read(int id)
        {
            return await cancelamentoDal.readAsync(x => x.formularioId == id);
        }

        public List<Cancelamento> list(int idCaso)
        {
            return cancelamentoDal.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(Cancelamento f)
        {
            if (f.id == 0)
                cancelamentoDal.create(f);
            else
                cancelamentoDal.update(f);
        }
    }
}
