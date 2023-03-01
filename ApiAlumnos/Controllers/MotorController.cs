using ApiFacturador.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiFacturador.Controllers
{
    public class MotorController
    {
        [ApiController]
        [Route("api/motores")]
        public class MotoresController: ControllerBase
        {
            [HttpGet]
            public ActionResult<List<Motor>> Get()
            {
                return new List<Motor>() 
                {
                    new Motor(){id = 1, tamaño = "600", demon = true, ethanol = true, nitro = true, supercharger = true, turbo = true}
                };
            }
        }
    }
}
