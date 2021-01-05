using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class Item
    {
        public Item()
        {
            SubItems = new List<SubItem>();
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quantity")]
        public decimal Quantity { get; set; }

        [JsonPropertyName("price")]
        public decimal Price { get; set; }

        [JsonPropertyName("subItemsPrice")]
        public decimal SubItemsPrice { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }

        [JsonPropertyName("discount")]
        public decimal Discount { get; set; }

        [JsonPropertyName("addition")]
        public decimal Addition { get; set; }

        [JsonPropertyName("externalCode")]
        public string ExternalCode { get; set; }

        [JsonPropertyName("observations")]
        public string Observations { get; set; }

        [JsonPropertyName("subItems")]
        public List<SubItem> SubItems { get; set; }
    }
}
