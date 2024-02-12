using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace C__Compilation.Lesson8_Arrays
{
    internal class Arrays
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

            do { 
                Console.WriteLine("STUDENT INFORMATION SYSTEM");
                Console.WriteLine("A.) Add New Student");
                Console.WriteLine("B.) Display Students ");
                Console.WriteLine("C.) Update Student");
                Console.WriteLine("D.) Remove Student");
                Console.WriteLine("E.) Exit");
                Console.Write("Choice: ");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n");

                switch (choice.ToString().ToUpper()) {
                    case "A":
                        if(count < maxStudents) 
                        {

                            bool isTerminate = false;
                            Console.WriteLine("Enter the Student's Information");
                            Console.Write("Student's Id Number  : ");
                            idNumTemp = Convert.ToInt32(Console.ReadLine());
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
                                break;
                            }else idNum[count] = idNumTemp;

                            Console.Write("Student's Name       : ");
                            name[count] = Console.ReadLine();
                            Console.Write("Student's Course     : ");
                            course[count] = Console.ReadLine();
                            Console.WriteLine("New student have been successfully added!\n\n");
                            count++;
                        
                        }
                        else
                        {
                            Console.WriteLine("Maximum Number of Students have been reached!");
                            Console.WriteLine("Cannot add more students!");
                            Console.ReadKey();
                            Console.WriteLine("\n");

                        }
                        break;
                    case "B":
                        if (count > 0)
                        {
                            Console.WriteLine("EXISTING STUDENT INFORMATION\n");
                            Console.WriteLine("Students List");
                            Console.WriteLine("ID #\t\t\tName\t\t\t\tCourse");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine(idNum[i] + "\t\t\t" + name[i] + "\t\t\t" + course[i]);
                            }
                            Console.WriteLine("\n");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("\nNo Existing Students yet");
                            Console.ReadKey();
                            Console.WriteLine("\n");
                        }
                        break;
                    case "C":
                        if (count > 0)
                        {
                            Console.WriteLine("UPDATE STUDENT INFORMATION\n");
                            Console.WriteLine("Students List");
                            Console.WriteLine("ID #\t\t\tName\t\t\t\tCourse");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine(idNum[i] + "\t\t\t" + name[i] + "\t\t\t" + course[i] + "\t\t") ;
                            }

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
                        else
                        {
                            Console.WriteLine("\nNo Existing Students yet");
                            Console.ReadKey();
                            Console.WriteLine("\n");
                        }
                        break;
                    case "D":
                        if (count > 0)
                        {
                            Console.WriteLine("DELETE STUDENT INFORMATION\n");
                            Console.WriteLine("Students List");
                            Console.WriteLine("ID #\t\t\tName\t\t\t\tCourse");
                            for (int i = 0; i < count; i++)
                            {
                                Console.WriteLine(idNum[i] + "\t\t\t" + name[i] + "\t\t\t" + course[i]);
                            }

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
                        else
                        {
                            Console.WriteLine("\nNo Existing Students yet");
                            Console.ReadKey();
                            Console.WriteLine("\n");
                        }
                        break;
                    case "E":
                        isContinue = false;
                        break;
                }
            } while (isContinue);

        }
    }
}
