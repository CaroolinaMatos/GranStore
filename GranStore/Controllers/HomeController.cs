using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GranStore.Models;

namespace GranStore.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var
        return View();
    }

    public IActionResult Privacy()
    {
        Categoria categoria = new();
        categoria.Id = 1;
        categoria.Nome = "Categoria";

        Produto produto = new();
        produto.Id = 1;
        produto.Nome = "Produto 1";

        List<Produto> produto = [
            new() {
                Id = 1,
                Nome = "Notebook 01",
                Descricao = "lalalala",
                QtdeEstoque = 5,
                ValorCusto = 2000m,
                ValorVenda = 5000m,
                categoria = categoria
            }
        ]
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
