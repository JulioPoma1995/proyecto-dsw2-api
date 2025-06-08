using ProyectoApi.Models.Queries;
using ProyectoApi.Models.Response;

namespace ProyectoApi.Repositories.interfaces
{
    public interface IFacDetalleRepository
    {
        Task<FacDetalleOneResponse> GetOneFacDetalle(int id_factura);
        Task<IEnumerable<FacDetalleResponse>> SearchFacDetalle(FacturaDetalleQuery query);


    }
}
