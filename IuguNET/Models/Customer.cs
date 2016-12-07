using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class Customer : Base
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cpf_cnpj")]
        public string CpfCnpj { get; set; }
        [JsonProperty("notes")]
        public string Notes { get; set; }
    }
}