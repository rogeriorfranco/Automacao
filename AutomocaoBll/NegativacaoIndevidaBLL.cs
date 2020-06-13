using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class NegativacaoIndevidaBLL
    {
        INegativacaoIndevidaDal negIndevidaBll = new NegativacaoIndevidaDal();
        public async Task<NegativacaoIndevida> read(int id)
        {
            return await negIndevidaBll.readAsync(x => x.formularioId == id);
        }

        public List<NegativacaoIndevida> list(int idCaso)
        {
            return negIndevidaBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(NegativacaoIndevida n)
        {
            if (n.id == 0)
                negIndevidaBll.create(n);
            else
                negIndevidaBll.update(n);
        }
    }
}
