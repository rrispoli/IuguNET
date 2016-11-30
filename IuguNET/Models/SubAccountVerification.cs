using Newtonsoft.Json;
using System;

namespace IuguNET.Models
{
    public class SubAccountVerification : Base
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("data")]
        public SubAccountData Data { get; set; }

        [JsonProperty("account_id")]
        public string AccountId { get; set; }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
    }
}