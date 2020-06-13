using AutomacaoDal;
using AutomacaoModel;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao6Bll
    {
        IQuestao6Dal questao6Dal = new Questao6Dal();
        public Questao6 read(int id)
        {
            return questao6Dal.read().Where(x => x.formularioId == id).FirstOrDefault();
        }
        public async Task<Questao6> readAsync(int id)
        {
            return await questao6Dal.readAsync(x => x.formularioId == id);
        }

        public void save(Questao6 f)
        {
            if (f.id == 0)
                questao6Dal.create(f);
            else
                questao6Dal.update(f);
        }
    }
}
