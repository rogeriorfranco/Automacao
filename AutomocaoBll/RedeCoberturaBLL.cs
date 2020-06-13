using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class RedeCoberturaBLL
    {
        IRedeCobertura redeCoberturaBll = new RedeCoberturaDal();
        public async Task<RedeCobertura> read(int id)
        {
            return await redeCoberturaBll.readAsync(x => x.formularioId == id);
        }

        public List<RedeCobertura> list(int idCaso)
        {
            return redeCoberturaBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(RedeCobertura f)
        {
            if (f.id == 0)
                redeCoberturaBll.create(f);
            else
                redeCoberturaBll.update(f);
        }
    }
}
