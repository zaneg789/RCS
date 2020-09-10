using System;
using System.Collections.Generic;

namespace Day7_HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Student();
        }

        static void Student()
        {
            List<Student> lstOfStudents = new List<Student>();

            Console.WriteLine("What action would you like to take?");

            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("1- Add Student");
                Console.WriteLine("2- Delete Student");
                Console.WriteLine("3- Print Info");
                Console.WriteLine("0- Exit");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Add(lstOfStudents);
                        break;
                    case "2":
                        Remove(lstOfStudents);
                        break;
                    case "3":
                        PrintInfo(lstOfStudents);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }

        }

        private static void PrintInfo(List<Student> lstOfStudents)
        {
            for (int i = 0; i < lstOfStudents.Count; i++)
            {
                lstOfStudents[i].PrintInfo();
            }
        }

        private static void Remove(List<Student> lstOfStudents)
        {
            Console.WriteLine("Which element would you like to delete?");
            int toDelete = Convert.ToInt32(Console.ReadLine());
            lstOfStudents.RemoveAt(toDelete);
        }

        private static void Add(List<Student> lstOfStudents)
        {
            Console.WriteLine("Enter name!");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Surname!");
            String surname = Console.ReadLine();

            Console.WriteLine("Enter year!");
            int year = Convert.ToInt32(Console.ReadLine());

            lstOfStudents.Add(new Student(name, surname, year));
        }
    }
}
