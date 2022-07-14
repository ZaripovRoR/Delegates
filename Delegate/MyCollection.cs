using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate string MyDelgate();

    internal class MyCollection : IChoise
    {
        public int[] Arr {get;set; }
        public MyCollection(int[] arr)
        {
            Arr = arr;
        }

        public MyCollection ReturnCollection(Predicate<int> predicate)
        {
            int q = 0;
            int[] NewArr = new int[Arr.Length];
            foreach (int i in Arr)
            {
                if (predicate(i))
                {
                    NewArr[q] = i;
                    q++;
                }

            }
            return new MyCollection(NewArr) ;
        }
        public void Print()
        {
            foreach (int i in Arr)
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
