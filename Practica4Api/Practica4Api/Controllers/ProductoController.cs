using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practica4Api.Entities;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Practica4Api.Controllers
{
    

    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {

        private readonly string _connection;

        public ProductoController(IConfiguration configuration)
        {
            _connection = configuration.GetConnectionString("DefaultConnection");
        }

        [HttpGet("ConsultarProductos")]
        public IActionResult ConsultarProductos()
        {
            try
            {
                using (var connection = new SqlConnection(_connection))
                {
                    connection.Open();

                    var datos = connection.Query<PrincipalEnt>(
                        "ConsultarProductos",
                        commandType: CommandType.StoredProcedure
                    ).ToList();

                    return Ok(datos);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
