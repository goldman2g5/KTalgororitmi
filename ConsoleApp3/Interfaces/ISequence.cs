using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Interfaces
{
    internal interface ISequence<out T> : IEnumerable<T>
    {
        abstract void Build(int size);
    }
}
