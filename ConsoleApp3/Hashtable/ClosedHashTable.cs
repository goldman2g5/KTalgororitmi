using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Hashtable
{
    internal class ClosedHashTable : HashTable
    {
        new Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        public override void Add(int value)
        {
            if (dict.ContainsKey((11 * value + 4) % 9))
            {
                dict[(11 * value + 4) % 9].Add(value);
                return;
            }
            dict.Add((11 * value + 4) % 9, new List<int>() { value });
        }

        public override void Print()
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {string.Join(" ", item.Value)}");
            }
        }
    }
}
