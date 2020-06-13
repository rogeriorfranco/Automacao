using AutomacaoDal;
using AutomacaoModel;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao7Bll
    {
        IQuestao7Dal questao7Dal = new Questao7Dal();
        public Questao7 read(int id)
        {
            return questao7Dal.read().Where(x => x.formularioId == id).FirstOrDefault();
        }
        public async Task<Questao7> readAsync(int id)
        {
            return await questao7Dal.readAsync(x => x.formularioId == id);
        }

        public string readPendente(int id)
        {
            return questao7Dal.readPendente(id);
        }

        //public List<Cancelamento> list(int idCaso)
        //{
        //    return cancelamentoDal.read().Where(x => x.tipoSubsidioId == idCaso).ToList();
        //}
        public void save(Questao7 f)
        {
            if (f.id == 0)
                questao7Dal.create(f);
            else
                questao7Dal.update(f);
        }
    }
}
