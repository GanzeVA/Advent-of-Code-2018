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
            //Console.WriteLine($"Day 1 - Part 1: {Day1.Day1Part1()}");
            //Console.WriteLine($"Day 1 - Part 2: {Day1.Day1Part2()}");
            //Console.WriteLine($"Day 2 - Part 1: {Day2.Day2Part1()}");
            //Console.WriteLine($"Day 2 - Part 2: {Day2.Day2Part2()}");
            //Console.WriteLine($"Day 3 - Part 1: {Day3.Day3Part1()}");
            //Console.WriteLine($"Day 3 - Part 2: {Day3.Day3Part2()}");
            Console.WriteLine($"Day 4 - Part 1: {Day4.Day4Part1()}");
            Console.WriteLine($"Day 4 - Part 2: {Day4.Day4Part2()}");
        }
    }
}
