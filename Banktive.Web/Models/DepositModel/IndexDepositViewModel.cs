using Banktive.Web.Data;

namespace Banktive.Web.Models.DepositModel
{
    public class IndexDepositViewModel
    {
        public IEnumerable<DepositDTO> Deposits { get; set; }
        public IndexDepositFormModel Form { get; set; }

        public IndexDepositViewModel(ApplicationDbContext db, string? userName)
        {
            Form = new IndexDepositFormModel();
        }
    }
}
