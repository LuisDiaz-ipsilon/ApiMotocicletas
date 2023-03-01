using ApiFacturador.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiFacturador.Controllers
{
    public class MotocicletaController
    {
        [ApiController]
        [Route("api/motocicletas")]
        public class MotocicletasController: ControllerBase
        {
            [HttpGet]
            public ActionResult<List<Motocicleta>> get()
            {
                return new List<Motocicleta>()
                {
                    new Motocicleta() {id = 1, modelo = "Indian", piel = true}
                };
            }
        }
    }
}
