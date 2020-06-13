using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class CanalBLL
    {
        ICanalDal canalBLL = new CanalDal();
        public Canal read(int id)
        {
            return canalBLL.read().Where(x => x.id == id).FirstOrDefault();
        }      

        public List<Canal> list()
        {
            return canalBLL.read().ToList();
        }
        public async Task<List<Canal>> listAsyncAll()
        {
            return await canalBLL.listAsyncAll();
        }
    }
}
