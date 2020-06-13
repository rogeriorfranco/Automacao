using AutomacaoDal;
using AutomacaoModel;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao10BLL
    {
        IQuestao10Dal questao10Bll = new Questao10Dal();

        public async Task<Questao10> readAsync(int formularioId)
        {
            return await questao10Bll.readAsync(x => x.formularioId == formularioId);
        }

        public void save(Questao10 f)
        {
            if (f.id == 0)
                questao10Bll.create(f);
            else
                questao10Bll.update(f);
        }
    }
}
