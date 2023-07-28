using Banktive.Web.Data;

namespace Banktive.Web.Models.ServiceModel
{
    public class MyServiceViewModel
    {
        public Service Service { get; set; }

        public MyServiceViewModel(ApplicationDbContext db, long id)
        {
            Service = db.Services.SingleOrDefault(x => x.Id == id);
        }
    }
}
