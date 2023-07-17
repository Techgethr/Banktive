using Banktive.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banktive.Web.Controllers
{
    public class SettingController : Controller
    {
        private ApplicationDbContext _db;

        public SettingController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
