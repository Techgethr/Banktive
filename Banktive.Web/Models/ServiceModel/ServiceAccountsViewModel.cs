using Banktive.Web.Data;

namespace Banktive.Web.Models.ServiceModel
{
    public class ServiceAccountsViewModel
    {
        public Service Service { get; set; }
        public ServiceAccountsFormModel Form { get; set; }

        public ServiceAccountsViewModel(ApplicationDbContext db, long id)
        {
            Service = db.Services.SingleOrDefault(x => x.Id == id);
            Form = new ServiceAccountsFormModel { Id = id };
        }
    }
}
