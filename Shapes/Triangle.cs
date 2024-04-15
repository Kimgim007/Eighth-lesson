using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eighth_lesson.Shapes
{
    public class Triangle : Shape
    {
        public Triangle() { }
        public Triangle(int sideFigure, int hideFigure)
        {
            this.SideFigure = sideFigure;
            this.HideFigure = hideFigure;
        }

        public override int SideFigure { get; set; }
        public int HideFigure { get; set; }
        public override double AreaСalculation()
        {

            //Console.WriteLine($"{0.5 * SideFigure * HideFigure} - площадь треугольника");

            return 0.5 * SideFigure * HideFigure;
        }

        public override double PerimeterCalculation()
        {
            //Console.WriteLine($"{3 * SideFigure} - периметр треугольника");
            return 3 * SideFigure;
        }
    }
}
