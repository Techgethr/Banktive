using Banktive.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banktive.Web.Controllers
{
    public class WalletController : Controller
    {
        private ApplicationDbContext _db;

        public WalletController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
