using MODEL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Response
{
    public class AuthResponse:UserResponse
    {
        

        [JsonProperty("token")]
        public string Token { get; set; }

        public AuthResponse(int status, string message, bool success, User data, string token) : base(status, message, success, data)
        {
            this.Token = token;
        }

    }
}
