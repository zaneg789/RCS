using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

        }
            
         static void Array(int [] arr)
         {
            int[] Arr = new int[6];
            Random ran = new Random();

            for (int i = 0; i < Arr.Length; i++)
            {
                int rnd = ran.Next(100);
                Arr[i] = rnd;
            }
            Array.Sort(Arr);
            foreach(int value in Arr)
            {
                    Console.Write(value + " "); 
            }
         }




        }
    }
}
