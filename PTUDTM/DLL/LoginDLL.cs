using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class LoginDLL
    {
         HttpClient client = new HttpClient();

         async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://unlucky-snail-75.loca.lt/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

         public async Task<Uri> LoginAsync(String email, String password)
         {
             var nvc = new List<KeyValuePair<string, string>>();
             nvc.Add(new KeyValuePair<string, string>("email", email));
             nvc.Add(new KeyValuePair<string, string>("password", password));
             var req = new HttpRequestMessage(HttpMethod.Post, "https://unlucky-snail-75.loca.lt/api/signin") { Content = new FormUrlEncodedContent(nvc) };
             HttpResponseMessage res = await client.SendAsync(req);

             return res.Headers.Location;
         }
    }
}
