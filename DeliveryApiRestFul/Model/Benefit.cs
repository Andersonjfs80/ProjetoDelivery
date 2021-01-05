using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class Benefit
    {
        [JsonPropertyName("value")]
        public decimal Value { get; set; }

        [JsonPropertyName("target")]
        public string Target { get; set; }

        [JsonPropertyName("sponsorshipValues")]
        public SponsorshipValues SponsorshipValues { get; set; }
    }
}
