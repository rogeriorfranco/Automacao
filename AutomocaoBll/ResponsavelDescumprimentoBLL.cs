using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class ResponsavelDescumprimentoBLL
    {
        IResponsavelDescumprimentoDal respCumprimentoBLL = new ResponsavelDescumprimentoDal();

        public ResponsavelDescumprimento read(int id)
        {
            return respCumprimentoBLL.read().Where(x => x.id == id).FirstOrDefault();
        }

        public string read(string nome)
        {
            return respCumprimentoBLL.read().Where(x => x.nome == nome).FirstOrDefault().id.ToString();
        }


        public List<ResponsavelDescumprimento> list()
        {
            return respCumprimentoBLL.read().ToList();
        }
        public async Task<List<ResponsavelDescumprimento>> listAsyncAll()
        {
            return await respCumprimentoBLL.listAsyncAll();
        }
    }
}
