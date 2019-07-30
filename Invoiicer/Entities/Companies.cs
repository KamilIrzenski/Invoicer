using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoicer.Entities
{
    public class Companies
    {

        [Key]
        public int FirmID { get; set; }
        public string NameCompanies { get; set; }
        public string NIP { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIPCode { get; set; }
        public int FlatNumber { get; set; }
        

    }
}
