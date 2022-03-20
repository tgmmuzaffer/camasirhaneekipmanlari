using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Dtos
{
    public class Breadcrumb
    {
        public List<string> Data { get; set; }
        public string Page { get; set; }
    }
}
