using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace Todo.Controllers;

[ApiController]
[Route("[Controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        string upperMenu = "Heavy Metall, This is Todo";

        string downMenu = Models.Menu.ShowMenu();
        return Content(upperMenu, downMenu);
    }
}

