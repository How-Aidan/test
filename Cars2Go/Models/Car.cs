using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars2Go.Models
{
    public class Car
    {
        public string RegNumID { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public decimal Mileage { get; set; }
    }
}
