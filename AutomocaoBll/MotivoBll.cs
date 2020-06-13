using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class MotivoBll
    {
        IMotivoDal motivoDal = new MotivoDal();
        public Motivo read(int id)
        {
            return motivoDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<Motivo> list(int areaCausadoraId)
        {
            return motivoDal.read().Where(x => x.areaCausadoraId == areaCausadoraId).ToList();
        }

        public async Task<DataTable> listAsync(int areaCausadoraId)
        {
            return await motivoDal.listAsync(areaCausadoraId);
        }

        public void save(Motivo f)
        {        
            if (f.id == 0)
                motivoDal.create(f);                
            else
                motivoDal.update(f);
        }
    }
}
