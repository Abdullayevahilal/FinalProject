using Admin.Filter;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers

{
    //[TypeFilter(typeof(Auth))]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}