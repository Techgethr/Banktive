using Banktive.Web.Data;
using Microsoft.AspNetCore.Mvc;

namespace Banktive.Web.Controllers
{
    public class PaymentController : Controller
    {
        private ApplicationDbContext _db;

        public PaymentController(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
