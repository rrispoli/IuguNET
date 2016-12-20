using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class SubAccountCreation : Base
    {
        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("live_api_token")]
        public string LiveApiToken { get; set; }

        [JsonProperty("test_api_token")]
        public string TestApiToken { get; set; }

        [JsonProperty("user_token")]
        public string UserToken { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("verified")]
        public bool? Verified { get; set; }
    }
}