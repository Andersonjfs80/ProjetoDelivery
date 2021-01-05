using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class Order
    {
        public Order()
        {
            Items = new List<Item>();
            Benefits = new List<Benefit>();
        }

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("shortReference")]
        public string ShortReference { get; set; }

        [JsonPropertyName("createdAt")]
        public string CreatedAt { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("merchant")]
        public Merchant Merchant { get; set; }

        [JsonPropertyName("payments")]
        public List<Payment> Payments { get; set; }

        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("subTotal")]
        public decimal SubTotal { get; set; }

        [JsonPropertyName("totalPrice")]
        public decimal TotalPrice { get; set; }

        [JsonPropertyName("deliveryFee")]
        public decimal DeliveryFee { get; set; }

        [JsonPropertyName("deliveryAddress")]
        public DeliveryAddress DeliveryAddress { get; set; }

        [JsonPropertyName("deliveryDateTime")]
        public DateTime DeliveryDateTime { get; set; }

        [JsonPropertyName("preparationTimeInSeconds")]
        public int PreparationTimeInSeconds { get; set; }

        [JsonPropertyName("scheduled")]
        public bool Scheduled { get; set; }

        [JsonPropertyName("benefits")]
        public List<Benefit> Benefits { get; set; }
    }
}
