using AutomacaoDal;
using AutomacaoModel;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao5Bll
    {
        IQuestao5Dal questao5Dal = new Questao5Dal();
        public Questao5 read(int id)
        {
            return questao5Dal.read().Where(x => x.formularioId == id).FirstOrDefault();
        }

        public async Task<Questao5> readAsync(int id)
        {
            return await questao5Dal.readAsync(x => x.formularioId == id);
        }

        public async Task<Questao5> readCheckAcordo(long id_caso)
        {
            return await questao5Dal.readAsync(x => x.Formulario.id_caso == id_caso && x.Formulario.tipoFormularioId == 2);
        }

        public void save(Questao5 f)
        {
            if (f.id == 0)
                questao5Dal.create(f);
            else
                questao5Dal.update(f);
        }
    }
}
