using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    /// <summary>
    /// A First In / Last Out Linked List that does permit duplicated values.
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class HashFiLo<Type> : FiLo<Type> where Type : IComparable
    {
        /// <summary>
        /// Add the data if the data is not present in the linked list.
        /// </summary>
        /// <param name="data">The data to add.</param>
        /// <returns>True if the data was added else false.</returns>
        public override bool Add(Type data)
        {
            if(_head == null)
            {
                return base.Add(data);
            }

            for(ListComponent<Type> current = _head; current.Next != null; current = current.Next)
            { //need to check if the next is null
                if (current.Data.CompareTo(data) >= 0)
                    return false;
            }

            return base.Add(data);
        }
    }
}
