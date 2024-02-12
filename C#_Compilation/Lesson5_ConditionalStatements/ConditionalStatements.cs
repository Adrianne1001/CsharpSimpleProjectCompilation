using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson5_ConditionalStatements
{
    internal class ConditionalStatements
    {
        public void main()
        {
            double a, b, c;
            Console.WriteLine("TRIANGLE IDENTIFIER\n");
            Console.Write("First Side Measurement   : ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Second Side Measurement  : ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Third Side Measurement   : ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


             if ((a + b) < c || (b + c) < a || (c + a) < b)
            {
                Console.WriteLine("Classification : Invalid triangle");
            }else if (a == b && b == c)
            {
                Console.WriteLine("Classification : Equilateral");
            }else if( a == b || b == c || a == c )
            {
                Console.WriteLine("Classification : Isosceles");
            }else {
                Console.WriteLine("Classification : Scalene");
            }

        }
    }
}
