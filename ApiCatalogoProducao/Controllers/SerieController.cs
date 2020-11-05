using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogoProducao.Controllers
{
    [Route("api/series")]
    [ApiController]
    public class SerieController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult BuscaSeries()
        {
            return Ok();
        }
    }
}