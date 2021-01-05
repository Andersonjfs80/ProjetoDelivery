using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Model
{
    public class UserAPI
    {
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string GrantType { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public UserAPI() 
        {
            ClientId = "controlp";
            ClientSecret = "p0Pw*#MFnk";
            GrantType = "password";
            UserName = "POS-302578002";
            Password = "POS-302578002";
        }
    }
}
