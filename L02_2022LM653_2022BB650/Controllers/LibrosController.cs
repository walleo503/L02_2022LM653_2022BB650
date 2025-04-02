using Microsoft.AspNetCore.Mvc;

namespace L02_2022LM653_2022BB650.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
