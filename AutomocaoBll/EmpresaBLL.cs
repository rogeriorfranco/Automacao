using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class EmpresaBLL
    {
        IEmpresaDal empresaDal = new EmpresaDal();

        public Empresa read(int id)
        {
            return empresaDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public int read(string nome)
        {
            return empresaDal.read().Where(x => x.nome == nome).FirstOrDefault().id;
        }

        public async Task<List<Empresa>> listAsyncAll()
        {
            return await empresaDal.listAsyncAll();
        }
    }
}
