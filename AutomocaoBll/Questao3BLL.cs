using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao3BLL
    {
        IQuestao3Dal questao3BLL = new Questao3Dal();

        public Questao3 read(int id)
        {
            return questao3BLL.read().Where(x => x.formularioId == id).FirstOrDefault();
        }

        public async Task<Questao3> readAsync(int id)
        {
            return await questao3BLL.readAsync(x => x.formularioId == id);
        }

        public Questao3 read(Questao3 questao)
        {
            return questao3BLL.read().Where(x => x.formularioId == questao.formularioId
            && x.detalheExecCumprimento == questao.detalheExecCumprimento
            && x.respDescumprimento == questao.respDescumprimento
            && x.pendenteCom == questao.pendenteCom).FirstOrDefault();
        }

        public string readPendente(int id)
        {
            return questao3BLL.read().Where(x => x.formularioId == id).Select(x => x.pendenteComValue).First();
        }

        public List<Questao3> list(int idCaso)
        {
            return questao3BLL.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(Questao3 f)
        {
            if (f.id == 0)
                questao3BLL.create(f);
            else
                questao3BLL.update(f);
        }
    }
}
