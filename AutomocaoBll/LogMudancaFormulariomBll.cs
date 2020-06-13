using AutomacaoDal;
using AutomacaoModel;
using System.Linq;

namespace AutomacaoBll
{
    public class LogMudancaFormulariomBll
    {
        ILogMudancaFormulariomDal logMudancaFormulariomBll = new LogMudancaFormulariomDal();      
        public void save(LogMudancaFormulario l)
        {
            logMudancaFormulariomBll.save(l);
        }

        public string readTipo(int idCaso)
        {
            return logMudancaFormulariomBll.read(idCaso);
        }
    }
}
