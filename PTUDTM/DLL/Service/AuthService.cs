using MODEL.Model;
using MODEL.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Service
{
    public class AuthService
    {
        private string base_url;

        public AuthService(string base_url)
        {
            this.base_url = base_url;
        }

        public string Signin(string username, string password, bool remember)
        {
            string token = null;
            IRestClient client = new RestClient(base_url);
            IRestRequest request = new RestRequest("signin", Method.POST);

            request.RequestFormat = DataFormat.Json;
            request.AddBody(new { username = username, password = password, remember = (remember) ? "true" : "false" });

            IRestResponse response = client.Execute(request);
            if (response.StatusCode.ToString() == "OK")
            {
                AuthResponse authResponse = JsonConvert.DeserializeObject<AuthResponse>(response.Content);
                token = authResponse.Token;
            }

            return token;
        }

        public User me(string token)
        {
            User me = null;
            IRestClient client = new RestClient(base_url);
            IRestRequest request = new RestRequest("me", Method.GET);
            request.AddHeader("Authorization", token);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode.ToString() == "OK")
            {
                AuthResponse authResponse = JsonConvert.DeserializeObject<AuthResponse>(response.Content);
                if (authResponse.Success)
                {
                    me = authResponse.Data;
                }
            }

            return me;
        }
    }
}
