using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class FraudeBll
    {
        IFraudeDal fraudeBll = new FraudeDal();
        public async Task<Fraude> read(int id)
        {
            return await fraudeBll.readAsync(x => x.formularioId == id);
        }

        public async Task<Fraude> readById(int id)
        {
            return await fraudeBll.readAsync(x => x.id == id);
        }

        public List<Fraude> list(int idCaso)
        {
            return fraudeBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(Fraude f)
        {
            if (f.id == 0)
                fraudeBll.create(f);
            else
                fraudeBll.update(f);
        }
    }
}
