using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using ProyectoApi.Models.Queries;
using ProyectoApi.Models.Response;
using ProyectoApi.Repositories.interfaces;

namespace ProyectoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacDetalleController : Controller
    {
        private readonly IFacDetalleRepository _facDetalleRepository;

        public FacDetalleController(IFacDetalleRepository facDetalleRepositor)
        {
            _facDetalleRepository = facDetalleRepositor;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<FacDetalleResponse>>> SearchFacDetalle([FromQuery] FacturaDetalleQuery query)
        {
            var response = await _facDetalleRepository.SearchFacDetalle(query);
            return Ok(response);
        }

        [HttpGet("[action]/{id_factura}")]
        public async Task<ActionResult<FacDetalleOneResponse>> GetOneFacDetalle(int id_factura)
        {
            var response = await _facDetalleRepository.GetOneFacDetalle(id_factura);
            return Ok(response);
        }
    }
}
