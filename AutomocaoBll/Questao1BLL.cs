using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao1BLL
    {
        IQuestao1Dal questao1BLL = new Questao1Dal();

        public Questao1 read(int formularioId)
        {
            return questao1BLL.read().Where(x => x.formularioId == formularioId).FirstOrDefault();
        }
        public async Task<Questao1> readAsync(int formularioId)
        {
            return await questao1BLL.readAsync(x => x.formularioId == formularioId);
        }
        public List<Questao1> list(int idCaso)
        {
            return questao1BLL.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(Questao1 f)
        {
            if (f.id == 0)
                questao1BLL.create(f);
            else
                questao1BLL.update(f);
        }
    }
}
