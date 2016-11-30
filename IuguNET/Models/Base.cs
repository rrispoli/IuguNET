using Newtonsoft.Json;

namespace IuguNET.Models
{
    public abstract class Base
    {
        [JsonProperty("errors")]
        public object Errors { get; set; }
    }
}