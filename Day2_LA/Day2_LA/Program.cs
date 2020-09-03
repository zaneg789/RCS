using System;

namespace Day2_LA
{
    class Program
    {
        static void Main(string[] args)
        {

            Task3();

        }

        static void RandomSample()
        {
            Random rand = new Random();
            int Max = 0;


            for (int i = 0; i < 10; i++)
            {
                int x = rand.Next(60);
                Console.WriteLine(x);


                if (x > Max)
                {
                    Max = x;
                }
            }

            Console.WriteLine("Max: " + Max);


        }

        static void Task2()
        {
            String line = "";

            for (int i = 0; i < 4; i++)
            {

                String symbol = "*";
                line = line + symbol;

                Console.WriteLine(line);

            }
        }

        static void Task2_extra()
        {

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4 - i; j++)
                {
                    Console.WriteLine("*");
                }
                //   Console.WriteLine();


            }


        }

        static void Task3()
        {

            int[] a = new int[5];


            for (int i = 0; i < 5; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                a[i] = value;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(a[i]);
            }

            Console.WriteLine();


           for (int i = 4; i > 0 - 1; i--)
            {
                Console.Write(a[i]);
            }

        }

        static void Task3_Extra()
        {
            int[] a = new int[5];

            Console.WriteLine("Ievadiet 5 skaitlus!");


            for (int i = 0; i < 5; i++)
            {
                int value = Convert.ToInt32(Console.ReadLine());
                a[i] = value;
            }


                for (int j = 0; j < 5; j++)
                {
                 Console.Write(a[i]);
                }
            }

           // int[] a2 = new int[6];
            //Array.Copy(a, a2, 5);

            //Console.WriteLine(int[]a2);
            //Console.WriteLine("Ievadiet vienu skaitli!");

           // int i = Convert.ToInt32(Console.ReadLine());
            //a2[5] = i;

            //Console.WriteLine(int[]a2);





        




        
    

    }
}
        



    

