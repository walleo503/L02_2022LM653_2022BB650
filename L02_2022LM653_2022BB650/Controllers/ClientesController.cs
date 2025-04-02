using L02_2022LM653_2022BB650.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02_2022LM653_2022BB650.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly dastosDbConext _context;

        public ClientesController(dastosDbConext context)
        {
            _context = context;
        }

        // Acción para guardar los datos
        [HttpPost]
        public IActionResult IniciarVenta(clientes cliente)
        {
            if (ModelState.IsValid)
            {
                // Guardar Cliente en la BD
                _context.clientes.Add(cliente);
                _context.SaveChanges(); // Guardamos primero para obtener el ID

                //// Crear un pedido con estado "P" (Proceso)
                //var pedido = new pedidoEncabezado
                //{
                //    id_cliente = 1,  // Relacionamos con el cliente creado
                //    cantidad_libros = 0,      // Se asignará luego
                //    total = 0,                // Se asignará luego
                //    estado = "P"
                //};

                //_context.pedido_encabezado.Add(pedido);
                //_context.SaveChanges();

                // Redirigir a la vista del listado de libros
                return RedirectToAction("Index", "Libros");
            }

            return View(cliente);
        }
    }
}
