using Microsoft.AspNetCore.Mvc;
using Practica4Web.Models;

namespace Practica4Web.Controllers
{
    public class ProductoController : Controller


    {

        ProductoModel modelo = new ProductoModel();

       
        [HttpGet]
        public IActionResult ConsultarProducto()
        {
            var datos = modelo.Consultar();
            return View(datos);
        }


        [HttpGet]
        public IActionResult RegistrarProducto()
        {
            return View();
        }
    }
}
