using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.Sequence;
using ConsoleApp3.Sequense;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            //var Ls = new LinkedList<int>(1);

            //Ls.Add(2);
            //Ls.Add(3);

            //Console.WriteLine(Ls);
            //Console.WriteLine($"Len: {Ls[0].GetLength()}");
            //Console.WriteLine();
            
            //Ls.RemoveAt(2);

            //Console.WriteLine(Ls);
            //Console.WriteLine($"Len: {Ls[0].GetLength()}");
            //Console.WriteLine();

            //Console.ReadLine();
            #endregion

            var sequence = new Sequence<int>();

            sequence.Build(5);
            sequence.Add(1);

            Console.WriteLine(sequence);

            Set<int> set = sequence;
            Console.WriteLine(set);
            Console.WriteLine(set.Min());
            Console.WriteLine(set.Max());
            Console.WriteLine(string.Join(", ", set.Where(x => x > 1)));
            Console.ReadKey();
        }
    }
}
