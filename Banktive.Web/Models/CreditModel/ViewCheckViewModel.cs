using Banktive.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace Banktive.Web.Models.CreditModel
{
    public class ViewCheckViewModel
    {
        public Check Check { get; set; }

        public ViewCheckViewModel(ApplicationDbContext db, Guid id)
        {
            Check = db.Checks.Include(x => x.Currency).Include(x => x.Destination)
                .Include(x => x.CheckStatus).SingleOrDefault(x => x.Id == id);
        }
    }
}
