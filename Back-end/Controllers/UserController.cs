using Microsoft.AspNetCore.Mvc;

namespace back_end.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
