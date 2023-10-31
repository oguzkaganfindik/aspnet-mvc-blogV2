using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index(int id, int page)
        {
            return View();
        }
    }
}
