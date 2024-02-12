using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson3_BasicInput_Output
{
    internal class BasicIO
    {
        public void main()
        {
            char gender;
            string fullName;
            int age;
            float height;
            double weight;
            bool isOverweight;

            Console.WriteLine("Self Introduction (Input Version)");
            Console.Write("Enter your Full Name  : ");
            fullName = Console.ReadLine();
            Console.Write("Enter your Age        : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Gender     : ");
            gender = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter your Height     : ");
            height = Convert.ToSingle(Console.ReadLine());
            Console.Write("Enter your Weight     : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Are you Overweight?   : ");
            isOverweight = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Hi, Good Day! I am " + fullName);
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Height : " + height + " Weight : " + weight);
            Console.WriteLine("Am I chubby? " + isOverweight);

        }
    }
}
