using Microsoft.AspNetCore.Mvc;

namespace AutomatedQueryProcess.Controllers
{
    public class QueryProcessController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
