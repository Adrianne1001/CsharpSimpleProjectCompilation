using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson10_OOPBasics
{
    internal class Student
    {
        //object Attributes
        public int idNum;
        public string name, course;

        //Constructor
        public Student(int idNum, string name, string course)
        {
            this.idNum = idNum;
            this.name = name;
            this.course = course;
        }

        //object method
        public void displayStudents()
        {
           Console.WriteLine(idNum + "\t\t\t" + name + "\t\t\t" + course);
        }
        public void Update()
        {
            Console.Write("Student's Updated Id Number  : ");
            idNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student's Updated Name       : ");
            name = Console.ReadLine();
            Console.Write("Student's Updated Course     : ");
            course = Console.ReadLine();
            Console.WriteLine("Student has been successfully Updated!\n\n");
        }
    }
}
