using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class PaymentToken : Base
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("method")]
        public string Method { get; set; }
    }
}