using AutomacaoModel;
using System.Linq;

namespace AutomacaoDal
{
    public class LogMudancaFormulariomDal : GenericCrudDal<LogMudancaFormulario>, ILogMudancaFormulariomDal
    {
        public void save(LogMudancaFormulario l)
        {
            create(l);
        }

        public string read(int idCaso)
        {
            return read().Where(x => x.id_caso == idCaso).Max(x=> x.TipoFormulario.tipo);
        }

    }
}
