using DLL.Service;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Services
    {
        private static string base_url = "http://localhost:3000/api/";

        public static BookService book = new BookService(base_url);

        public static AuthService auth = new AuthService(base_url);
    }
}
