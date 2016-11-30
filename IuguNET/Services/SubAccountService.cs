using IuguNET.Helpers;
using IuguNET.Models;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace IuguNET.Services
{
    public class SubAccountService : BaseService
    {
        public SubAccountService(string token) : base(token)
        {
        }

        public async Task<SubAccount> Create(string name, int comissionPercent)
        {
            var data = new { name = name, comission_percent = comissionPercent };
            return await _requestService.Post<SubAccount>(Token, string.Format("{0}/{1}", Endpoints.MarketplaceAddress, Endpoints.CreateAccountSubAddress), data);
        }

        public async Task<SubAccountVerification> RequestVerification(string subAccountUserApiToken, string subAccountId, SubAccountData subAccountData, bool automaticValidation)
        {
            var data = new { data = subAccountData, automatic_validation = automaticValidation };
            return await _requestService.Post<SubAccountVerification>(subAccountUserApiToken, string.Format("{0}/{1}/{2}", Endpoints.AccountsAddress, subAccountId, Endpoints.RequestAccountVerificationSubAddress), data);
        }

        public async Task<Results<SubAccount>> List(string query = "", int limit = 100, int start = 0)
        {
            var data = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(query))
                data.Add("query", query);
            data.Add("limit", limit.ToString());
            data.Add("start", start.ToString());

            return await _requestService.Get<Results<SubAccount>>(Token, Endpoints.MarketplaceAddress, data.ToQueryString());
        }
    }
}