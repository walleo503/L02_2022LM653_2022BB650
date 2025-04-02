using L02_2022LM653_2022BB650.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02_2022LM653_2022BB650.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index()
        {
           
            var libros = _context.libros.Where(l => l.estado == 'A').ToList();
            return View(libros);
        }

        private readonly dastosDbConext _context;

        public LibrosController(dastosDbConext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AgregarAlCarrito(int idLibro, int idPedido)
        {
            var detalle = new pedido_detalle
            {
                id_libro = idLibro,
                id_pedido = idPedido
            };
            _context.pedido_detalle.Add(detalle);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
