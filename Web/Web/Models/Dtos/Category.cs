using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Dtos
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDesc { get; set; }
        public string ImagePath { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();
    }
}
