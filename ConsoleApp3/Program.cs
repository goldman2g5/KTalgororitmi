using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3.DUPLICATES;
using ConsoleApp3.Hashtable;
using ConsoleApp3.Sequence;
using ConsoleApp3.Sequense;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void PrintLs(IEnumerable ls)
            {
                foreach (var i in ls)
                {
                    Console.WriteLine(i);
                }
            }


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



            #region Sequence/Set
            //var sequence = new Sequence<int>();

            //sequence.Build(5);
            //sequence.Add(1);

            //Console.WriteLine(sequence);
            //// Set_from_Sequence
            //Set<int> set = sequence;
            //Console.WriteLine(set);
            //// минимальный / максемальный элемент
            //Console.WriteLine(set.Min());
            //Console.WriteLine(set.Max());
            //// элемент больше k
            //Console.WriteLine(string.Join(" ", set.Where(x => x > 1)));
            //Console.ReadKey();
            #endregion

            #region Duplicates

            //List<int> ls1 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> ls2 = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3 };
            //List<Action> fns = new List<Action>
            //{
            //    () => Duplicates.BruteForce(),
            //    () => Duplicates.LogTime(),
            //    () => Duplicates.LinearTime()
            //};

            //foreach (var fn in fns)
            //{
            //    var sw = new Stopwatch();
            //    sw.Start();
            //    fn();
            //    sw.Stop();
            //    Console.WriteLine($"{fn.Method.Name} - {sw.ElapsedMilliseconds}");
            //}
            //Console.ReadKey();

            #endregion

            #region Sort
            //List<Character> ls = new List<Character>()
            //{
            //    new Character(1, "Amber", 100, 300),
            //    new Character(2, "Lisa", 45, 100),
            //    new Character(3, "Venti", 300, 450),
            //    new Character(-1, "Raiden", 60, 100),
            //    new Character(-2, "Miko", 50, 70),
            //};

            //List<Character> SortByWinCount(List<Character> ls)
            //{
            //    int left = 0;
            //    int right = ls.Count - 1;
            //    int i = left, j = right;
            //    Character pivot = ls[right / 2];

            //    while (i <= j)
            //    {
            //        while (ls[i].WinCount > pivot.WinCount)
            //        {
            //            i++;
            //        }

            //        while (ls[j].WinCount < pivot.WinCount)
            //        {
            //            j--;
            //        }

            //        if (i > j) continue;

            //        (ls[i], ls[j]) = (ls[j], ls[i]);

            //        i++;
            //        j--;
            //    };

            //    return ls;
            //}

            //List<Character> SortByName(List<Character> ls)
            //{
            //    int left = 0;
            //    int right = ls.Count - 1;
            //    int i = left, j = right;
            //    Character pivot = ls[right / 2];

            //    while (i <= j)
            //    {
            //        while (ls[i].Name.CompareTo(pivot.Name) > 0)
            //        {
            //            i++;
            //        }

            //        while (ls[j].Name.CompareTo(pivot.Name) < 0)
            //        {
            //            j--;
            //        }

            //        if (i > j) continue;
            //        // Swap
            //        (ls[i], ls[j]) = (ls[j], ls[i]);

            //        i++;
            //        j--;
            //    };

            //    return ls;
            //}

            //List<Character> SortById(List<Character> ls)
            //{
            //    int left = 0;
            //    int right = ls.Count - 1;
            //    int i = left, j = right;
            //    Character pivot = ls[right / 2];

            //    while (i <= j)
            //    {
            //        while (ls[i].Id > pivot.Id)
            //        {
            //            i++;
            //        }

            //        while (ls[j].Id < pivot.Id)
            //        {
            //            j--;
            //        }

            //        if (i > j) continue;

            //        (ls[i], ls[j]) = (ls[j], ls[i]);

            //        i++;
            //        j--;
            //    };

            //    return ls;
            //}

            //List<Character> SortByWinRatio(List<Character> ls)
            //{
            //    int left = 0;
            //    int right = ls.Count - 1;
            //    int i = left, j = right;
            //    Character pivot = ls[right / 2];

            //    while (i <= j)
            //    {
            //        while (ls[i].MatchCount / ls[i].WinCount > pivot.MatchCount / pivot.WinCount)
            //        {
            //            i++;
            //        }

            //        while (ls[i].MatchCount / ls[i].WinCount < pivot.MatchCount / pivot.WinCount)
            //        {
            //            j--;
            //        }

            //        if (i > j) continue;

            //        (ls[i], ls[j]) = (ls[j], ls[i]);

            //        i++;
            //        j--;
            //    }

            //    return ls;
            //}

            //foreach (var item in SortByWinCount(ls))
            //{
            //    Console.WriteLine($"{item.Name} - {item.WinCount} wins");
            //}


            //foreach (var item in SortByName(ls))
            //{
            //    Console.WriteLine($"{item.Name}");
            //}


            //foreach (var item in SortByWinRatio(ls))
            //{
            //    Console.WriteLine($"{item.Name} - {Math.Round(item.MatchCount / item.WinCount, 2)} win ratio");
            //}

            //foreach (var item in SortById(ls))
            //{
            //    Console.WriteLine($"{item.Name} - id {item.Id}");
            //}



            //Console.ReadKey();
            #endregion


            List<HashTable> tables = new List<HashTable>()
            {
                new OpenHashTable(),
                new ClosedHashTable()
            };

            foreach (var i in tables)
            {
                foreach (var j in new List<int>() { 67, 13, 49, 24, 40, 33, 58 })
                {
                    i.Add(j);
                }
            }


            foreach (var i in tables)
            {
                i.Print();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
