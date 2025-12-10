using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppPr12
{
    internal class Options
    {
       
            public string name { get; }
            public double price { get; }
            public Options(string name, double price)
            {
                this.name = name;
                this.price = price;
            }
        
    }
    
}
