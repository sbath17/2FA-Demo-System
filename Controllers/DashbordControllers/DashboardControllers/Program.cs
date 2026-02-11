using System;

namespace TwoFactorDemo.Controllers
{
    public class DashboardController : Controller
    {
        private const string V = "IsAuthenticated";

        public object TempData { get; private set; }

        public IActionResult Index()
        {
            if (TempData[V] != null)
                return View();
            return RedirectToAction("Login", "Account");
        }

        private IActionResult RedirectToAction(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}