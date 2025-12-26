using Microsoft.AspNetCore.Mvc;

namespace SerenitySpa.Controllers
{
    public class DashboardController : Controller
    {
        // Removed [Authorize] to prevent crashing while you test the UI
        public IActionResult Admin() => View();

        public IActionResult Staff() => View();

        public IActionResult Customer() => View();

        public IActionResult AdminDashboard() => View();

        
    }
}