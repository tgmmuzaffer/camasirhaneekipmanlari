using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Dtos
{
    public class ProductDto
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public List<Feature> Features { get; set; } = new List<Feature>();        
        public string SelectedFilterfeatureDescItems { get; set; }
        public string SelectedFilterfeatureItems { get; set; }
        public string FilterUrl { get; set; }
        public string SearchText { get; set; }
    }
}
