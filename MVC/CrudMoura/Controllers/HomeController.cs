using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    // ação padrão inicial
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        //retorne a pafina MinhAcao.cshtml
        return View();
    }

    public IActionResult ListaNomes()
    {
        //cria um array 
        string[] nomes = {"Eduardo", "Maria", "João", "Davi", "Kauã"};
        
        ViewBag.Teste = "Olá, eu vim atráves da viewbag";
        ViewBag.nomes = nomes;

        return View();
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
