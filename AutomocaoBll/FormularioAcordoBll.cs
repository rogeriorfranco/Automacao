using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class FormularioAcordoBll
    {
        IFormularioAcordoDal formularioAcordoBLL = new FormularioAcordoDal();

        public FormularioAcordo read(int id)
        {
            return formularioAcordoBLL.read().Where(x => x.formularioId == id).FirstOrDefault();
        }
        public async Task<FormularioAcordo> readAsync(int id)
        {
            return await formularioAcordoBLL.readAsync(x => x.formularioId == id);
        }

        public List<FormularioAcordo> list(int idCaso)
        {
            return formularioAcordoBLL.read().Where(x => x.formularioId == idCaso).ToList();
        }
        public void save(FormularioAcordo f)
        {
            if (f.id == 0)
                formularioAcordoBLL.create(f);
            else
                formularioAcordoBLL.update(f);
        }
    }
}
