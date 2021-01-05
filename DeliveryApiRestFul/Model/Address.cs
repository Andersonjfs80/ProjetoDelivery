using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class Address
    {
        [JsonPropertyName("formattedAddress")]
        public string FormattedAddress { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("neighborhood")]
        public string Neighborhood { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("streetNumber")]
        public string StreetNumber { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }
    }
}
