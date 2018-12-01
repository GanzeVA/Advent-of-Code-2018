using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_2018
{
    class Program
    {
        static public string filesPath = Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory)).FullName).FullName + @"\inputs";

        static void Main(string[] args)
        {
            Console.WriteLine($"Day 1 - Part 1: {Day1.Day1Part1()}");
            Console.WriteLine($"Day 1 - Part 2: {Day1.Day1Part2()}");
        }
    }
}
