using AutomacaoDal;
using AutomacaoModel;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao12BLL
    {
        IQuestao12Dal questao12Bll = new Questao12Dal();

        public async Task<Questao12> readAsync(int formularioId)
        {
            return await questao12Bll.readAsync(x => x.formularioId == formularioId);
        }

        public void save(Questao12 f)
        {
            if (f.id == 0)
                questao12Bll.create(f);
            else
                questao12Bll.update(f);
        }
    }
}
