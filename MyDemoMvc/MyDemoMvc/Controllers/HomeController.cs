using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyDemoMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyDemoMvc.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
      
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(string id, Guid categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            //return Json("{'nome':'Michael'}");
            //var fileBytes = System.IO.File.ReadAllBytes(@"c:\arquivo.txt");
            //var fileName = "ola.txt";
            //return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            return Content("Qualquer coisa");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
