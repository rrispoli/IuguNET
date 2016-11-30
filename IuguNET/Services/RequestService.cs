using IuguNET.Helpers;
using IuguNET.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IuguNET.Services
{
    public class RequestService
    {
        public async Task<T> Get<T>(string apiToken, string path, string parameters = "")
        {
            using (var httpClient = new HttpClient())
            {
                Config(httpClient, apiToken);
                var response = await httpClient.GetStringAsync(string.Format("{0}{1}", path, parameters));
                return JsonConvert.DeserializeObject<T>(response);
            }
        }

        public async Task<T> Post<T>(string apiToken, string path, object data)
        {
            using (var httpClient = new HttpClient())
            {
                Config(httpClient, apiToken);
                var content = RequestHelper.ToDataString(data);
                var responseMessage = await httpClient.PostAsync(path, content);
                var response = await responseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(response);
            }
        }

        private void Config(HttpClient httpClient, string apiToken)
        {
            if (!string.IsNullOrWhiteSpace(apiToken))
            {
                var credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(apiToken + ":"));
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", credentials);
            }

            httpClient.BaseAddress = new Uri(Endpoints.BaseAddress);
        }
    }
}