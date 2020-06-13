using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class EstadoBLL
    {
        IEstadoDal estadoBLL = new EstadoDal();

        public Estado read(int id)
        {
            return estadoBLL.read().Where(x => x.id == id).FirstOrDefault();
        }

        public string read(string estado)
        {
            return estadoBLL.read().Where(x => x.uf == estado).FirstOrDefault().id.ToString();
        }

        public List<Estado> list()
        {
            return estadoBLL.read().ToList();
        }
        public async  Task<List<Estado>> listAsyncAll()
        {
            return await estadoBLL.listAsyncAll();
        }
    }
}
