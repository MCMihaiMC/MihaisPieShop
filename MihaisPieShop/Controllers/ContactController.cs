using Microsoft.AspNetCore.Mvc;

namespace MihaisPieShop.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
