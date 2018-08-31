using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Travel.Model;

namespace Travel.Services
{
    public static class RestService<T>
    {
        public async static Task<List<Data>> GetAsyncRequest(string url)
        {
            List<Data> result;
            using (HttpClient client = new HttpClient())
            {
                var response = await client.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                RootObject root = JsonConvert.DeserializeObject<RootObject>(json);
                result = root.Data;
            }
            return result;
        }
    }
}
