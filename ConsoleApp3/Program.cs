﻿using System;
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
            Console.WriteLine($"Len: {Ls[0].GetLength()}");
            Console.WriteLine();
            
            Ls.RemoveAt(2);

            Console.WriteLine(Ls);
            Console.WriteLine($"Len: {Ls[0].GetLength()}");
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
