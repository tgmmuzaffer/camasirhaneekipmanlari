using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models.Dtos
{
    public class Mail
    {
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EMail { get; set; }
        public string Subject { get; set; }
        public string Message{ get; set; }
        public List<Product> Product { get; set; }
        public string SuccesMessage{ get; set; }
        public string ErrorMessage{ get; set; }

    }
}
