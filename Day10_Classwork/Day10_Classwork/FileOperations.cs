using System;
using System.Collections.Generic;
using System.IO;

namespace Day10_Classwork
{
    class FileOperations
    {
        private const String defaultPath = @"~zanegrandi\projects\Day10_Classwork_Files\Bin\Debug\netcoreapp3.1\";
        private const String filename = "Test.txt";


        public static List<int> Read()
        {
            List<int> lstOfElements = new List<int>();
            try
            {

                StreamReader sr = new StreamReader(defaultPath + filename);


                String line = sr.ReadLine();

                while (line != null)
                {
                    lstOfElements.Add(Convert.ToInt32(line));
                    line = sr.ReadLine();
                }
                sr.Close();
            }
            catch
            {
                Console.WriteLine("Neizdevas nolasit failu!");
            }

            return lstOfElements;
        }

        public static void Write(List<int> lst)
        {
                try
                {
                    StreamWriter sw = new StreamWriter(defaultPath + filename);
                    sw.WriteLine(Convert.ToInt32(Console.ReadLine()));
                }

                catch
                {
                    Console.WriteLine("Neizdevas ierakstit faila!");
                }
            
        }
    }
}