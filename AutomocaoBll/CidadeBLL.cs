using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class CidadeBLL
    {
        ICidadeDal cidadeBll = new CidadeDal();
        public Cidade read(int? id)
        {
            return cidadeBll.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<Cidade> listID(int id)
        {
            return cidadeBll.read().Where(x => x.estadoId == id).ToList();
        }

        public async Task<List<Cidade>> listAsync(int id)
        {
            return await cidadeBll.listAsync(x => x.estadoId == id);
        }

        public List<Cidade> list()
        {
            return cidadeBll.read().ToList();
        }
    }
}
