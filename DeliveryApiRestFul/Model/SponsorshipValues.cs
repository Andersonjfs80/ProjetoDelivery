using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class SponsorshipValues
    {
        [JsonPropertyName("IFOOD")]
        public decimal Ifood { get; set; }

        [JsonPropertyName("MERCHANT")]
        public decimal Merchant { get; set; }
    }
}
