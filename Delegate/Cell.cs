using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Cell<T>
    {
        public Cell<T> Previous { get; set; }
        public T Value { get; set; }
        public Cell<T> Next { get; set; }
        public int Index { get; set; }
        public Cell(Cell<T>? previous, T? value, Cell<T>? next)
        {
            Previous = previous;
            Value = value;
            Next = next;
        }
    }
}