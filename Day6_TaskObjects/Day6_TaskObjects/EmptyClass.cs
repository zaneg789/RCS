using System;
using System.Collections.Generic;
using System.Text;
namespace Day6_TaskObjects
{
    public class student
    {
        public String name { get; set; }


        public String surname { get; set; }        
        private int _year;

        public int year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1)
                {
                    _year = 1;
                }
                else if (value > 3)
                {
                    _year = 3;
                }

                else
                {
                    _year = value;
                }

            }
        }

        public void PrintInfo()

        {
            Console.WriteLine(name + " " + surname + " " + year);
        }

        }
}
