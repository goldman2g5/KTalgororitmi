using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Character
    {
        public int Id;
        public string Name;
        public double WinCount;
        public double MatchCount;

        public Character(int id, string name, double winCount, double matchCount)
        {
            Id = id;
            Name = name;
            WinCount = winCount;
            MatchCount = matchCount;
        }
    }
}
