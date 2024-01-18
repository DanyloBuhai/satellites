using Microsoft.AspNetCore.Mvc;

namespace satellites.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Title = "Головна";
            return View();
        }
    }
}
