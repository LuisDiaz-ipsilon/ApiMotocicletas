using ApiFacturador.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiFacturador.Controllers
{
    public class LlantaController
    {

        [ApiController]
        [Route("api/llantas")]

        public class LlantasController: ControllerBase
        {
            [HttpGet]
            public ActionResult<List<Llanta>> Get()
            {
                return new List<Llanta>()
                {
                    new Llanta(){id=1, tipoLlanta = "Racing goma" }
                };
            }
        }
    }
}
