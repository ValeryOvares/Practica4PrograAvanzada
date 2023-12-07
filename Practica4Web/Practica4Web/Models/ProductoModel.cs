using Practica4Api.Entities;
using Practica4Web.Entities;

namespace Practica4Web.Models
{
    public class ProductoModel : IProductoModel
    {

        public List<ProductoEnt> Consultar()
        {
            using (var http = new HttpClient())
            {
                var url = "https://localhost:7103/api/Producto/ConsultarProductos";
                var resp = http.GetAsync(url).Result;

                if (resp.IsSuccessStatusCode)
                    return resp.Content.ReadFromJsonAsync<List<ProductoEnt>>().Result;
                else
                    return new List<ProductoEnt>();
            }
        }


    }
}
