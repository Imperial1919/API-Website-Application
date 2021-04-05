using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locomotive_Empeorium
{
    public class Products
    {
        public Products()
        {

        }

        public string CompanyName { get; set; }
        public string LocomotiveName { get; set; }
        public string PowerPlant { get; set; }

        public string Gauge { get; set; }

        public string WheelConfig { get; set; }

        public int ID { get; set; }

        public string Year_Manufactored { get; set; }

        public double Price { get; set; }
    }
}
