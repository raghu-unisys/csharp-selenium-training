using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Demo2Logic
    {
        public static void Main(String[] args)
        {
            // Task 1 - Day 1 -
            Console.WriteLine("Enter percentage : ");
            float percentage = float.Parse(Console.ReadLine());
            char grade = 'A';

            if (percentage >= 90)
                grade = 'A';
            else if (percentage >= 80)
                grade = 'B';
            else if (percentage >= 70)
                grade = 'C';
            else if (percentage >= 60)
                grade = 'D';
            else if (percentage >= 45)
                grade = 'E';
            else
                grade = 'F';

            Console.WriteLine(grade);
        }
    }
}
