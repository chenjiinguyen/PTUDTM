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
    public class BookService
    {

        private string base_url;

        public BookService(string base_url)
        {
            this.base_url = base_url;
        }

        public Book GetByID(int id)
        {
            Book book = null;
            IRestClient client = new RestClient(base_url);
            IRestRequest request = new RestRequest("book", Method.GET);

            //request.AddHeader("Authorization", "Bearer qaPmk9Vw8o7r7UOiX-3b-8Z_6r3w0Iu2pecwJ3x7CngjPp2fN3c61Q_5VU3y0rc-vPpkTKuaOI2eRs3bMyA5ucKKzY1thMFoM0wjnReEYeMGyq3JfZ-OIko1if3NmIj79ZSpNotLL2734ts2jGBjw8-uUgKet7jQAaq-qf5aIDwzUo0bnGosEj_UkFxiJKXPPlF2L4iNJSlBqRYrhw08RK1SzB4tf18Airb80WVy1Kewx2NGq5zCC-SCzvJW-mlOtjIDBAQ5intqaRkwRaSyjJ_MagxJF_CLc4BNUYC3hC2ejQDoTE6HYMWMcg0mbyWghMFpOw3gqyfAGjr6LPJcIly__aJ5__iyt-BTkOnMpDAZLTjzx4qDHMPWeND-TlzKWXjVb5yMv5Q6Jg6UmETWbuxyTdvGTJFzanUg1HWzPr7gSs6GLEv9VDTMiC8a5sNcGyLcHBIJo8mErrZrIssHvbT8ZUPWtyJaujKvdgazqsrad9CO3iRsZWQJ3lpvdQwucCsyjoRVoj_mXYhz3JK3wfOjLff16Gy1NLbj4gmOhBBRb8rJnUXnP7rBHs00FAk59BIpKLIPIyMgYBApDCut8V55AgXtGs4MgFFiJKbuaKxq8cdMYEVBTzDJ-S1IR5d6eiTGusD5aFlUkAs9NV_nFw");
            request.AddParameter("id", id);

            IRestResponse response = client.Execute(request);
            if (response.StatusCode.ToString() == "OK")
            {
                BookResponse bookResponse = JsonConvert.DeserializeObject<BookResponse>(response.Content);
                book = bookResponse.Data;
            }
           
            return book;
        }

        public List<Book> GetAll()
        {
            List<Book> books = null;
            IRestClient client = new RestClient(base_url);
            IRestRequest request = new RestRequest("book", Method.GET);


            IRestResponse response = client.Execute(request);
            if (response.StatusCode.ToString() == "OK")
            {
                BooksResponse bookResponse = JsonConvert.DeserializeObject<BooksResponse>(response.Content);
                books = bookResponse.Data.ToList();
            }

            return books;
        }
    }
}
