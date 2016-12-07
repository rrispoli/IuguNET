using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class Information : Base
    {
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}