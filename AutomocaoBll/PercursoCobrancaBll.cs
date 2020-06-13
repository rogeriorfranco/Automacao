using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class PercursoCobrancaBll
    {
        IPercursoCobrancaDal percursoCobrancaDal = new PercursoCobrancaDal();
        public PercursoCobranca read(int id)
        {
            return percursoCobrancaDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<PercursoCobranca> list()
        {
            return percursoCobrancaDal.read().ToList();
        }
        public async Task<List<PercursoCobranca>> listAsyncAll()
        {
            return await percursoCobrancaDal.listAsyncAll();
        }
        public void save(PercursoCobranca f)
        {
            percursoCobrancaDal.update(f);
        }
    }
}
