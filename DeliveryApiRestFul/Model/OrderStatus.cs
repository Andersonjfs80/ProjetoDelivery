using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class OrderStatus
    {
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("eventordercode")]
        public string EventOrderCode { get; set; }

        [JsonPropertyName("rejectioncode")]
        public string RejectionCode { get; set; }

        [JsonPropertyName("rejectionmotive")]
        public string RejectionMotive { get; set; }
    }
}
