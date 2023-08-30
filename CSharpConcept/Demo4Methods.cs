using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unisys.MathConcept;

namespace CSharpConcept
{
    internal class Demo4Methods
    {
        public static void Main4(string[] args)
        {
            Console.WriteLine(Area.AreaOfSquare(25));
            Console.WriteLine(Area.AreaOfRectangle(25, 50));
            Console.WriteLine(Area.AreaOfCircle(25));

            // to be able to use non static method we must use object of the class it is of
            Area areaObj = new Area();
            Console.WriteLine(areaObj.AreaOfTriangle(25, 50));



        }
    }
}
