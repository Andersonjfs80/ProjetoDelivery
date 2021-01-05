using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class PoolingEvent
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("correlationId")]
        public string CorrelationId { get; set; }

        [JsonPropertyName("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
