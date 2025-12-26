using Microsoft.AspNetCore.Mvc;

namespace SpaWellnessAppointmentManagementSystem.web.Controllers
{
    public class BookingController: Controller
    {
        public IActionResult Booking() => View();
    }
}
