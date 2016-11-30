using IuguNET.Models;
using System.Threading.Tasks;

namespace IuguNET.Services
{
    public class PaymentTokenService : BaseService
    {
        public PaymentTokenService(string token) : base(token)
        {
        }

        public async Task<PaymentToken> Generate(bool test, string accountId, string cardNumber, string cardSecurityCode, string cardFirstName, string cardLastName, string cardExpirationMonth, string cardExpirationYear)
        {
            var data = new { account_id = accountId, method = Constants.PaymentMethod.CREDIT_CARD, test = test, data = new { number = cardNumber, verification_value = cardSecurityCode, first_name = cardFirstName, last_name = cardLastName, month = cardExpirationMonth, year = cardExpirationYear } };
            return await _requestService.Post<PaymentToken>(Token, Endpoints.PaymentTokenAddress, data);
        }
    }
}