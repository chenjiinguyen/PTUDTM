using MODEL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Response
{
    public class UserResponse:Response
    {
        [JsonProperty("data")]
        public User Data { get; set; }

        public UserResponse(int status, string message, bool success, User data) : base(status, message, success)
        {
            this.Data = data;
        }
    }
}
