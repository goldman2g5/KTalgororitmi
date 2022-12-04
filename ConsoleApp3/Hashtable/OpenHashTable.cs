using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Hashtable
{
    internal class OpenHashTable : HashTable
    {
        public override void Add(int value)
        {
            int key = (11 * value + 4) % 9;
            while (dict.ContainsKey(key))
                key++;
            dict.Add(key, value);
        }

        public override void Print()
        {
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key}  {item.Value}");
            }
        }
    }
}
