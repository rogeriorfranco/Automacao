using AutomacaoDal;
using AutomacaoModel;
using System.Linq;

namespace AutomacaoBll
{
    public class Questao4BLL
    {
        IQuestao4Dal questao4Dal = new Questao4Dal();
        public Questao4 read(int id)
        {
            return questao4Dal.read().Where(x => x.formularioId == id).FirstOrDefault();
        }

        public void save(Questao4 f)
        {
            if (f.id == 0)
                questao4Dal.create(f);
            else
                questao4Dal.update(f);
        }
    }
}
