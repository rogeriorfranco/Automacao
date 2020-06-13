using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class ServicoAdicionalBll
    {
        IServicoAdicionalDal servicoAdicionalDal = new ServicoAdicionalDal();
        public async Task<ServicoAdicional> read(int id)
        {
            return await servicoAdicionalDal.readAsync(x => x.formularioId == id);
        }
        public List<ServicoAdicional> list(int idCaso)
        {
            return servicoAdicionalDal.read().Where(x => x.formularioId == idCaso).ToList();
        }

        public void save(ServicoAdicional f)
        {
            if (f.id == 0)
                servicoAdicionalDal.create(f);
            else
                servicoAdicionalDal.update(f);
        }
    }
}
