using Microsoft.AspNetCore.Mvc;

namespace MyAspNetCore.Web.Controllers
{
    public class OrnekController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
