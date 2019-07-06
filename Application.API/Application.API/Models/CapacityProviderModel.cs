using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIProject.Models
{
    public class CapacityProviderModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string contract_number { get; set; }
    }
}