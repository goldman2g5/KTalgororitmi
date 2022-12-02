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

            var sequence = new Sequence<string>();

            sequence.Build(3);
            sequence.Add("1");

            Console.WriteLine(sequence);

            Set<string> set = sequence;
            Console.WriteLine(set.Min());
            Console.ReadKey();
        }
    }
}
