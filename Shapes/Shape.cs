using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eighth_lesson.Shapes
{
    public abstract class Shape
    {
      
        public abstract int SideFigure { get; set; }

        public abstract double AreaСalculation();

        public abstract double PerimeterCalculation();
        
    }
}
