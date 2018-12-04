using System;
using System.Collections.Generic;
using System.Text;
using HelloWorldApi;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
namespace HelloWorldApp
{
    public class HelloWorldBase
    {
        public string Message { get; set; }

        public async Task<string> GetMessage()
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:50356/");

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                using (HttpResponseMessage response = await client.GetAsync("api/message"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string message = await content.ReadAsStringAsync();
                        if (message != null)
                        {
                            Message = message;

                            return message;
                        }
                    }
                }
            }

            return null;
        }
    }
}
