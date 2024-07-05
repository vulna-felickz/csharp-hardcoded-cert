using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csharp_hardcoded_cert.Models;

namespace csharp_hardcoded_cert.Controllers;




public class CertEntity
{
    public string CertType { get; set; }

    public CertEntity()
    {
        CertType = "CODE1";
    }
}

public class HomeController : Controller
{

    public bool social = false;

    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var cert = new CertEntity(){
            CertType = social ? "CODE1" : "CODE2"
        };

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
