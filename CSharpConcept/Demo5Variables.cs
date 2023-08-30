using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    internal class Demo5Variables
    {
        // static variables or class variables
        public static int aS = 10;
        public static int bS = 20;

        // non static varibales or instance variables
        public int aNS = 10;
        public int bNS = 20;

        public static void Main5(String[] args)
        {
            Demo5Variables.aS = 1000;
            Console.WriteLine(Demo5Variables.aS);
            Console.WriteLine(Demo5Variables.bS);

            Demo5Variables demo5Obj = new Demo5Variables();
            demo5Obj.aNS = 1000;
            Console.WriteLine(demo5Obj.aNS);
            Console.WriteLine(demo5Obj.bNS);



        }
    }
}
