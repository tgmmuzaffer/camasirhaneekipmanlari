using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Components
{
    public class ProductFilterByCategory : ViewComponent
    {
        private readonly IProductRepo _productRepo;
        private readonly IMemoryCache _memoryCache;

        public ProductFilterByCategory(IMemoryCache memoryCache, IProductRepo productRepo)
        {
            _memoryCache = memoryCache;
            _productRepo = productRepo;
        }

        //[HttpPost]
        //[Route("/{categoryName}/filter/{catId}")]
        public async Task<IViewComponentResult> InvokeAsync(string categoryName, int catId, int[] fetureDescIds)
        {
            var cacheKey = categoryName;
            ProductList products = new();
            List<Product> filteredProducts = new();
            if (!_memoryCache.TryGetValue(cacheKey, out products))
            {
                products = await _productRepo.GetProductsWithcategoryFilter(StaticDetails.getProductsByCatId + catId);
                var featureslist = products.Products.Select(a => new { a.Feature, a.FeatureDescriptions });
                foreach (var item in products.Products)
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
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddHours(1),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromMinutes(10)
                };
                _memoryCache.Set(cacheKey, products, cacheExpiryOptions);
            }
            if (products != null && products.Products.Count > 0)
            {
                filteredProducts = products.Products.Where(a => a.FeatureDescriptions.Any(b => fetureDescIds.Contains(b.Id))).ToList();
            }
            //if (filteredProducts != null && filteredProducts.Count > 0)
            //{
            //    return View
            //}
            return View(filteredProducts);
        }

       
    }
}
