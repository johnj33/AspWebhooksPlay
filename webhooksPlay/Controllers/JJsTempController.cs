using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace webhooksPlay.Controllers
{
    public class JJsTempController : ApiController
    {
        [System.Web.Http.Route("firehook")]
        public async Task<OkResult> FireHook(string someContent)
        {
            await this.NotifyAsync("event1", new { P1 = someContent });
            return Ok();
        }
    }
}