using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
