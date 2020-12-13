using ApiCatalogoProducao.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCatalogoProducao.Controllers
{
    [Route("api/filmes")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private readonly IFilmeService filmeService;
        public FilmeController(IFilmeService filmeService)
        {
            this.filmeService = filmeService;
        }

        [HttpGet]
        [Route("")]
        public ActionResult BuscarFilmes()
        {
            filmeService.ListarFilmes();
            return Ok();
        }

        [HttpPost]
        [Route("")]
        public ActionResult CriarFilme()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("")]
        public ActionResult DeletarFilme()
        {
            return Ok();
        }

        [HttpPatch]
        [Route("")]
        public ActionResult PublicarFilme()
        {
            return Ok();
        }
    }
}