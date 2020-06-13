using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class SubMotivoBll
    {
        ISubMotivoDal subMotivoDal = new SubMotivoDal();
        public SubMotivo read(int id)
        {
            return subMotivoDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<SubMotivo> list(int motivoId)
        {
            return subMotivoDal.read().Where(x => x.motivoId == motivoId).ToList();
        }
        public async Task<DataTable> listAsync(int motivoId)
        {
            return await subMotivoDal.listAsync(motivoId);
        }

        public void save(SubMotivo f)
        {
            if (f.id == 0)
                subMotivoDal.create(f);
            else
                subMotivoDal.update(f);
        }
    }
}
