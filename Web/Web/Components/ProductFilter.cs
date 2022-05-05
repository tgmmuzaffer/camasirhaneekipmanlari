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
    public class ProductFilter : ViewComponent
    {
        private readonly IFeatureRepo _featureRepo;
        private readonly IMemoryCache _memoryCache;
        public ProductFilter(IFeatureRepo featureRepo, IMemoryCache memoryCache)
        {
            _featureRepo = featureRepo;
            _memoryCache = memoryCache;
        }
        public async Task<IViewComponentResult> InvokeAsync(ProductDto _productDto)
        {
            string key = "FilterFetaures";
            if (!_memoryCache.TryGetValue(key, out ProductDto productDto))
            {
                productDto = new();
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMonths(1),
                    Priority = CacheItemPriority.High,
                    SlidingExpiration = TimeSpan.FromDays(10)
                };
                _memoryCache.Set(key, productDto, cacheExpiryOptions);
            }

            productDto.FilterArea = _productDto.FilterArea;
            productDto.FilterAreaId = _productDto.FilterAreaId;
            productDto.FilterFetureId = _productDto.FilterFetureId;
            productDto.SelectedFilterfeatureDescItems = _productDto.SelectedFilterfeatureDescItems;
            productDto.SelectedFilterfeatureItems = _productDto.SelectedFilterfeatureItems;
            return View(productDto);
        }
    }
}
