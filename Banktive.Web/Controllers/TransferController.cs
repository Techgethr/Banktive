using Banktive.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banktive.Web.Controllers
{
    public class TransferController : Controller
    {
        private ApplicationDbContext _db;

        public TransferController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
