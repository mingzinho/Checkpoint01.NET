using Checkpoint01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Checkpoint01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        private List<Livro> ObterListaLivros()
        {
       
            return new List<Livro>
        {
            new Livro("Aprendendo C#", "José da Silva", 2020),
            new Livro("ASP.NET Core MVC", "Maria Oliveira", 2019),
            new Livro("Design Patterns", "João Santos", 2018)
        };
        }

        public IActionResult ListaLivros()
        {
            var listaLivros = ObterListaLivros();
            return View(listaLivros);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
