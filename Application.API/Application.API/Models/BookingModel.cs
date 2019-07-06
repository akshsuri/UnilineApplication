using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace APIProject.Models
{
    public class BookingModel
    { 
        public int id { get; set; }
        public string object_name { get; set; }
        public int capacity_provider_id { get; set; }
        public DateTime date_from { get; set; }
        public DateTime date_to { get; set; }
        public Boolean is_active { get; set; }
        public float amount { get; set; }
        public string currency { get; set; }
        public string comment { get; set; }
    }
}