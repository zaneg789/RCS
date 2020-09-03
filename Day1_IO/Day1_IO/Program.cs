using System;

namespace Day1_IO
{
    class Program
    {
        static void Main(string[] args)
        {

            Task03_3(3);


        }


        static void Task01()
        {

            Console.WriteLine("Ievadiet skaitli!");


            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 5)
            {
                Console.WriteLine("**");
            }
            else
            {
                Console.WriteLine("*");
            }


        }

        static void Task02()
        {

            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ievadiet skaitli!");
                int number = Convert.ToInt32(Console.ReadLine());

                sum = sum + number;
            }

            Console.WriteLine("Skaitlu summa ir " + sum);

        }

        static void Task03(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Skaitlis ir nulle.");
            }
            else
            {
                if (n < 0)
                {
                    Console.WriteLine("Skaitlis ir negativs.");
                }
                else
                {
                    Console.WriteLine("Skaitlis ir pozitivs");
                }



            }
        }

        static void Task03_2(int n)
        {

            Console.WriteLine(n > 0);
        }

        static void Task03_3(int n)
        {
            if (n < 0)
            {
                Console.WriteLine("Kluda!");
            }

            Console.WriteLine("Ludzu, ievadiet " + n + " skaitlus!");


            int sum = 0;

            for (int i = 0; i < n + 1; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                sum = sum + x;

            }

            Console.WriteLine("Tavu ievadito skaitlu summa ir: " + sum);

        }

        static int Power(int number, int pow);
        {
        int result = 1;

        for(int i = 0; i < pow; i++)
            {
            result *= number;

            }

           Console.WriteLine(result);
        }

 
       
        
    }
}
    
            
            
                
                    
        
        
    

