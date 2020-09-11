using System;
using System.Collections.Generic;
using System.IO;

namespace Day9_Files
{
    public class File
    {
        
        private const String defaultName = @"~zanegrandi\projects\Day8_Files\Bin\Debug\netcoreapp3.1\";


        public static void Read(String FileName)

        {
            try
            {
                StreamReader sr = new StreamReader(defaultName + FileName);

                String line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

        }

        public static void Write(List<string>lst)

        {
            try
            {
                StreamWriter sw = new StreamWriter("ListTest.txt", true);
                for (int i = 0; i < lst.Count; i++)
                {
                    sw.WriteLine(lst[i]);
                }

                sw.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }


        public static void Read(List<string> lst)

        {
            try
            {
                StreamReader sr = new StreamReader("ListTest.txt");

                String line = sr.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

        }


    }
}
