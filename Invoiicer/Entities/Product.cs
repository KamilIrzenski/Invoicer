
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoiicer.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
    }
}
