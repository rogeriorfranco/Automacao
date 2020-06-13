using AutomacaoDal;
using System.Collections.Generic;

namespace AutomacaoBll
{
    public class StatusReaberturaBll
    {
        IStatusReaberturaDal statusReaberturaDal = new StatusReaberturaDal();

        public List<string> listAll()
        {
            return statusReaberturaDal.listAll();
        }
    }
}
