using System;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var query = @"
                {
                  author(id: 1) {
                    name
                  }
                }";

            var postData = new { Query = query };
            var stringContent = new StringContent(JsonConvert.SerializeObject(postData), Encoding.UTF8, "application/json");

        }


    }
}
