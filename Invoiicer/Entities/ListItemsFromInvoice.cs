using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Invoicer.Entities;

namespace Invoiicer.Entities
{
    class ListItemsFromInvoice
    {

        [Key]
        public int ListId { get; set; }

        public Product Product { get; set; }
//        public InvoiceContainer InvoiceContainer { get; set; }
        public ICollection<InvoiceContainer> InvoiceContainers { get; set; }

    }
}
