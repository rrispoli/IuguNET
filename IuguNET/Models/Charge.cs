using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class Charge : Base
    {
        [JsonProperty("message")]
        public string Message { get; set; }
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("pdf")]
        public string Pdf { get; set; }
        [JsonProperty("identification")]
        public string Identification { get; set; }
        [JsonProperty("invoice_id")]
        public string InvoiceId { get; set; }
        [JsonProperty("LR")]
        public string LR { get; set; }
    }
}