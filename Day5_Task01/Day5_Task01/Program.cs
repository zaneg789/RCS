using System;

namespace Day5_Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first digit!");
            Double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What action do you want to take?");
            String action = Console.ReadLine();
            Console.WriteLine("Please enter the second digit!");
            Double b = Convert.ToDouble(Console.ReadLine());


            switch (action)
            {
                case "+":
                    Console.WriteLine(Calculator.Sum(a, b));
                    break;
                case "-":
                    Console.WriteLine(Calculator.Sub(a, b));
                    break;
                case "*":
                    Console.WriteLine(Calculator.Multiplication(a, b));
                    break;
                case "/":
                    Console.WriteLine(Calculator.Div(a, b));
                    break;
            }  


        }


    }
}
