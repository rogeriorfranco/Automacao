using AutomacaoDal;
using AutomacaoModel;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao14BLL
    {
        IQuestao14Dal questao14Bll = new Questao14Dal();

        public async Task<Questao14> readAsync(int formularioId)
        {
            return await questao14Bll.readAsync(x => x.formularioId == formularioId);
        }

        public void save(Questao14 f)
        {
            if (f.id == 0)
                questao14Bll.create(f);
            else
                questao14Bll.update(f);
        }
    }
}
