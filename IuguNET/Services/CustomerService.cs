using IuguNET.Helpers;
using IuguNET.Models;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace IuguNET.Services
{
    public class CustomerService : BaseService
    {
        public CustomerService(string token) : base(token)
        {
        }

        public async Task<Customer> Create(string email, string name = "", string cpfCnpj = "", string ccEmails = "", string notes = "")
        {
            var data = new { email = email, name = name, cpf_cnpj = cpfCnpj, cc_emails = ccEmails, notes = notes };

            return await _requestService.Post<Customer>(Token, Endpoints.CustomersAddress, data);
        }

        public async Task<Customer> Search(string id)
        {
            return await _requestService.Get<Customer>(Token, Endpoints.CustomersAddress, string.Format("/{0}", id));
        }

        public async Task<Results<Customer>> List(string query = "", int limit = 100, int start = 0)
        {
            var data = new NameValueCollection();
            if (!string.IsNullOrWhiteSpace(query))
                data.Add("query", query);
            data.Add("limit", limit.ToString());
            data.Add("start", start.ToString());

            return await _requestService.Get<Results<Customer>>(Token, Endpoints.CustomersAddress, data.ToQueryString());
        }
    }
}