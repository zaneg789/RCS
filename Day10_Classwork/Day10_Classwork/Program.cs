using System;
using System.Collections.Generic;

namespace Day10_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Task4();

        }

        static void Task4()
        {
            List<int> lst = new List<int>();

            String choice = "";

            while (choice != "0")
            {
                Console.WriteLine("1 - Saskaitit visu skaitlu summu.");
                Console.WriteLine("2- Pievienot sarakstam skaitli");
                Console.WriteLine("3- Dzest skaitli.");
                Console.WriteLine("4- Aprekinat videjo aritmetisko.");
                Console.WriteLine("0- Iziet.");


                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Sum(lst);
                        break;
                    case "2":
                        AddElement(lst);
                        break;
                    case "3":
                        RemoveElement(lst);
                        break;
                    case "4":
                        Average(lst, Sum(lst));
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareiza ievade");
                        break;
                }
            }
        }



        private static double Average(List<int> lstOfElements, int sum)
        {
            double result = sum / lstOfElements.Count;
            return result;
        }



        private static int Sum(List<int> lstOfElements)
        {
            int sum = 0;
            for (int i = 0; i < lstOfElements.Count; i++)
            {
                sum = sum + lstOfElements[i];

            }
            return sum;
        }

        private static void RemoveElement(List<int> lst)
        {
            Console.WriteLine();

            if (lst.Count == 0)
            {
                Console.WriteLine("Saraksts ir tukss!");
                return;
            }

            try
            {
                Console.WriteLine("Kuru elementu velaties dzest?");
                int toDelete = Convert.ToInt32(Console.ReadLine());
                lst.RemoveAt(toDelete);
                FileOperations.Write(lst);
            }
            catch
            {
                Console.WriteLine("Kludaina ievade!");
            }


            Console.WriteLine();
        }

        private static void AddElement(List<int> lst)
        {
            Console.WriteLine();
            Console.WriteLine("Ievadiet elementu!");
            lst.Add(Convert.ToInt32(Console.ReadLine()));
            FileOperations.Write(lst);

        }
    }
}

