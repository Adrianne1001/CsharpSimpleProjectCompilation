using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson6_SwitchStatements
{
    internal class SwitchStatements
    {
        public void main()
        {

            double num1, num2, result;
            char choice;


            Console.WriteLine("Basic Calculator");
            Console.Write("Enter the First Number   : ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Second Number  : ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nWhat do you want to be performed? ");
            Console.WriteLine("( + ) Addition");
            Console.WriteLine("( - ) Subtraction");
            Console.WriteLine("( * ) Multiplication");
            Console.WriteLine("( / ) Division");
            Console.WriteLine("( % ) Modulus");
            Console.WriteLine("( ^ ) Exponentiation");

            Console.Write("Select Math Operator     : ");
            choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '+':
                    Console.WriteLine("Sum : " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Difference : " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Product : " + (num1 * num2));
                    break;
                case '/':
                    Console.WriteLine("Quotient : " + (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine("Remainder : " + (num1 % num2));
                    break;
                case '^':
                    Console.WriteLine("Result : " + Math.Pow(num1,num2));
                    break;
                default:
                    Console.WriteLine("Invalid Input! ");
                    break;
            }





        }
    }
}
