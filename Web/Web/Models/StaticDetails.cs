using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public static class StaticDetails
    {
        //cache
        public static string product = "AllProducts";
        //cache




        public static string mainUrl = "https://localhost:44396/";
        //public static string mainUrl = "https://api.camasirhaneekipmanlari.com/";
        //public static string currentsiteUrl = "https://camasirhaneekipmanlari.com/";
        public static string currentsiteUrl = "https://localhost:44396/";
        //image
        public static string image = "webpImages/";
        //categories
        public static string getCategory = mainUrl + "api/category/getCategory/";
        public static string getCategoryByName = mainUrl + "api/category/getCategoryByName/";
        public static string getAllCategories = mainUrl + "api/category/getAllCategories";
        public static string getAllCategoriesName = mainUrl + "api/category/getAllCategoriesName";
        //product
        public static string getProductsByCatId = mainUrl + "api/product/getPagedProductsByCatId";
        public static string getProductsBySubCatId = mainUrl + "api/product/getPagedProductsBySubCatId";
        public static string getProductsByBrand = mainUrl + "api/product/getPagedProductsByBrand/";
        public static string getAllProductsByBrand = mainUrl + "api/product/getProductsByFeatureDescId/";
        public static string getProduct = mainUrl + "api/product/getProduct/";
        public static string getAllProducts = mainUrl + "api/product/getAllProducts/";
        public static string searchForProducts = mainUrl + "api/product/searchForProducts/";
        public static string getPagedAllProducts = mainUrl + "api/product/getPagedAllProducts/";
        //slider
        public static string getAllSliders = mainUrl + "api/slider/getAllSliders";
        public static string getAllSlidersIsShow = mainUrl + "api/slider/getAllSliders/";
        //FeatureDescription
        public static string getAllfeatureDescriptionsByFeatureId = mainUrl + "api/featureDescription/getAllfeatureDescriptionsByFeatureId/";
        //feature
        public static string getAllFeatures = mainUrl + "api/feature/getAllFeatures";
        public static string getFeatureByName = mainUrl + "api/feature/getFeatureByName/";
        //aboutus
        public static string getAboutUs = mainUrl + "api/aboutus/getAboutUs";
        //contact
        public static string getContact = mainUrl + "api/contact/getContact";
        //blog
        public static string getAllBlogs = mainUrl + "api/blog/getAllBlogs";
        public static string getBlog = mainUrl + "api/blog/getBlog/";
        //FeatureCatRelational
        public static string getAllFeCatsByCatId = mainUrl + "api/fecat/getAllFeCatsByCatId";
        //referance
        public static string getAllReferances = mainUrl + "api/referance/getAllReferances";


        public static string GetImage(string imageName)
        {
            string url = mainUrl + image + imageName;
            return url;
        }
    }
}
