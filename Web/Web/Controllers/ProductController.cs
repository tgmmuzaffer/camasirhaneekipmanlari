using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;
using Web.Models.Dtos;
using Web.Repository.IRepository;

namespace Web.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductRepo _productRepo;
        private readonly IFeatureRepo _featureRepo;
        private readonly ICategoryRepo _categoryRepo;

        public ProductController(IMemoryCache memoryCache, IProductRepo productRepo, IFeatureRepo featureRepo ,ICategoryRepo categoryRepo) : base(memoryCache)
        {
            _productRepo = productRepo;
            _featureRepo = featureRepo;
            _categoryRepo = categoryRepo;
        }

        [Route(template: "/Urunler")]
        public async Task<IActionResult> Products()
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey());
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                ProductDto productDto = new();
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                productDto.Products = await _productRepo.GetProducts(StaticDetails.getAllProducts);
                AddSeo(productDto);
                string key = GetCacheKey();
                AddCacheDataProduct(key, productDto);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler" };
                TempData["Page"] = "Ürünler";
                #endregion

                return View(productDto);
            }

            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler" };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(cacheValue);
        }

        [HttpPost]
        [Route("/Urunler/filter")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetFilterResultProducts(ProductDto productDto)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey(true));
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                productDto.Products = await _productRepo.GetProducts(StaticDetails.getAllProducts);
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);

                AddSeo(productDto);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler" };
                TempData["Page"] = "Ürünler";
                #endregion
                var filtreddata = GetFilteredData(productDto);
                return View(filtreddata);

            }

            cacheValue.SelectedFilterfeatureDescItems = productDto.SelectedFilterfeatureDescItems;
            cacheValue.SelectedFilterfeatureItems = productDto.SelectedFilterfeatureItems;
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler" };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(GetFilteredData(cacheValue));

        }

        [Route(template: "/Urunler/{categoryName}/{Id}")]
        public async Task<IActionResult> GetProductsByCategoryId(string categoryName, int Id)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey());
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                ProductDto productDto = new();
                if(Id <= 0)
                {
                    var cat = await _categoryRepo.Get(StaticDetails.getCategoryByName + categoryName);
                }
                productDto.Products = await _productRepo.GetProductsWithcategoryFilter(StaticDetails.getProductsByCatId + Id);
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                AddSeo(productDto);
                string key = GetCacheKey();
                AddCacheDataProduct(key, productDto);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler", categoryName };
                TempData["Page"] = "Ürünler";
                #endregion
                return View(productDto);
            }

            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler", categoryName };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(cacheValue);
        }

        [HttpPost]
        [Route("/Urunler/{categoryName}/filter/{catId}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetFilterResultCateory(string categoryName, int catId, ProductDto productDto)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey(true));
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                productDto.Products = await _productRepo.GetProductsWithcategoryFilter(StaticDetails.getProductsByCatId + catId);
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                AddSeo(productDto);
                var filtreddata = GetFilteredData(productDto);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler", categoryName };
                TempData["Page"] = "Ürünler";
                #endregion
                return View(filtreddata);
            }

            cacheValue.SelectedFilterfeatureDescItems = productDto.SelectedFilterfeatureDescItems;
            cacheValue.SelectedFilterfeatureItems = productDto.SelectedFilterfeatureItems;
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler", categoryName };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(GetFilteredData(cacheValue));
        }

        [Route(template: "/Urunler/{categoryName}/{subcategoryName}/{Id}")]
        public async Task<IActionResult> GetProductsBySubCategoryId(string categoryName, string subcategoryName, int Id)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey());
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                ProductDto productDto = new();
                productDto.Products = await _productRepo.GetProductsWithcategoryFilter(StaticDetails.getProductsBySubCatId + Id);
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                AddSeo(productDto);
                string key = GetCacheKey();
                AddCacheDataProduct(key, productDto);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler",  subcategoryName.Replace("-"," ") };
                TempData["Page"] = "Ürünler";
                #endregion
                return View(productDto);

            }

            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler", categoryName, subcategoryName };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(cacheValue);
        }

        [Route(template: "/Urun/{name}/{Id}")]
        public async Task<IActionResult> GetProductDetail(string name ,int Id)
        {
            var product = await _productRepo.GetProduct(StaticDetails.getProduct + Id);
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler",name };
            TempData["Page"] = name;
            #endregion

            return View(product);
        }

        [Route(template: "/Urunler/Marka/{brandName}/{Id}")]
        public async Task<IActionResult> GetProductByBrandId(string brandName, int Id)
        {
            ProductDto productDto = new();
            #region FilterBarData
            productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
            #endregion
            productDto.Products = await _productRepo.GetProducts(StaticDetails.getProductsByFeatureDescId + Id);
            #region AddSeo
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
            #endregion
            #region Cache
            //var cacheKey = "Products";
            //var hasValue = _memoryCache.TryGetValue(cacheKey, out products);

            //if (!hasValue)
            //{
            //    products = new();
            //    products = await _productRepo.GetProducts(StaticDetails.getAllProducts);
            //    foreach (var item in products)
            //    {
            //        List<ProductSeo> productSeos = new();

            //        for (int i = 0; i < item.Feature.Count; i++)
            //        {
            //            var featDesc = item.FeatureDescriptions.Where(a => a.FeatureId == item.Feature[i].Id).FirstOrDefault();
            //            ProductSeo productSeo = new()
            //            {
            //                Feature = item.Feature[i].Name,
            //                FeatureDescription = featDesc.FeatureDesc
            //            };
            //            productSeos.Add(productSeo);
            //        }

            //        item.ProductSeos = productSeos;
            //    }
            //    var cacheExpiryOptions = new MemoryCacheEntryOptions
            //    {
            //        AbsoluteExpiration = DateTime.Now.AddHours(1),
            //        Priority = CacheItemPriority.High,
            //        SlidingExpiration = TimeSpan.FromMinutes(10)
            //    };
            //    _memoryCache.Set(cacheKey, products, cacheExpiryOptions);
            //}
            #endregion
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler", brandName };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(productDto);
        }

        [HttpPost]
        [Route("/Arama")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SearchByText(ProductDto productDto)
        {
            /*
             * Buraya gelen kaydı cache e al
             * search text yoksa cache den sorgulama yap 
             * modele filtre edilmiş datayı ata
             * sonra cachi sil
             */
            var url = this.HttpContext.Request.GetTypedHeaders().Referer.AbsolutePath;



            productDto.Products = await _productRepo.GetProducts(StaticDetails.getAllProducts);
            if (!string.IsNullOrEmpty(productDto.SearchText))
            {
                productDto.Products = productDto.Products
                    .Where(a =>
                    a.Name.Contains(productDto.SearchText) ||
                    a.ShortDesc.Contains(productDto.SearchText) ||
                    a.Feature.Any(b => productDto.SearchText.Contains(b.Name)) ||
                    a.FeatureDescriptions.Any(b => productDto.SearchText.Contains(b.FeatureDesc)))
                    .ToList();
            }
            //else
            //{
            //    var stringFilterItems = productDto.SelectedFilterItems.Split(",");
            //    List<int> selectedFilterItems = new();
            //    for (int i = 0; i < stringFilterItems.Length; i++)
            //    {
            //        selectedFilterItems.Add(Convert.ToInt32(stringFilterItems[i]));
            //    }

            //    var featureslist = await _featureRepo.GetList(StaticDetails.getAllFeatures);
            //    ProductDto filteredProducts = new() { SelectedFilterItems = productDto.SelectedFilterItems, Features = featureslist, Products = products };
            //    if (filteredProducts != null && filteredProducts.Products.Count > 0)
            //    {
            //        for (int i = 0; i < selectedFilterItems.Count; i++)
            //        {
            //            filteredProducts.Products = filteredProducts.Products.Where(a => a.FeatureDescriptions.Any(b => b.Id == selectedFilterItems[i])).ToList();
            //        }
            //    }
            //}
            #region AddSeo
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
            #endregion
            productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);

            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler" };
            TempData["Page"] = "Arama";
            #endregion

            return View(productDto);
        }





    }
}
