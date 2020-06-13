using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class PortabilidadeBLL
    {
        IPortabilidadeDal portabilidadeBll = new PortabilidadeDal();
        public async Task<Portabilidade> read(int id)
        {
            return await portabilidadeBll.readAsync(x => x.formularioId == id);
        }

        public List<Portabilidade> list(int idCaso)
        {
            return portabilidadeBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(Portabilidade p)
        {
            if (p.id == 0)
                portabilidadeBll.create(p);
            else
                portabilidadeBll.update(p);
        }
    }
}

