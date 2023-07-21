using Banktive.Web.Data;
using Banktive.Web.Models.TransferModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Banktive.Web.Controllers
{
    [Authorize]
    public class TransferController : Controller
    {
        private ApplicationDbContext _db;

        public TransferController(ApplicationDbContext db)
        {
            _db = db;
        }



        public IActionResult Detail(Guid id)
        {
            DetailTransferViewModel model = new DetailTransferViewModel(_db, id);
            return View(model);
        }
    }
}
