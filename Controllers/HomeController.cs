using Microsoft.AspNetCore.Mvc;
using SolbegTestTask.Services;

namespace SolbegTestTask.Controllers;
public class HomeController : Controller
{
    private readonly IReverseStringService _reverseStringService;

    public HomeController(IReverseStringService reverseStringService)
    {
        _reverseStringService = reverseStringService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(string str)
    {
        if (str == null)
            return View();

        string result = _reverseStringService.Reverse(str);
        return View((object) result);
    }
}
