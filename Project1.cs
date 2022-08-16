using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Project1
{
    class RainbowSchoolSystem
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\Shubham\Simplilearn\RainbowSchoolData.txt";
            List<string> list = new List<string>();
            list=File.ReadAllLines(path).ToList();

            foreach(String line in list)
            {
                Console.WriteLine(line);
            }
        } 
    }
}