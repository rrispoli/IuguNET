using IuguNET.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IuguNET.Services
{
    public class ChargeService : BaseService
    {
        public ChargeService(string token) : base(token)
        {
        }

        public async Task<Charge> Direct(string paymentToken, string customerId, List<Item> items, int numberOfParcels = 1)
        {
            var dataItems = items.Select(x => new { description = x.Description, quantity = x.Quantity, price_cents = x.PriceCents });
            var data = new { token = paymentToken, customer_id = customerId, months = numberOfParcels, items = dataItems };

            return await _requestService.Post<Charge>(Token, Endpoints.ChargeAddress, data);
        }
    }
}