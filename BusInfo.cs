using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Assignment_2.Models
{
    [Table("BusInfo")]
    public class BusInfo
    {
        public int BusId { get; set; }
        public string BoardingPoint { get; set; }
        public DateTime TravelDate { get; set; }
        public double Amount { get; set; }
        public int Rating { get; set; }
    }
}