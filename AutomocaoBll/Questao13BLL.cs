using AutomacaoDal;
using AutomacaoModel;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao13BLL
    {
        IQuestao13Dal questao13Bll = new Questao13Dal();

        public async Task<Questao13> readAsync(int formularioId)
        {
            return await questao13Bll.readAsync(x => x.formularioId == formularioId);
        }

        public void save(Questao13 f)
        {
            if (f.id == 0)
                questao13Bll.create(f);
            else
                questao13Bll.update(f);
        }
    }
}
