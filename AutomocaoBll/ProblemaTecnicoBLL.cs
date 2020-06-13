using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class ProblemaTecnicoBLL
    {
        IProblemaTecnico probTecnicoBll = new ProblemaTecnicoDal();
        public async  Task<ProblemaTecnico> read(int id)
        {
            return await probTecnicoBll.readAsync(x => x.formularioId == id);
        }

        public List<ProblemaTecnico> list(int idCaso)
        {
            return probTecnicoBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(ProblemaTecnico f)
        {
            if (f.id == 0)
                probTecnicoBll.create(f);
            else
                probTecnicoBll.update(f);
        }
    }
}
