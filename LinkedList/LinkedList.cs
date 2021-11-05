using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public abstract class LinkedList<Type> where Type : IComparable
    {
        public abstract bool Add(Type data);
        public abstract bool Remove();
        public abstract void Print(Action<Type> action);
        public abstract int Count();
        public abstract void Sort(Func<Type, Type, bool> action);
        public abstract Type GetValue();
    }
}
