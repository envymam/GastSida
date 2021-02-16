using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaSharpHotel_Gäst.Models
{
    public class Guest
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string street_Adress { get; set; }
        public int postalCode { get; set; }
        public string city { get; set; }
        public int phonenumber { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public string e_Mail { get; set; }
        public string password { get; set; }
    }
}
