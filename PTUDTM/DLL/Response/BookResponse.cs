using DLL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Response
{
    class BookResponse : Response
    {
        [JsonProperty("data")]
        public Book Data { get; set; }

        public BookResponse(int status, string message, bool success, Book data) : base(status, message, success)
        {
            this.Data = data;
        }

    }
}
