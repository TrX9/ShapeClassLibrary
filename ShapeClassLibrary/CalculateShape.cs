using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeClassLibrary
{
    public class CalculateShape
    {
        public static double GetArea(IShape shape)
        {
            return shape.CalculateArea();
        }
    }
}
