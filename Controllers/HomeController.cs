using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Vue3.Models;

namespace Vue3.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Data()
    {
        // TODO: Your code here
        return View();
    }

    public IActionResult ClassVue()
    {
        // TODO: Your code here
        return View();
    }

    public IActionResult IfView()
    {
        // TODO: Your code here
        return View();
    }

    public IActionResult Lists()
    {
        // TODO: Your code here
        return View();
    }

    public IActionResult Events()
    {
        // TODO: Your code here
        return View();
    }

    public IActionResult Forms()
    {
        // TODO: Your code here
        return View();
    }

    public IActionResult Comp()
    {
        // TODO: Your code here
        return View();
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
