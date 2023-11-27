using Microsoft.AspNetCore.Mvc;

namespace TaskManagerPlus.Web.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
