using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EcuestaDojoValidacion.Models;

namespace EcuestaDojoValidacion.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index(){
        return View("Index");
    }

    [HttpPost("survey")]
    public IActionResult Submission(Survey survey){
        if(ModelState.IsValid){
            Survey newSurvey = survey;
            return View("Result", newSurvey);
        }
        return View("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
