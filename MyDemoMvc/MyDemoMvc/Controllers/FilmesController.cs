using Microsoft.AspNetCore.Mvc;
using MyDemoMvc.Models;

namespace MyDemoMvc.Controllers
{
    public class FilmesController : Controller
    {
        [HttpGet]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Adicionar(Filme filme)
        {
            if (ModelState.IsValid)
            {
                //
            }

            return View(filme);
        }
    }
}
