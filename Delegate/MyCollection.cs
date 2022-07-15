using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate string MyDelgate();

    internal class MyCollection<T> : IChoise<T>
    {
        DoubleChainList<T> Arr = new DoubleChainList<T>();
        public MyCollection(DoubleChainList<T> arr)
        {
            Arr = arr;
        }

        public MyCollection<T> ReturnCollection(Predicate<T> predicate)
        {
            int q = 0;
            x
            DoubleChainList<T> NewArr = new DoubleChainList<T>();
            while (q!=Arr.Length)
            {
                if (predicate())
                {
                    NewArr = i;
                    q++;
                }
            }
            
            return new MyCollection<T>(NewArr) ;
        }
        public void Print()
        {
            foreach (T i in Arr)
            {
                Console.WriteLine(i);
            }
        }
        public void Biek(Func<double,double> func)
        {
            Console.WriteLine("Введите индекс элемента: ");
            var i = Convert.ToInt32(Console.ReadLine());
            var value=func(Arr[i]);
        }
    }
}
