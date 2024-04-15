using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eighth_lesson.Shapes
{
    public class Rectangle: Triangle
    {
        public Rectangle()
        { }
        public Rectangle(int sideFigure, int sideFigureSecond)
        { 
            this.SideFigure = sideFigure;
            this.SideFigureSecond = sideFigureSecond;
        }

        public override int SideFigure { get; set; }
        public int SideFigureSecond {  get; set; }

        public override double AreaСalculation()
        {
            //Console.WriteLine($"{SideFigure*SideFigureSecond} - площадь прямоугольника");
            return SideFigure* SideFigureSecond;
        }

        public override double PerimeterCalculation()
        {
            //Console.WriteLine($"{2*(SideFigure + SideFigureSecond)} - периметр прамоугольника");
            return 2 * (SideFigure + SideFigureSecond);
        }
    }
}
