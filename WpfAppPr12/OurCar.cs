using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPr12
{
     internal static class OurCar
    {
        public static Cars Car { get; set; }
        public static char TypeCar { get; set; }
        public static string ColorCar { get; set; }

        public static double PriceColor { get; set; }
        public static bool O1 { get; set; }
        public static bool O2 { get; set; }
        public static bool O3 { get; set; }
        public static bool O4 { get; set; }
        public static bool O5 { get; set; }

        public static double PriceOptions { get; set; }
        /*public OurCar(double priceCar, char typeCar, string colorCar, double priceColor, double priceOptions)
        {
            PriceCar = priceCar;
            TypeCar = typeCar;
            ColorCar = colorCar;
            PriceColor = priceColor;
            PriceOptions = priceOptions;
            
        }
        */
   }
    

}
