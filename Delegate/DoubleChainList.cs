using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class DoubleChainList<T>
    {
        public int Length = 0;
        private Cell<T> _begin;
        public Cell<T> Now { get; set; }
        public bool CheckEmpty()
        {
            if (Length == 0)
            {
                return true;
            }
            return false;
        }

 
        public void Add(T x)
        {
            if (CheckEmpty())
            {
                _begin = new Cell<T>(null, x, null);
                Now = _begin;
                Now.Index = Length;
                Length++;
            }
            else
            {
                Now = new Cell<T>(Now, x, null);
                Now.Previous.Next = Now;
                Now.Index = Length;
                Length++;
            }
        }
        public void Remove(int i)
        {
            Cell<T> x = _begin;
            while (x.Index!=i)
            {
                x= x.Next;
            }
            x.Previous.Next = x.Next;
            x.Next.Previous=x.Previous;
            Length--;
            x = x.Next;
            int j = x.Index-1;
            while (j != Length)
            {
                x.Index = j;
                x = x.Next;
                j++;
            }
        }
        public T SearchCell(int i)
        {
            Cell<T> x = _begin;
            while (x.Index != i)
            {
                x = x.Next;
            }
            return x.Value;
        }
        public void Print()
        {
            Cell<T> x=_begin;
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(x.Value);
                x = x.Next;
            }
        }
        public DoubleChainList<T> ReturnCollection(Predicate<T> predicate)
        {
            int q = 0;
            DoubleChainList<T> NewArr = new DoubleChainList<T>();
            var x = _begin;
            var l = Length;
            while (q!= l)
            {
                if (predicate(x.Value))
                {
                    NewArr.Add(x.Value);                    
                }
                x = x.Next;
                q++;
            }

            return NewArr;
        }
        public void Biek(Func<T, T> func)
        {
            Console.WriteLine("Введите индекс элемента: ");
            var i = Convert.ToInt32(Console.ReadLine());

            Cell<T> x = _begin;
            while (x.Index != i)
            {
                x = x.Next;
            }

            var value = func(x.Value);
        }
    }
}
