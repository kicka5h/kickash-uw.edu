using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace RestServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:#####/api/");

            var result = client.GetAsync("users").Result;

            var json = result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(json);

            var list = JsonConvert.DeserializeObject<List<dynamic>>(json);
            Console.ReadLine();
        }
    }
}
