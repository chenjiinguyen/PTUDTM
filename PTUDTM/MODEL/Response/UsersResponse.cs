using MODEL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Response
{
    public class UsersResponse:Response
    {
        [JsonProperty("data")]
        public List<User> Data { get; set; }

        public UsersResponse(int status, string message, bool success, List<User> data) : base(status, message, success)
        {
            this.Data = data;
        }
    }
}
