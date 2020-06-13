using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class ProdutoBLL
    {
        IProdutoDal produtoBLL = new ProdutoDal();

        public Produto read(int id)
        {
            return produtoBLL.read().Where(x => x.id == id).FirstOrDefault();
        }

        public Produto read(string produto)
        {
            return produtoBLL.read().Where(x => x.nome == produto).FirstOrDefault();
        }

        public List<Produto> list()
        {
            return produtoBLL.read().ToList();
        }
        public List<Produto> listID(int id)
        {
            return produtoBLL.read().Where(x => x.empresaId == id).ToList();
        }
        public async Task<List<Produto>> listAsync(int id)
        {
           return await produtoBLL.listAsync(x => x.empresaId == id);
 
        }
    }
}
