using AutomacaoDal;
using AutomacaoModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace AutomacaoBll
{
    public class AreaCausadoraBLL
    {
        IAreaCausadoraDal areaCausadoraDal = new AreaCausadoraDal();
        public AreaCausadora read(int id)
        {
            return areaCausadoraDal.read().Where(x => x.id == id).FirstOrDefault();
        }

        public List<AreaCausadora> list()
        {
            return areaCausadoraDal.read().ToList();
        }
        public async Task<DataTable> listAsync()
        {
            return await areaCausadoraDal.listAsync();
        }
        public void save(AreaCausadora f)
        {
            if (f.id == 0)
                areaCausadoraDal.create(f);
            else
                areaCausadoraDal.update(f);
        }
    }
}

