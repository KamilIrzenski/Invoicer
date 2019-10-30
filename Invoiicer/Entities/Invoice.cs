using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public int VendorID { get; set; }
        public int ReceiverID { get; set; }
        public int InvoiceNumber { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime PaymentDate { get; set; }
        //  public int VAT { get; set; }
       // public  Company Companies { get; set; }
    }



}

