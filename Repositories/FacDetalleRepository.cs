using Dapper;
using ProyectoApi.Helpers;
using ProyectoApi.Models.Queries;
using ProyectoApi.Models.Response;
using ProyectoApi.Repositories.interfaces;
using System.Data;

namespace ProyectoApi.Repositories
{
    public class FacDetalleRepository : IFacDetalleRepository
    {
        private readonly IDatabaseExecutor _executor;

        public FacDetalleRepository(IDatabaseExecutor executor)
        {
            _executor = executor;
        }

        public async Task<FacDetalleOneResponse> GetOneFacDetalle(int id_factura)
        {
            var sp = "USP_GET_ONE_FACTURA_DETALLE";

            var parameters = new DynamicParameters();
            parameters.Add("FacturaID", id_factura, DbType.Int32, ParameterDirection.Input);

            var result = await _executor.ExecuteCommand(conexion => conexion.QuerySingleAsync<FacDetalleOneResponse>(sp, parameters));

            return result;
        }

        public async Task<IEnumerable<FacDetalleResponse>> SearchFacDetalle(FacturaDetalleQuery query)
        {
            var sp = "USP_SEARCH_FACTURA_DETALLE";
            var parameters = new DynamicParameters();
            parameters.Add("Estado", query.Estado, DbType.Boolean, ParameterDirection.Input);

            var listado = await _executor.ExecuteCommand(conexion => conexion.QueryAsync<FacDetalleResponse>(sp, parameters));

            return listado;
        }
    }
}
