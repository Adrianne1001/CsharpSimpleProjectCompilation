using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Compilation.Lesson9_Functions
{
    internal class Functions
    {
        public void main()
        {
            char choice;
            int count = 0, maxStudents = 5;
            int idNumTemp;
            int[] idNum = new int[maxStudents];
            string[] name = new string[maxStudents];
            string[] course = new string[maxStudents];
            string response;
            bool isContinue = true;

            do
            {
                choice = selection();

                switch (choice.ToString().ToUpper())
                {
                    case "A":
                        if (!isFull(count, maxStudents))
                        {
                            Console.WriteLine("ADD NEW STUDENT INFORMATION");
                            addStudent(ref count, idNum, name, course);
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
                            displayStudentList(count, idNum, name, course);
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
                            displayStudentList(count, idNum, name, course);
                            updateStudent(idNum, name, course);
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
                            displayStudentList(count, idNum, name, course);
                            deleteStudent(ref count, idNum, name, course);
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


        //Methods or Functions Implementation
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
        static void displayStudentList(int count, int[] idNum, string[] name, string[] course)
        {
            Console.WriteLine("Students List");
            Console.WriteLine("ID #\t\t\tName\t\t\t\tCourse");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(idNum[i] + "\t\t\t" + name[i] + "\t\t\t" + course[i] );
            }
            Console.WriteLine();
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

        static void addStudent( ref int count, int[] idNum, string[] name, string[] course)
        {
            bool isTerminate = false;
            Console.Write("Student's Id Number  : ");
            int idNumTemp = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= count; i++)
            {
                if (idNumTemp == idNum[i])
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
            else idNum[count] = idNumTemp;
            Console.Write("Student's Name       : ");
            name[count] = Console.ReadLine();
            Console.Write("Student's Course     : ");
            course[count] = Console.ReadLine();
            Console.WriteLine("New student have been successfully added!\n\n");
            count++;
        }
        static void updateStudent(int[] idNum, string[] name, string[] course)
        {
            Console.Write("Enter the ID# of the Student you want to Update : ");
            int id = Convert.ToInt32(Console.ReadLine());
            int indexToUpdate = Array.IndexOf(idNum, id);
            Console.Write("Student's Id Number  : ");
            idNum[indexToUpdate] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Student's Name       : ");
            name[indexToUpdate] = Console.ReadLine();
            Console.Write("Student's Course     : ");
            course[indexToUpdate] = Console.ReadLine();
            Console.WriteLine("Student have been successfully Updated!\n\n");
        }
        static void deleteStudent(ref int count, int[] idNum, string[] name, string[] course)
        {
            Console.Write("Enter the ID# of the Student you want to Delete : ");
            int id = Convert.ToInt32(Console.ReadLine());
            int indexToDelete = Array.IndexOf(idNum, id);
            for (int i = indexToDelete; i < count - 1; i++)
            {
                idNum[i] = idNum[i + 1];
                name[i] = name[i + 1];
                course[i] = course[i + 1];
            }
            count--;
            Console.WriteLine("Student removed successfully!\n\n");
        }

        static bool isEmpty(int count)
        {
            return count == 0;

        }
        static bool isFull(int count, int maxStudents)
        {
            return count >= maxStudents;

        }



    }
}
