using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson2_Variables_DataTypes
{
    class VariablesDataTypes
    {
        public void main()
        {
            char gender = 'M';
            string fullName = "Adrianne John Basuel";
            int age = 22;
            float height = 162.3f;
            double weight = 81.36;
            bool isOverweight = true;

            int typeCastedWeight = (int)weight;

            Console.WriteLine("Self Introduction");
            Console.WriteLine("Hi, Good Day! I am " + fullName);
            Console.WriteLine("I am " + age + " years old");
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Height : " + height + " Weight : " + weight);
            Console.WriteLine("Am I chubby? " + isOverweight);
            Console.WriteLine("Type Casted Weight : " + typeCastedWeight);


            Console.WriteLine("\nDisplay Data Types");
            Console.WriteLine("Gender             : " + gender.GetType());
            Console.WriteLine("Full Name          : " + fullName.GetType());
            Console.WriteLine("Age                : " + age.GetType());
            Console.WriteLine("Height             : " + height.GetType());
            Console.WriteLine("Weight             : " + weight.GetType());
            Console.WriteLine("IsOverweight       : " + isOverweight.GetType());
            Console.WriteLine("Type Casted Weight : " + typeCastedWeight.GetType());
        }
    }
}
