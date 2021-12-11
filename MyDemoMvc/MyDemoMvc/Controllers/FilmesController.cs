using Microsoft.AspNetCore.Mvc;

namespace MyDemoMvc.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }
    }
}
