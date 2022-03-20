﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Dtos
{
    public class Feature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SubCategoryId { get; set; }
        public string FeatureIds { get; set; }
        public bool IsChoosen { get; set; }
        //public string DynamicFeatureFilterDivId { get; set; }
        public List<SubCategory> SubCategories { get; set; } 
        public List<FeatureDescription> FeatureDescriptions { get; set; }
        public List<Fe_SubCat_Relational> Fe_SubCat_Relationals { get; set; }
    }
}