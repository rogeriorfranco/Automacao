using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao11BLL
    {
        IQuestao11Dal questao11Bll = new Questao11Dal();

        public async Task<Questao11> readAsync(int formularioId)
        {
            return await questao11Bll.readAsync(x => x.formularioId == formularioId);
        }

        public void save(Questao11 f)
        {
            if (f.id == 0)
                questao11Bll.create(f);
            else
                questao11Bll.update(f);
        }
    }
}
