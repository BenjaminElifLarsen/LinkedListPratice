using System;

namespace LinkedList
{
    internal class ListComponent<Type>
    {
        internal Type Data { get; set; }
        internal ListComponent<Type> Next { get; set; }
    }
}
