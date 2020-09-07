using System;


namespace Day6_TaskObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            student student1 = new student();
            Console.WriteLine("ievadiet studenta vardu!");
            student1.name = Console.ReadLine();
            Console.WriteLine("Ievadiet studenta uzvardu!");
            student1.surname = Console.ReadLine();
            Console.WriteLine("Ievadiet kursu!");
            student1.year = Convert.ToInt32(Console.ReadLine());


            student1.PrintInfo();



        }
    }

}
