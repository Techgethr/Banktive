using Banktive.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banktive.Web.Controllers
{
    public class DestinationController : Controller
    {
        private ApplicationDbContext _db;

        public DestinationController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
