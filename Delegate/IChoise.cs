using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal interface IChoise<T>
    {
        public MyCollection<T> ReturnCollection(Predicate<int> predicate);
    }
}
