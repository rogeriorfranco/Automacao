using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class Questao3_4_APSBll
    {
        IQuestao3_4_APSDal questao3_4_APSDal = new Questao3_4_APSDal();
        public Questao3_4_APS read(int id)
        {
            return questao3_4_APSDal.read().Where(x => x.formularioId == id).FirstOrDefault();
        }
        public async Task<Questao3_4_APS> readAsync(int id)
        {
            return await questao3_4_APSDal.readAsync(x => x.formularioId == id);
        }

        public List<Questao3_4_APS> list()
        {
            return questao3_4_APSDal.read().ToList();
        }
        public void save(Questao3_4_APS f)
        {
            if (f.id == 0)
                questao3_4_APSDal.create(f);
            else
                questao3_4_APSDal.update(f);
        }
    }
}
