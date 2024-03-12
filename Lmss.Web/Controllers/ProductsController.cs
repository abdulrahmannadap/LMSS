using Microsoft.AspNetCore.Mvc;

namespace Lmss.Web.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
