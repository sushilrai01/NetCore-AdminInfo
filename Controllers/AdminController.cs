using Microsoft.AspNetCore.Mvc;
using NetCoreAdminInfo.Entity;

namespace NetCoreAdminInfo.Controllers
{
    public class AdminController : Controller
    {
        private readonly DriverManagementContext db;
        public AdminController(DriverManagementContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
