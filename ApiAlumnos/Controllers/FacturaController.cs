using ApiFacturador.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiFacturador.Controllers
{
    [ApiController]
    [Route("api/facturas")]
    public class FacturaController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Factura>> Get()
        {
            return new List<Factura>()
            {
                new Factura() { Id = 1, NombreCliente = "Luis Oliva"},
                new Factura() { Id = 1, NombreCliente = "Samantha Oliva"},
            };
        }
    }
}
