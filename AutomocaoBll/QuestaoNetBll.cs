using AutomacaoDal;
using AutomacaoModel;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class QuestaoNetBll
    {
        IQuestaoNetDal questaoNetBll = new QuestaoNetDal();

        public async Task<QuestaoNet> readAsync(int formularioId)
        {
            return await questaoNetBll.readAsync(x => x.formularioId == formularioId);
        }

        public void save(QuestaoNet f)
        {
            if (f.id == 0)
                questaoNetBll.create(f);
            else
                questaoNetBll.update(f);
        }
    }
}
