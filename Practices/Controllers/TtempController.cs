using Microsoft.AspNetCore.Mvc;

namespace Practices.Controllers
{
    public class TtempController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
