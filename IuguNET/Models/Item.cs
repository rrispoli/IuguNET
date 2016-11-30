using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class Item : Base
    {
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("quantity")]
        public int Quantity { get; set; }
        [JsonProperty("price_cents")]
        public int PriceCents { get; set; }
    }
}