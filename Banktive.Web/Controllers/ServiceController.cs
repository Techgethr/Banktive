using Banktive.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banktive.Web.Controllers
{
    public class ServiceController : Controller
    {
        private ApplicationDbContext _db;

        public ServiceController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
