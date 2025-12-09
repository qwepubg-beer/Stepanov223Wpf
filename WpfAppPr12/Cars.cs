using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPr12
{
    class Cars
    {
        public string CarName {get;}
        public char Type { get; }
        public double Price { get; set; }
        public string Color { get; set; }
        public Cars(string carName, char TypeMotor, double price, string color="")
        { CarName = carName; Type = TypeMotor; Price = price; Color = color; }

    }
}
