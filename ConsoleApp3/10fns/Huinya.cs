using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3._10fns
{
    public static class Huinya
    {

        public static int Increment(int n) { return n + 1; } //o(1)

        public static int SumOfTwoAndIncrement(int a, int b) //o(2)
        {
            return a + b + Increment(a);
        }
        public static int SumOfTwoAndIncrementAndMultiply(int a, int b) //o(3)
        {
            return a + b + Increment(a) * Increment(b);
        }

        public static int SumOfTwoAndIncrementAndMultiplyAndSum(params int[] ls) //o(3 + n)
        {
            var sum = 0;
            foreach (var i in ls)
            {
                sum += i;
            }
            return sum + Increment(ls[0]) * Increment(ls[1]);
        }

        public static int SumOfTwoAndIncrementAndMultiplyAndSumAndIncrement(params int[] ls) //o(4 + n)
        {
            var sum = 0;
            foreach (var i in ls)
            {
                sum += i;
            }
            return sum + Increment(ls[0]) * Increment(ls[1]) + Increment(sum);
        }

        public static int SumOfTwoAndIncrementAndMultiplyAndSumAndIncrementAndMultiply(params int[] ls) //o(5 + n)
        {
            var sum = 0;
            foreach (var i in ls)
            {
                sum += i;
            }
            return sum + Increment(ls[0]) * Increment(ls[1]) + Increment(sum) * Increment(sum);
        }

        public static bool Exists(int[] ls, int n) //o(n)
        {
            foreach (var i in ls)
            {
                if (i == n)
                {
                    return true;
                }
            }
            return false;
        }

        public static int SumAndMultiply(params int[] ls) //o(2n)
        {
            var sum = 0;
            var multiply = 1;
            foreach (var i in ls)
            {
                sum += i;
                multiply *= i;
            }
            return sum + multiply;
        }

        public static int GetDegreeOfTwo(int n) //o(log n)
        {
            var result = 2;
            var count = 1;
            while (n > result)
            {
                result *= 2;
                count++;
            }
            return count;
        }

        public static int[] BubbleSort(params int[] ls) //o(n^2)
        {
            var result = new int[ls.Length];
            ls.CopyTo(result, 0);
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        var temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;
        }


    }
}
