using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__Compilation.Lesson10_OOPBasics
{
    internal class OOPBasics
    {
        public void main()
        {
            int maxStudents = 5, count = 0;
            bool isContinue = true;
            char choice;
            Student[] students = new Student[maxStudents];

            do
            {
                choice = selection();
                switch (choice.ToString().ToUpper())
                {
                    case "A":
                        if (!isFull(count,maxStudents))
                        {
                            Console.WriteLine("ADD NEW STUDENT INFORMATION");
                            addStudent(ref count, students);
                        }
                        else
                        {
                            maxStudentList();
                        }
                        break;
                    case "B":
                        if (!isEmpty(count))
                        {
                            Console.WriteLine("EXISTING STUDENT INFORMATION\n");
                            displayStudentList(count, students);
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        else
                        {
                            emptyStudentList(); 
                        }
                        break;
                    case "C":
                        if (!isEmpty(count))
                        {
                            Console.WriteLine("UPDATE STUDENT INFORMATION\n");
                            displayStudentList(count, students);
                            updateStudent(students);
                        }
                        else
                        {
                            emptyStudentList();
                        }
                        break;
                    case "D":
                        if (!isEmpty(count))
                        {
                            Console.WriteLine("DELETE STUDENT INFORMATION\n");
                            displayStudentList(count, students);
                            deleteStudent(ref count, students);
                        }
                        else
                        {
                            emptyStudentList();
                        }
                        break;
                    case "E":
                        isContinue = false;
                        break;
                } 
            } while (isContinue);


        }
        static char selection()
        {
            Console.WriteLine("STUDENT INFORMATION SYSTEM");
            Console.WriteLine("A.) Add New Student");
            Console.WriteLine("B.) Display Students ");
            Console.WriteLine("C.) Update Student");
            Console.WriteLine("D.) Remove Student");
            Console.WriteLine("E.) Exit\n");
            Console.Write("Choice: ");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\n");
            return choice;
        }
        static void emptyStudentList()
        {
            Console.WriteLine("\nNo Existing Students yet");
            Console.ReadKey();
            Console.WriteLine("\n");
        }
        static void maxStudentList()
        {
            Console.WriteLine("Maximum Number of Students have been reached!");
            Console.WriteLine("Cannot add more students!");
            Console.ReadKey();
            Console.WriteLine("\n");
        }

        static bool isEmpty(int count)
        {
            return count == 0;

        }
        static bool isFull(int count, int maxStudents)
        {
            return count >= maxStudents;

        }

        static void addStudent(ref int count, Student[] students)
        {
            bool isTerminate = false;
            int idNum;
            string name, course;
            Console.Write("Student's Id Number  : ");
            int idNumTemp = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= count; i++)
            {
                if (students[i] == null)
                {
                    break;
                }
                else if (idNumTemp == students[i].idNum)
                {
                    Console.WriteLine("Id Number already Exists!");
                    isTerminate = true;
                    break;
                }
            }

            if (isTerminate)
            {
                Console.ReadKey();
                Console.WriteLine("\n");
                return;
            }
            else idNum= idNumTemp;

            Console.Write("Student's Name       : ");
            name = Console.ReadLine();
            Console.Write("Student's Course     : ");
            course = Console.ReadLine();

            students[count] = new Student(idNum,name,course);
            Console.WriteLine("New student have been successfully added!\n\n");
            count++;
        }
        static void displayStudentList(int count, Student[] students)
        {
            Console.WriteLine("Students List");
            Console.WriteLine("ID #\t\t\tName\t\t\t\tCourse");
            for (int i = 0; i < count; i++)
            {
                students[i].displayStudents();
            }
            Console.WriteLine();
        }
        static void updateStudent(Student[] students)
        {
            Console.Write("Enter the ID# of the Student you want to Update : ");
            int id = Convert.ToInt32(Console.ReadLine());

            int indexToUpdate = -1;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].idNum == id)
                {
                    indexToUpdate = i;
                    break;
                }
            }
            if (indexToUpdate == -1)
            {
                Console.WriteLine("Student with ID# " + id + " not found.");
                return;
            }

            students[indexToUpdate].Update();
        }
        static void deleteStudent(ref int count, Student[] students)
        {
            Console.Write("Enter the ID# of the Student you want to Delete : ");
            int id = Convert.ToInt32(Console.ReadLine());

            int indexToDelete = -1;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null && students[i].idNum == id)
                {
                    indexToDelete = i;
                    break;
                }
            }
            if (indexToDelete == -1)
            {
                Console.WriteLine("Student with ID# " + id + " not found.");
                return;
            }
            for (int i = indexToDelete; i < count - 1; i++)
            {
                students[i] = students[i + 1];
            }
            count--;
            Console.WriteLine("Student removed successfully!\n\n");
        }


    }


}
