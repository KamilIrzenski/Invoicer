using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Entities
{
    class MyCompaniest
    {
        [Key]
        public int FirmID { get; set; }
        public string NameCompanies { get; set; }
        public string NIP { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int ZIPCode { get; set; }
        public string FlatNumber { get; set; }
    }
}
