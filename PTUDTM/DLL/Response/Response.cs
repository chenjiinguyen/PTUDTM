using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Response
{
    class Response
    {
        [JsonProperty("status")]
        public int Status { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public bool Success { get; set; }

        public Response(int status, string message, bool success)
        {
            this.Status = status;
            this.Message = message;
            this.Success = success;
        }

    }
}
