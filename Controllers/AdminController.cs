using Microsoft.AspNetCore.Mvc;
using Task_Management.Data; // DbContext üçün namespace
using System.Linq;

namespace Task_Management.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
{
    var userCount = _context.Users?.Count() ?? 0; // Null yoxlaması ilə
    ViewData["UserCount"] = userCount; // Məlumatı View-ə göndər
    return View();
}

    }
}
