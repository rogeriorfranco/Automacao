using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class ParceiroOfensorBll
    {
        IParceiroOfensorDal parceiroOfensorDal = new ParceiroOfensorDal();
        public ParceiroOfensor read(int id)
        {
            return parceiroOfensorDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<ParceiroOfensor> list()
        {
            return parceiroOfensorDal.read().ToList();
        }
        public async Task<List<ParceiroOfensor>> listAsyncAll()
        {
            return await parceiroOfensorDal.listAsyncAll();
        }
        public void save(ParceiroOfensor f)
        {
            if (f.id == 0)
                parceiroOfensorDal.create(f);
            else
                parceiroOfensorDal.update(f);
        }
    }
}
