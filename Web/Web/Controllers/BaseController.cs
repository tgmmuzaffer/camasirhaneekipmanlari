using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        private readonly IMemoryCache _memoryCache;
        public BaseController(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;

        }
        public void AddSeo(ProductDto productDto)
        {
            foreach (var item in productDto.Products)
            {
                List<ProductSeo> productSeos = new();

                for (int i = 0; i < item.Feature.Count; i++)
                {
                    var featDesc = item.FeatureDescriptions.Where(a => a.FeatureId == item.Feature[i].Id).FirstOrDefault();
                    ProductSeo productSeo = new()
                    {
                        Feature = item.Feature[i].Name,
                        FeatureDescription = featDesc.FeatureDesc
                    };
                    productSeos.Add(productSeo);
                }

                item.ProductSeos = productSeos;
            }

        }

        public ProductDto GetCacheDataProduct(string key)
        {
            if (_memoryCache.TryGetValue(key, out ProductDto productDto))
            {
                return productDto;
            }

            return null;
        }

        public List<Blog> GetCacheDataBlog(string key)
        {
            if (_memoryCache.TryGetValue(key, out List<Blog> blogs))
            {
                return blogs;
            }

            return null;
        }

        public string GetCacheKey(bool usereferer = default)
        {
            string _path = string.Empty;
            if (usereferer)
            {
                var referer = this.HttpContext.Request.GetTypedHeaders().Referer.AbsolutePath;
                if (referer.Contains("filter"))
                {
                    referer = referer.Replace("filter", "");
                }
                _path = StringProcess.ClearString(referer);
                return _path;
            }
            var path = this.HttpContext.Request.Path;
            _path = StringProcess.ClearString(path);
            return _path;
        }

        public void AddCacheDataProduct(string key, ProductDto productDto)
        {
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddHours(1),
                Priority = CacheItemPriority.High,
                SlidingExpiration = TimeSpan.FromMinutes(10)
            };
            _memoryCache.Set(key, productDto, cacheExpiryOptions);
        }

        public void AddCacheDataBlog(string key, List<Blog> blogs)
        {
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddHours(1),
                Priority = CacheItemPriority.Normal,
                SlidingExpiration = TimeSpan.FromMinutes(10)
            };
            _memoryCache.Set(key, blogs, cacheExpiryOptions);
        }



        public ProductDto GetFilteredData(ProductDto productDto)
        {
            if (productDto.SelectedFilterfeatureItems != null && productDto.SelectedFilterfeatureItems != null)
            {
                var stringfeatureDescriptionFilterItems = productDto.SelectedFilterfeatureDescItems.Split(",");
                var stringfeatureFilterItems = productDto.SelectedFilterfeatureItems.Split(",");
                List<int> selectedfetureFilterItems = new();
                Dictionary<int, List<int>> selectedDictionary = new();
                for (int i = 0; i < stringfeatureDescriptionFilterItems.Length; i++)
                {
                    int fId = Convert.ToInt32(stringfeatureFilterItems[i]);
                    int fdId = Convert.ToInt32(stringfeatureDescriptionFilterItems[i]);
                    selectedfetureFilterItems.Add(fId);
                    var iskeyexist = selectedDictionary.ContainsKey(fId);
                    if (!iskeyexist)
                    {
                        selectedDictionary.Add(fId, new List<int> { fdId });
                    }
                    else
                    {
                        List<int> list = new List<int>();
                        selectedDictionary.TryGetValue(fId, out list);
                        if (list != null && list.Count > 0)
                        {
                            selectedDictionary[fId].Add(fdId);
                        }

                    }
                }
                ProductDto tempDto = new();
                tempDto.Features = productDto.Features;
                tempDto.SelectedFilterfeatureDescItems = productDto.SelectedFilterfeatureDescItems;
                if (productDto.Products != null && productDto.Products.Count > 0)
                {
                    tempDto.Products = productDto.Products.Where(a => a.FeatureDescriptions.Count > 0).ToList();
                    foreach (var itemSFFI in selectedfetureFilterItems)
                    {
                        if (selectedDictionary.TryGetValue(itemSFFI, out List<int> filterItems))
                        {
                            tempDto.Products = tempDto.Products.Where(a => a.FeatureDescriptions.Any(b => filterItems.Contains(b.Id))).ToList();
                        }
                    }
                }
                return tempDto;
            }
            productDto.Products.Clear();
            return productDto;
        }


        public byte[] GetImageWithCache (string imageName)
        {
            string url = StaticDetails.mainUrl + StaticDetails.image + imageName;
            using var file = System.IO.File.OpenRead(url);
            using var outputStream = new MemoryStream();
            file.CopyTo(outputStream);
            var stImage = outputStream.ToArray();
            return stImage;
        }
    }
}
