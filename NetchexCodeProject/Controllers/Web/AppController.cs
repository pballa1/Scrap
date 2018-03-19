using Microsoft.AspNetCore.Mvc;

namespace NetchexCodeProject.Controllers.Web
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
