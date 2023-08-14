using Microsoft.AspNetCore.Mvc;

namespace StudyPack.Controllers;

public class ContatoController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
