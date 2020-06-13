using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class SubContratoBll
    {
        ISubContratoDal contratoFilhoBll = new SubContratoDal();

        public async Task<SubContrato> readAsync(int formularioId , string sub_contrato)
        {
            return await contratoFilhoBll.readAsync(x => x.formularioId == formularioId && x.sub_contrato == sub_contrato);
        }

        //public List<SubContrato> listSub(int formularioId)
        //{
        //    return  contratoFilhoBll.read().Where(x => x.formularioId == formularioId).ToList();
        //}

        public void save(SubContrato f)
        {
            if (f.id == 0)
                contratoFilhoBll.create(f);
            else
                contratoFilhoBll.update(f);
        }
    }
}
