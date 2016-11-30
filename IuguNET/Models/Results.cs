using Newtonsoft.Json;
using System.Collections.Generic;

namespace IuguNET.Models
{
    public class Results<T> where T : new()
    {
        [JsonProperty("totalItems")]
        public int TotalItems { get; set; }

        [JsonProperty("items")]
        public List<T> Items { get; set; }
    }
}