using System;
using System.Collections.Generic;

namespace Day9_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kuru failu velaties atvert?");
            // String FileName = Console.ReadLine();

           // File.Read(FileName);

            List<String> lst = new List<String>();

            lst.Add("aaa");
            lst.Add("bbb");
            lst.Add("ccc");
            lst.Add("ddd");

            File.Write(lst);

            File.Read(lst);
        }
    }
}
