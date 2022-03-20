using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models.Dtos;

namespace Web.Repository.IRepository
{
    public interface IProductRepo
    {
        Task<Product> GetProduct(string url);
        Task<List<Product>> GetProductsWithcategoryFilter(string url);
        Task<List<Product>> GetProducts(string url);
    }
}
