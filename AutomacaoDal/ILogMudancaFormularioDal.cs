using AutomacaoModel;

namespace AutomacaoDal
{
    public interface ILogMudancaFormulariomDal : IGenericCrudDal<LogMudancaFormulario>
    {
        void save(LogMudancaFormulario l);
        string read(int idCaso);
    }
}
