﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Dtos
{
    public class Slider
    {
        public int Id { get; set; }
        public string SliderName { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Content3 { get; set; }
        public string Link { get; set; }
        public string ButtonName { get; set; }
        public string ImageName { get; set; }
        public bool IsShow { get; set; }
    }
}