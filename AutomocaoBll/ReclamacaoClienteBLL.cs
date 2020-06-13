using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{ 
    public class ReclamacaoClienteBLL
    {
        IReclamacaoClienteDal reclamacaoClienteBLL = new ReclamacaoClienteDal();

        public ReclamacaoCliente read(int id)
        {
            return reclamacaoClienteBLL.read().Where(x => x.id == id).FirstOrDefault();
        }

        //public string read(string nome)
        //{
        //    return reclamacaoClienteBLL.read().Where(x => x.nome == nome).FirstOrDefault().id.ToString();
        //}

        public List<ReclamacaoCliente> list()
        {
            return reclamacaoClienteBLL.read().ToList();
        }
        public async Task<List<ReclamacaoCliente>> listAsyncAll()
        {
            return await reclamacaoClienteBLL.listAsyncAll();
        }
    }
}
