using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class MotivoContestacaoBll
    {
        IMotivoContestacaoDal motivoContestacaoDal = new MotivoContestacaoDal();
        public MotivoContestacao read(int id)
        {
            return motivoContestacaoDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<MotivoContestacao> list()
        {
            return motivoContestacaoDal.read().ToList();
        }
        public async Task<List<MotivoContestacao>> listAsyncAll()
        {
            return await motivoContestacaoDal.listAsyncAll();
        }

        public void save(MotivoContestacao f)
        {
            if (f.id == 0)
                motivoContestacaoDal.create(f);
            else
                motivoContestacaoDal.update(f);
        }
    }
}
