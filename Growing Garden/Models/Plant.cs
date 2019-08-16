using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Growing_Garden.Models
{
    public class Plant
    {
        public string CommonName { get; set; }
        public string SciName { get; set; }
        public string BedLocation { get; set; }
        public string PlantTime { get; set; }
        public string BloomTime { get; set; }
    }
}