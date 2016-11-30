using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class SubAccountData : Base
    {
        [JsonProperty("price_range")]
        public string PriceRange { get; set; }

        [JsonProperty("physical_products")]
        public bool PhysicalProducts { get; set; }

        [JsonProperty("business_type")]
        public string BusinessType { get; set; }

        [JsonProperty("person_type")]
        public string PersonType { get; set; }

        [JsonProperty("automatic_transfer")]
        public bool AutomaticTransfer { get; set; }

        [JsonProperty("cnpj")]
        public string Cnpj { get; set; }

        [JsonProperty("company_name")]
        public string CompanyName { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("cep")]
        public string Cep { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("telephone")]
        public string Telephone { get; set; }

        [JsonProperty("resp_name")]
        public string ResponsableName { get; set; }

        [JsonProperty("resp_cpf")]
        public string ResponsableCpf { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }

        [JsonProperty("bank_ag")]
        public string BankAgency { get; set; }

        [JsonProperty("account_type")]
        public string BankAccountType { get; set; }

        [JsonProperty("bank_cc")]
        public string BankAccountNumber { get; set; }

        [JsonProperty("document_id")]
        public int? DocumentId { get; set; }

        [JsonProperty("document_cpf")]
        public int? DocumentCpf { get; set; }

        [JsonProperty("document_activity")]
        public int? DocumentActivity { get; set; }
    }
}