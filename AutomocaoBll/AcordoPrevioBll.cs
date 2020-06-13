using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class AcordoPrevioBll
    {
        IAcordoPrevioDal acordoPrevioBll = new AcordoPrevioDal();
        public async Task<AcordoPrevio> read(int id)
        {
            return await acordoPrevioBll.readAsync(x => x.formularioId == id);
        }

        public List<AcordoPrevio> list(int idCaso)
        {
            return acordoPrevioBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(AcordoPrevio f)
        {
            if (f.id == 0)
                acordoPrevioBll.create(f);
            else
                acordoPrevioBll.update(f);
        }
    }
}
