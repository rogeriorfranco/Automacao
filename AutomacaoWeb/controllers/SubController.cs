using System.Web.Http;

namespace AutomacaoWeb.controllers
{
    public class SubController : ApiController
    {
        [Route("sub/{id_caso}")]
        public string Get(string id_caso)
        {
            return Util.Encrypt(id_caso);
        }
    }
}