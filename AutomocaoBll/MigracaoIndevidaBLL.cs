using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class MigracaoIndevidaBLL
    {
        IMigracaoIndevida migrIndevidaBll = new MigracaoIndevidaDal();
        public async Task<MigracaoIndevida> read(int id)
        {
            return await migrIndevidaBll.readAsync(x => x.formularioId == id);
        }
        public List<MigracaoIndevida> list(int idCaso)
        {
            return migrIndevidaBll.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(MigracaoIndevida f)
        {
            if (f.id == 0)
                migrIndevidaBll.create(f);
            else
                migrIndevidaBll.update(f);
        }
    }
}
