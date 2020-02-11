using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invoicer.Entities;

namespace Invoicer.Entities
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public Contrahent Vendor { get; set; }
        public Contrahent Reciever { get; set; }
        public int NumberOrder { get; set; }
        public int NumberMonth { get; set; }
        public int NumberYear { get; set; }
        public DateTime IssuingDate { get; set; }
        public DateTime PaymentDate { get; set; }
     
        public string InvoiceNumber
        {
            get { return $"FV\\{NumberYear}\\{NumberMonth}\\{NumberOrder}"; }
        }

        public string VendorName
        {
            get => Vendor.Name;

            set => Vendor.Name = value;
        }

        public string ReceiverName
        {
            get { return Reciever.Name; }

            set => Reciever.Name = value;
        }

    
    }



}

