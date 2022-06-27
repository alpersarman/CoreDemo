using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AbuotId { get; set; }
        public string AbuotDetails1 { get; set; }
        public string AbuotDetails2 { get; set; }
        public string AbuotImage1 { get; set; }
        public string AbuotImage2 { get; set; }
        public string AbuotMapLocation { get; set; }
        public bool AbuotStatus { get; set; }
    }
}
