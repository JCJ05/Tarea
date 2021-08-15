using Microsoft.AspNetCore.Mvc;
using Laboratorio.Models;

namespace Laboratorio.Controllers
{
    public class ProductoController:Controller
    {
        
        public IActionResult Index () {
            

             return View();   
         

        } 

        [HttpPost]
        public IActionResult Calcular (Producto producto) {
              double total;
            

              total = (producto.precio * producto.cantidad) * 1.18;
              ViewData["Pago"] = "El precio total del producto " +producto.nombre + " a pagar es: " + total;

              return View("Index");

        }


      


    }
}