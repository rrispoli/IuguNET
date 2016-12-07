using Newtonsoft.Json;

namespace IuguNET.Models
{
    public class BankSlipOptions : Base
    {
        /// <summary>
        /// Ativo
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Dias de Vencimento Extras no Boleto (Ex: 2)
        /// </summary>
        [JsonProperty("extra_due ")]
        public int? ExtraDueDays { get; set; }

        /// <summary>
        /// Dias de Vencimento Extras na 2a Via do Boleto (Ex: 1)
        /// </summary>
        [JsonProperty("reprint_extra_due")]
        public int? ReprintExtraDueDays { get; set; }
    }
}