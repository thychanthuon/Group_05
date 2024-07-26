using Microsoft.AspNetCore.Mvc;

namespace AGA_Project_05.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
