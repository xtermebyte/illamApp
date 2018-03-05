using System;
using System.Net.Http;
using illam.Model;
using Newtonsoft.Json;

namespace illam.Services
{
    public class TestService
    {
        //static string TestServiceURL = "http://192.168.1.67/illam/api/test";
        static string TestServiceURL = "https://illam.azurewebsites.net/api/test";
        public TestService()
        {
        }

        public static TestModel GetTest()
        {
            HttpClient client = new HttpClient();
            //var uri = new Uri(TestServiceURL);
            var response = client.GetAsync(TestServiceURL).GetAwaiter().GetResult().Content.ReadAsStringAsync().GetAwaiter().GetResult();
            var ret = JsonConvert.DeserializeObject<TestModel>(response);
            return ret;
        }
    }
}
