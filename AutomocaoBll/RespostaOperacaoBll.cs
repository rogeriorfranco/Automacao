using AutomacaoDal;
using AutomacaoModel;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class RespostaOperacaoBll
    {
        IRespostaOperacaoDal RespostaBll = new RespostaOperacaoDal();

        public async Task<RespostaOperacao> readAsync(int formularioId)
        {
            return await RespostaBll.readAsync(x => x.formularioId == formularioId);
        }

        public void save(RespostaOperacao f)
        {
            if (f.id == 0)
                RespostaBll.create(f);
            else
                RespostaBll.update(f);
        }
    }
}
