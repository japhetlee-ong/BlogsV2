using Microsoft.AspNetCore.Mvc;

namespace BlogsV2.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
