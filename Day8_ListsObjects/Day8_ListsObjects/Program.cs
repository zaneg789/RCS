using System;
using System.Collections.Generic;

namespace Day8_ListsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Day8_Task1();
        }

        static void Day8_Task1()
        { 

        List<Taisnsturis> lstOfTaisnsturis = new List<Taisnsturis>();


            for (int i = 0; i < 10; i++)
            {
                
                int sideA = 0;
                int sideB = 0;
                try
                {
                   Console.WriteLine("Please enter the length of the side a! ");
                   sideA = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter the length of the side b! ");
                    sideB = Convert.ToInt32(Console.ReadLine());
                    if (sideA < 1 || sideB < 1)
                    {
                        Console.WriteLine("Negativs skaitlis!");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Nav pareiza ievade.");
                    continue;
                }
                

            


                lstOfTaisnsturis.Add(new Taisnsturis(sideA, sideB));
            }

}
}
}
