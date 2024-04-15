using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Eighth_lesson.Shapes
{
    public class Circle: Rectangle
    {
        public Circle() { }
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius { get; set; }
      

        public override double AreaСalculation()
        {
            //Console.WriteLine($"{3.14 * Radius} - площадь круга");
            return 3.14 * Radius;
        }
       
    }
}
