using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.DUPLICATES
{
    public static class Duplicates
    {

        public static bool BruteForce(params int[] args)
        {
            foreach (var item in args)
            {
                var count = 0;
                foreach (var item2 in args)
                {
                    if (item == item2)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    return true;
                }
            }

            return false;
        }
        public static bool LogTime(params int[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                for (int j = i + 1; j < args.Length; j++)
                {
                    if (args[i] == args[j])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public static bool LinearTime(params int[] args)
        {
            var set = new HashSet<int>();
            foreach (var i in args)
            {
                if (set.Contains(i))
                {
                    return true;
                }
                set.Add(i);
            }
            return false;
        }

    }
}
