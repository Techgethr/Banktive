using Banktive.Web.Data;

namespace Banktive.Web.Models.CreditModel
{
    public class SelectWalletViewModel
    {
        public IEnumerable<Wallet> Wallets { get; set; }
        public IEnumerable<CreditWallet> CreditWallets { get; set; }

        public SelectWalletViewModel(ApplicationDbContext db, string? name)
        {
            Wallets = db.Wallets.Where(x => x.UserId == name).OrderBy(x => x.Name);
            CreditWallets = db.CreditWallets.Where(x => x.UserId == name);
        }
    }
}
