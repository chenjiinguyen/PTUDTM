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
    public class UserService
    {
        private string base_url;

        public UserService(string base_url)
        {
            this.base_url = base_url;
        }

        public List<User> GetAll()
        {
            List<User> users = null;
            IRestClient client = new RestClient(base_url);
            IRestRequest request = new RestRequest("user", Method.GET);

    

            IRestResponse response = client.Execute(request);
            if (response.StatusCode.ToString() == "OK")
            {
                UsersResponse bookResponse = JsonConvert.DeserializeObject<UsersResponse>(response.Content);
                users = bookResponse.Data;
            }

            return users;
        }
    }
}
