using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson4_Operators_Expressions
{
    internal class OperatorsExpressions
    {
        public void main()
        {
            double weight, height, bmi;
            int num1, num2;
            string remarks;

            Console.WriteLine("Simple BMI Calculator");
            Console.Write("Enter your Height  : ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your Weight  : ");
            weight = Convert.ToDouble(Console.ReadLine());

            bmi = weight / (Math.Pow(height, 2));
            Console.WriteLine("\nBody Mass Index    : " + bmi);
            remarks = (bmi < 25) ? "You're Healthy" : "You are too fat!";
            Console.WriteLine("Remarks : " + remarks);


            Console.WriteLine("\n\nSimple Arithmetic Calculator!");
            Console.WriteLine("Input 2 Numbers!");
            Console.Write("\nFirst Number    : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second Number    : ");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\nRESULTS: ");
            Console.WriteLine("Sum         : " + (num1 + num2) );
            Console.WriteLine("Difference  : " + (num1 - num2));
            Console.WriteLine("Product     : " + (num1 * num2));
            Console.WriteLine("Quotient    : " + (num1 / num2));
            Console.WriteLine("Modulus     : " + (num1 % num2));

        }
    }
}
