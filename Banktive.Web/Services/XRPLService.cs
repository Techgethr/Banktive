using Banktive.Web.Services.Model;
using Xrpl.Client;
using Xrpl.Client.Model;
using Xrpl.Client.Model.Account;
using Xrpl.Client.Requests.Account;
using Xrpl.Wallet;

namespace Banktive.Web.Services
{
    public class XRPLService
    {
        private IConfiguration _configuration { get; set; }
        private RippleClient _rippleClient { get; set; }
        public XRPLService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private void Connect(string url)
        {
            _rippleClient = new RippleClient(url);
            _rippleClient.Connect();
        }

        private void Disconnect()
        {
            try
            {
                _rippleClient.Disconnect();
            }
            catch
            {

            }
        }

        public async Task<NativeBalance> GetNativeBalance(string url, string address)
        {
            NativeBalance nativeBalance = null;
            try
            {
                Connect(url);
                AccountInfoRequest request = new AccountInfoRequest(address);
                AccountInfo accountInfo = await _rippleClient.AccountInfo(request);
                Currency balance = accountInfo.AccountData.Balance;
                nativeBalance = new NativeBalance
                {
                    CurrencyCode = balance.CurrencyCode,
                    Issuer = balance.Issuer,
                    Value = balance.Value,
                    ValueAsNumber = balance.ValueAsNumber,
                    ValueAsXrp = balance.ValueAsXrp
                };
            }
            catch
            {

            }
            Disconnect();
            return nativeBalance;
        }
    }
}
