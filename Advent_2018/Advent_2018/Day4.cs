using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_2018
{
    class Day4
    {
        static public int Day4Part1()
        {
            StreamReader sr = new StreamReader(Program.filesPath + @"\day4.txt");
            List<Info> infos = new List<Info>();
            while (!sr.EndOfStream)
            {
                infos.Add(new Info(sr.ReadLine()));
            }
            infos.Sort();
            for (int i = 0; i < infos.Count; i++)
            {

            }
            return 0;
        }

        static public int Day4Part2()
        {
            return 0;
        }

        public enum InfoType
        {
            beginsShift, fallsAsleep, wakesUp
        }

        public class Info : IComparable<Info>
        {
            public int Year { get; set; }
            public int Month { get; set; }
            public int Day { get; set; }
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int GuardId { get; set; }
            public InfoType InfoType { get; set; }

            public Info(string s)
            {
                Year = int.Parse(s.Substring(1, 4));
                Month = int.Parse(s.Substring(6, 2));
                Day = int.Parse(s.Substring(9, 2));
                Hours = int.Parse(s.Substring(12, 2));
                Minutes = int.Parse(s.Substring(15, 2));
                string type = s.Substring(19, 5);
                if (type == "Guard")
                {
                    InfoType = InfoType.beginsShift;
                    GuardId = int.Parse(s.Substring(26, 4));
                }
                else if (type == "wakes")
                    InfoType = InfoType.wakesUp;
                else if (type == "falls")
                    InfoType = InfoType.fallsAsleep;
            }

            public int CompareTo(Info other)
            {
                if (Year.CompareTo(other.Year) != 0)
                    return Year.CompareTo(other.Year);
                if (Month.CompareTo(other.Month) != 0)
                    return Month.CompareTo(other.Month);
                if (Day.CompareTo(other.Day) != 0)
                    return Day.CompareTo(other.Day);
                if (Hours.CompareTo(other.Hours) != 0)
                    return Hours.CompareTo(other.Hours);
                if (Minutes.CompareTo(other.Minutes) != 0)
                    return Minutes.CompareTo(other.Minutes);
                return 0;
            }
        }
    }
}
