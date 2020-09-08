using System;
using System.Collections.Generic;
using System.Text;
namespace Day7_Objects
{
    public class Student
    {
        public String name { get; set; }
        public String surname { get; set; }
        public String year { get; set; }

        public Student(String name, String surname, String year)
        {
            this.name = name;
            this.surname = surname;
            this.year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine(name + " " + surname + " " + year);
        }
    }

}

