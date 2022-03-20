using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Repository.IRepository;

namespace Web.Repository
{
    public class BaseRepo<T> : IBaseRepo<T> where T :class
    {
        private readonly IHttpClientFactory _clientFactory;

        public BaseRepo(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<T> Get(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                var client = _clientFactory.CreateClient();
            
                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(jsonString);
                }

                return null;
            }
            catch (Exception e)
            {
                return null;

            }
        }

        public async Task<List<T>> GetList(string url)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, url);

            var client = _clientFactory.CreateClient();
           
            HttpResponseMessage response = await client.SendAsync(request);
            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var jsonString = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<T>>(jsonString);
            }

            return null;
        }
    }
}
