using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Dtos
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Feature> Features { get; set; }
        public List<Fe_SubCat_Relational> Fe_SubCat_Relationals { get; set; }
    }
}
