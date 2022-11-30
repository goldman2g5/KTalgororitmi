using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Ls = new LinkedList<int>(1);

            Ls.Add(2);
            Ls.Add(3);

            Console.WriteLine(Ls);

            Ls.Select(x => x * 2);
            Console.WriteLine(Ls);

            Console.ReadLine();

        }
    }
}
