using Banktive.Web.Data;

namespace Banktive.Web.Models.ServiceModel
{
    public class ServiceAccountInfoViewModel
    {
        public ServiceAccount ServiceAccount { get; set; }
        public IEnumerable<ServiceAccountDetail> ServiceAccountDetails { get; set; }
        public ServiceAccountInfoFormModel Form { get; set; }

        public ServiceAccountInfoViewModel(ApplicationDbContext db, long id)
        {
            Form = new ServiceAccountInfoFormModel { ServiceAccountId = id };
            ServiceAccount = db.ServiceAccounts.SingleOrDefault(x => x.Id == id);
            ServiceAccountDetails = db.ServiceAccountDetails.Where(x => x.ServiceAccountId == id).OrderByDescending(x => x.DueDate);
        }
    }
}
