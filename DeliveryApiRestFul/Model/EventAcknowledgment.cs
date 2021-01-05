using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class EventAcknowledgment
    {
        [JsonPropertyName("id")]
        public string id { get; set; }
    }
}
