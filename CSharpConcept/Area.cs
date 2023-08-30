using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unisys.MathConcept
{
    public class Area
    {
        public static double AreaOfCircle(int r)
        {
            double area = 3.14 * r * r;
            return area;
        }

        public static double AreaOfRectangle(double length, double width)
        {
            double area = length * width;
            return area;
        }

        public static double AreaOfSquare(double length)
        {
            double area = length * length;
            return area;
        }

        // if we dont use the "static" keyword it becomes a non static method
        public double AreaOfTriangle(double length , double height)
        {
            double area = 0.5 * length * height;
            return area;
        }

    }
}
