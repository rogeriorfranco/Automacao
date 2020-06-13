using AutomacaoModel;

namespace AutomacaoDal
{
    public interface IQuestao7Dal : IGenericCrudDal<Questao7>
    {
      string readPendente(int id);
    }
}
