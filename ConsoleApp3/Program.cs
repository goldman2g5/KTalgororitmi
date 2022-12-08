using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3._10fns;
using ConsoleApp3.DUPLICATES;
using ConsoleApp3.Hashtable;
using ConsoleApp3.Sequence;
using ConsoleApp3.Sequense;
using ConsoleApp3.Tree;

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
            //List<Character> characters = new List<Character>()
            //{
            //    new Character(1, "Amber", 100, 300),
            //    new Character(3, "Lisa", 45, 100),
            //    new Character(2, "Venti", 300, 450),
            //    new Character(-1, "Raiden", 60, 100),
            //    new Character(-2, "Miko", 50, 70),
            //};

            //List<Character> SortByWinCount(List<Character> array, int leftIndex, int rightIndex)
            //{
            //    var i = leftIndex;
            //    var j = rightIndex;
            //    var pivot = array[leftIndex];
            //    while (i <= j)
            //    {
            //        while (array[i].WinCount < pivot.WinCount)
            //        {
            //            i++;
            //        }

            //        while (array[j].WinCount > pivot.WinCount)
            //        {
            //            j--;
            //        }
            //        if (i <= j)
            //        {
            //            var temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //            i++;
            //            j--;
            //        }
            //    }

            //    if (leftIndex < j)
            //        SortByWinCount(array, leftIndex, j);
            //    if (i < rightIndex)
            //        SortByWinCount(array, i, rightIndex);
            //    return array;
            //}

            //List<Character> SortByName(List<Character> array, int leftIndex, int rightIndex)
            //{
            //    var i = leftIndex;
            //    var j = rightIndex;
            //    var pivot = array[leftIndex];
            //    while (i <= j)
            //    {

            //        while (string.Compare(array[i].Name, pivot.Name) > 0)
            //        {
            //            i++;
            //        }

            //        while (string.Compare(array[j].Name, pivot.Name) < 0)
            //        {
            //            j--;
            //        }
            //        if (i <= j)
            //        {
            //            var temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //            i++;
            //            j--;
            //        }
            //    }

            //    if (leftIndex < j)
            //        SortByName(array, leftIndex, j);
            //    if (i < rightIndex)
            //        SortByName(array, i, rightIndex);
            //    return array;
            //}

            //List<Character> SortById(List<Character> array, int leftIndex, int rightIndex)
            //{
            //    var i = leftIndex;
            //    var j = rightIndex;
            //    var pivot = array[leftIndex];
            //    while (i <= j)
            //    {
            //        while (array[i].Id < pivot.Id)
            //        {
            //            i++;
            //        }

            //        while (array[j].Id > pivot.Id)
            //        {
            //            j--;
            //        }
            //        if (i <= j)
            //        {
            //            var temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //            i++;
            //            j--;
            //        }
            //    }

            //    if (leftIndex < j)
            //        SortById(array, leftIndex, j);
            //    if (i < rightIndex)
            //        SortById(array, i, rightIndex);
            //    return array;
            //}

            //List<Character> SortByWinRatio(List<Character> array, int leftIndex, int rightIndex)
            //{
            //    var i = leftIndex;
            //    var j = rightIndex;
            //    var pivot = array[leftIndex];
            //    while (i <= j)
            //    {
            //        while (array[i].GetWinRate() < pivot.GetWinRate())
            //        {
            //            i++;
            //        }

            //        while (array[j].GetWinRate() > pivot.GetWinRate())
            //        {
            //            j--;
            //        }
            //        if (i <= j)
            //        {
            //            var temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //            i++;
            //            j--;
            //        }
            //    }

            //    if (leftIndex < j)
            //        SortByWinRatio(array, leftIndex, j);
            //    if (i < rightIndex)
            //        SortByWinRatio(array, i, rightIndex);
            //    return array;
            //}

            //Console.WriteLine("Before sorting:");
            //foreach (var i in characters)
            //{
            //    Console.WriteLine(i.Name);
            //}
            //Console.WriteLine("\nby win count");

            //foreach (var item in SortByWinCount(characters, 0, characters.Count - 1))
            //{
            //    Console.WriteLine($"{item.Name} - {item.WinCount} wins");
            //}

            //Console.WriteLine("\nby name");

            //foreach (var item in SortByName(characters, 0, characters.Count - 1))
            //{
            //    Console.WriteLine($"{item.Name}");
            //}

            //Console.WriteLine("\nby win rate");

            //foreach (var item in SortByWinRatio(characters, 0, characters.Count - 1))
            //{
            //    Console.WriteLine($"{item.Name} - {item.GetWinRate()} win rate");
            //}

            //Console.WriteLine("\n by id");

            //foreach (var item in SortById(characters, 0, characters.Count - 1))
            //{
            //    Console.WriteLine($"{item.Name} - {item.Id}");
            //}

            //Console.ReadKey();

            #endregion

            #region HashTable

            //List<HashTable> tables = new List<HashTable>()
            //{
            //    new OpenHashTable(),
            //    new ClosedHashTable()
            //};

            //foreach (var i in tables)
            //{
            //    foreach (var j in new List<int>() { 67, 13, 49, 24, 40, 33, 58 })
            //    {
            //        i.Add(j);
            //    }
            //}


            //foreach (var i in tables)
            //{
            //    i.Print();
            //    Console.WriteLine();
            //}
            //Console.ReadKey();

            #endregion

            #region Tree

            //BinaryTree<string> tree = new BinaryTree<string>();
            //tree.Add("bebra");
            //tree.Add("brusko");
            //tree.Print(tree.root);

            //Console.ReadKey();

            #endregion

            Console.WriteLine(Huinya.GetDegreeOfTwo(8));

            Console.ReadKey();

        }
    }
}
