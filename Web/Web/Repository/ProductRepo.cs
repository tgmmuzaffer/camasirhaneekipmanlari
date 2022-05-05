using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Repository
{
    public class ProductRepo :  IProductRepo
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductRepo(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<List<Product>> GetProducts(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Product>>(jsonString);
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }

        }
        public async Task<ProductDto> GetPagedProducts(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    string headerVal = string.Empty;
                    if (response.Headers.TryGetValues("X-Pagination", out IEnumerable<string> values))
                    {
                        headerVal = values.FirstOrDefault();
                    };
                    ProductDto productDto = new();
                    productDto.Products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
                    if (!string.IsNullOrEmpty(headerVal))
                    {
                        productDto.PagedData = JsonConvert.DeserializeObject<PagedData>(headerVal);
                    }

                    return productDto;
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<Product> GetProduct(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<Product>(jsonString);
                }

                return null;
            }
            catch (Exception e)
            {
                return null;

            }
        }
        public async Task<ProductDto> GetProductsWithPagedSubCategory(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    string headerVal = string.Empty;
                    if (response.Headers.TryGetValues("X-Pagination", out IEnumerable<string> values))
                    {
                        headerVal = values.FirstOrDefault();
                    };

                    ProductDto productDto = new();
                    productDto.Products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
                    if (!string.IsNullOrEmpty(headerVal))
                    {
                        productDto.PagedData = JsonConvert.DeserializeObject<PagedData>(headerVal);
                    }

                    return productDto;
                }

                return null;
            }
            catch (Exception e)
            {
                return null;

            }
        }
        public async Task<List<Product>> GetProductsWithcategoryFilter(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<Product>>(jsonString);
                }

                return null;
            }
            catch (Exception e)
            {
                return null;

            }
        }
        public async Task<ProductDto> GetProductsWithPagedCategory(string url)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, url);

                var client = _clientFactory.CreateClient();

                HttpResponseMessage response = await client.SendAsync(request);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    string headerVal = string.Empty;
                    if (response.Headers.TryGetValues("X-Pagination", out IEnumerable<string> values))
                    {
                        headerVal = values.FirstOrDefault();
                    };

                    ProductDto productDto = new();
                    productDto.Products = JsonConvert.DeserializeObject<List<Product>>(jsonString);
                    if (!string.IsNullOrEmpty(headerVal))
                    {
                        productDto.PagedData = JsonConvert.DeserializeObject<PagedData>(headerVal);
                    }


                    return productDto;
                }

                return null;
            }
            catch (Exception e)
            {
                return null;

            }
        }

    }
}
