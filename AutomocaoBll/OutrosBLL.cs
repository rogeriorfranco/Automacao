using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class OutrosBLL
    {
        IOutrosDal outrosBll = new OutrosDal();
        public async Task<Outros> read(int id)
        {
            return await outrosBll.readAsync(x => x.formularioId == id);
        }

        public List<Outros> list(int idCaso)
        {
            return outrosBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(Outros f)
        {
            if (f.id == 0)
                outrosBll.create(f);
            else
                outrosBll.update(f);
        }
    }
}
