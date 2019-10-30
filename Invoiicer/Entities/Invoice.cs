using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoiicer.Entities;

namespace Invoicer.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public Company Vendor { get; set; }
        public Company Reciever { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }



}

