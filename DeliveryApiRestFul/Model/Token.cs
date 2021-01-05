using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Application.Model
{
    public class Token
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        public DateTime AccessTokenExpiry { get { return DateTime.Now.AddSeconds(ExpiresIn); } }

        public bool IsTokenValid { get { return AccessTokenExpiry > DateTime.Now; } }
    }
}
