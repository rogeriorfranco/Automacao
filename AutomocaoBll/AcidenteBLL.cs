using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class AcidenteBLL
    {
        IAcidenteDal acordoPrevioBll = new AcidenteDal();
        public async Task<Acidente> read(int id)
        {
            return await acordoPrevioBll.readAsync(x => x.formularioId == id);
        }

        public List<Acidente> list(int idCaso)
        {
            return acordoPrevioBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(Acidente f)
        {
            if (f.id == 0)
                acordoPrevioBll.create(f);
            else
                acordoPrevioBll.update(f);
        }
    }
}

