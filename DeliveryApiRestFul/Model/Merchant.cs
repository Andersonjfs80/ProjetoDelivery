using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class Merchant
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("shortReference")]
        public string Nome { get; set; }

        [JsonPropertyName("phones")]
        public List<string> Phones { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }
    }
}
