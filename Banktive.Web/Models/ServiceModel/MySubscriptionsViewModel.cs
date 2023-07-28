using Banktive.Web.Data;

namespace Banktive.Web.Models.ServiceModel
{
    public class MySubscriptionsViewModel
    {
        private ApplicationDbContext db;
        private string? name;

        public MySubscriptionsViewModel(ApplicationDbContext db, string? name)
        {
            this.db = db;
            this.name = name;
        }
    }
}
