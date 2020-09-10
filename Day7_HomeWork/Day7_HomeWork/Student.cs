using System;
using System.Collections.Generic;
using System.Text;
namespace Day7_HomeWork
{
    public class Student
    {
        
        public String Name { get; set; }
        public String Surname { get; set; }

        public int _year;

        private int year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    _year = value;
                }
                else if (value > 3)
                {
                    _year = 3;
                }
                else
                {
                    _year = 1;
                }
            }

        }

        public Student(String name, String lastName, int course)
        {
            Name = name;
            Surname = lastName;
            year = course;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Name + " " + Surname + " " + year);
        }
    }
    
    
}
