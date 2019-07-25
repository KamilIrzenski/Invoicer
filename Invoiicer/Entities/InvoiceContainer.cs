using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Entities
{
    public class InvoiceContainer : Companies
    {
        [Key]
        public int InvoiceID { get; set; }
        public string InvoiceNumber { get; set; }
        public string DateOfIssue { get; set; }
        public string PaymentDeadline { get; set; }
        //  public int VAT { get; set; }
        public  Companies Companies { get; set; }
    }



}

