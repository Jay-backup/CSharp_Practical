using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Practical_7.OCP
{
   
    public class BeforeOCP
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Radius { get; set; }
        public string Type { get; set; }
        double result { get; set; }

        public double Area()
        {
           if(this.Type == "Circle")
           {
                 result = Math.PI* Radius *Radius;
            }
           else if(this.Type == "Ractangle")
           {
                result = Width * Height;
            }
            return result;

        }

    }

}
