using System;

namespace Day3_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            Array(int[] arr);

        }

        static void Array(int[] arr)
        {
            int[] Arr = new int[6];
            Random ran = new Random();

            for (int i = 0; i < Arr.Length; i++)
            {
                int rnd = ran.Next();
                Arr[i] = rnd;

               // Console.WriteLine(Arr[i]);
            }

           int temp;

            
            for (int j = 0; j < Arr.Length - 1; j++)
                for (int z = j + 1; z < arr.Length; z++)

                     
                    if (arr[j] < arr[z])
                    {

                        temp = arr[j];
                        arr[j] = arr[z];
                        arr[z] = temp;
                    }

            
            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }




        }
        



    }
}
