using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class EntregaAparelhoBLL
    {
        IEntregaAparelhoDal entregaAparelhoDal = new EntregaAparelhoDal();
        public async Task<EntregaAparelho> read(int id)
        {
            return await entregaAparelhoDal.readAsync(x => x.formularioId == id);
        }

        public List<EntregaAparelho> list(int idCaso)
        {
            return entregaAparelhoDal.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(EntregaAparelho f)
        {
            if (f.id == 0)
                entregaAparelhoDal.create(f);
            else
                entregaAparelhoDal.update(f);
        }
    }
}
