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

        public ProductController(IMemoryCache memoryCache, IProductRepo productRepo, IFeatureRepo featureRepo, ICategoryRepo categoryRepo) : base(memoryCache)
        {
            _productRepo = productRepo;
            _featureRepo = featureRepo;
            _categoryRepo = categoryRepo;
        }

        [Route(template: "/Urunler")]
        [Route(template: "/Urunler/{pn}")]
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "pn" })]
        public async Task<IActionResult> Products(int pn = 1)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey());
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                ProductDto productDto = new();
                productDto = await _productRepo.GetPagedProducts(StaticDetails.getPagedAllProducts + "?PageNumber=" + pn);
                //productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                productDto.PagedData.RouteSegment = "/Urunler/";
                productDto.FilterArea = (int)SearchArea.All;
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
            string key = "allprodbyb";
            var cacheValue = GetCacheDataProduct(key);
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                if (productDto.FilterFetureId == 0)
                {
                    productDto.Products = await _productRepo.GetProducts(StaticDetails.searchForProducts);
                    //productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                    AddCacheDataProduct(key, productDto);
                    AddSeo(productDto);
                }
                else
                {
                    productDto.Products = await _productRepo.GetProducts(StaticDetails.getAllProductsByBrand + productDto.FilterFetureId);
                    //productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                    //AddCacheDataProduct(key, productDto);
                    AddSeo(productDto);
                }


                ProductDto tempProductDto = new();
                //tempProductDto.Features = productDto.Features;
                tempProductDto.FilterArea = productDto.FilterArea;
                tempProductDto.FilterAreaId = productDto.FilterAreaId;
                tempProductDto.FilterFetureId = productDto.FilterFetureId;
                tempProductDto.SelectedFilterfeatureDescItems = productDto.SelectedFilterfeatureDescItems;
                tempProductDto.SelectedFilterfeatureItems = productDto.SelectedFilterfeatureItems;
                if (productDto.FilterArea == 1 && productDto.FilterFetureId == 0)
                {
                    tempProductDto.Products = productDto.Products;
                }
                else if (productDto.FilterArea == 1 && productDto.FilterFetureId != 0)
                {
                    tempProductDto.Products = productDto.Products.FindAll(a => a.FeatureDescriptions.Any(b => b.FeatureId == productDto.FilterFetureId));
                }
                else if (productDto.FilterArea == 2)
                {
                    tempProductDto.Products = productDto.Products.FindAll(a => a.CategoryId == productDto.FilterAreaId);
                }
                else if (productDto.FilterArea == 3)
                {
                    tempProductDto.Products = productDto.Products.FindAll(a => a.SubCategoryId == productDto.FilterAreaId);
                }
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler" };
                TempData["Page"] = "Ürünler";
                #endregion
                var filtreddata = GetFilteredData(tempProductDto);
                return View(filtreddata);

            }

            ProductDto _tempProductDto = new();
            //_tempProductDto.Features = productDto.Features;
            _tempProductDto.FilterArea = productDto.FilterArea;
            _tempProductDto.FilterAreaId = productDto.FilterAreaId;
            _tempProductDto.FilterFetureId = productDto.FilterFetureId;

            if (productDto.FilterArea == 1 && productDto.FilterFetureId == 0)
            {
                _tempProductDto.Products = cacheValue.Products;
            }
            else if(productDto.FilterArea == 1 && productDto.FilterFetureId != 0)
            {
                _tempProductDto.Products = productDto.Products.FindAll(a => a.FeatureDescriptions.Any(b => b.FeatureId == productDto.FilterFetureId));
            }
            else if (productDto.FilterArea == 2)
            {
                _tempProductDto.Products = cacheValue.Products.FindAll(a => a.CategoryId == productDto.FilterAreaId);
            }
            else if (productDto.FilterArea == 3)
            {
                _tempProductDto.Products = cacheValue.Products.FindAll(a => a.SubCategoryId == productDto.FilterAreaId);
            }
            _tempProductDto.SelectedFilterfeatureDescItems = productDto.SelectedFilterfeatureDescItems;
            _tempProductDto.SelectedFilterfeatureItems = productDto.SelectedFilterfeatureItems;
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler" };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(GetFilteredData(_tempProductDto));

        }

        [Route(template: "/Urunler/{categoryName}/{Id}/{pn}")]
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "categoryName", "Id", "pn" })]
        public async Task<IActionResult> GetProductsByCategoryId(string categoryName, int Id, int pn = 1)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey());
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                ProductDto productDto = new();
                productDto = await _productRepo.GetProductsWithPagedCategory(StaticDetails.getProductsByCatId + "?Id=" + Id + "&PageNumber=" + pn);
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                productDto.PagedData.RouteSegment = "/Urunler/" + categoryName + "/" + Id + "/";
                productDto.FilterAreaId = Id;
                productDto.FilterArea = (int)SearchArea.Category;
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

        [Route(template: "/Urunler/{categoryName}/{subcategoryName}/{Id}/{pn}")]
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "categoryName", "subcategoryName", "Id", "pn" })]
        public async Task<IActionResult> GetProductsBySubCategoryId(string categoryName, string subcategoryName, int Id, int pn = 1)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey());
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                ProductDto productDto = new();
                productDto = await _productRepo.GetProductsWithPagedSubCategory(StaticDetails.getProductsBySubCatId + "?Id=" + Id + "&PageNumber=" + pn);
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                productDto.FilterAreaId = Id;
                productDto.FilterArea = (int)SearchArea.SubCategory;
                AddSeo(productDto);
                string key = GetCacheKey();
                AddCacheDataProduct(key, productDto);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler", subcategoryName.Replace("-", " ") };
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
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "name", "Id" })]
        public async Task<IActionResult> GetProductDetail(string name, int Id)
        {
            var product = await _productRepo.GetProduct(StaticDetails.getProduct + Id);
            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler", name };
            TempData["Page"] = name;
            #endregion

            return View(product);
        }

        [Route(template: "/Urunler/Marka/{brandName}/{Id}/{pn}")]
        [ResponseCache(Duration = 2650000, Location = ResponseCacheLocation.Any, VaryByQueryKeys = new[] { "brandName", "Id", "pn" })]
        public async Task<IActionResult> GetProductByBrandId(string brandName, int Id, int pn)
        {
            var cacheValue = GetCacheDataProduct(GetCacheKey());
            if (cacheValue == null || cacheValue.Products.Count == 0)
            {
                ProductDto productDto = new();
                productDto = await _productRepo.GetPagedProducts(StaticDetails.getProductsByBrand + "?Id=" + Id + "&PageNumber=" + pn);
                productDto.Features = await _featureRepo.GetList(StaticDetails.getAllFeatures);
                productDto.FilterFetureId = Id;
                productDto.FilterArea = (int)SearchArea.All;
                AddSeo(productDto);
                string key = GetCacheKey();
                AddCacheDataProduct(key, productDto);
                #region BreadCrumb
                TempData["BreadCrumb"] = new List<string> { "Ürünler", brandName };
                TempData["Page"] = "Ürünler";
                #endregion
                return View(productDto);
            }

            #region BreadCrumb
            TempData["BreadCrumb"] = new List<string> { "Ürünler", brandName };
            TempData["Page"] = "Ürünler";
            #endregion
            return View(cacheValue);
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
