using DLL.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Response
{
    class BooksResponse : Response
    {
        [JsonProperty("data")]
        public IEnumerable<Book> Data { get; set; }

        public BooksResponse(int status, string message, bool success, IEnumerable<Book> data) : base(status, message, success)
        {
            this.Data = data;
        }

    }
}
