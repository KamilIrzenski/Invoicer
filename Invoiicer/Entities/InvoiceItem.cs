using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Invoicer.Entities;

namespace Invoicer.Entities
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double PriceNet { get; set; }
        public double Tax { get; set; }
        public Product Product { get; set; }
    }
}
