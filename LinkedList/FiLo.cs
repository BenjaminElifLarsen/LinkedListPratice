using System;

namespace LinkedList
{

    public class FiLo<Type> : LinkedList<Type> where Type : IComparable//consider having a hash version, circular linked list, first in/first out
    {
        internal ListComponent<Type> _head;

        public override bool Add(Type data)
        {
            ListComponent<Type> temp = _head;
            _head = new ListComponent<Type>() { Data = data };
            _head.Next = temp;
            return true;
        }

        public override bool Remove() 
        {
            _head = _head.Next;
            return true;
        }

        public override void Print(Action<Type> action)
        {
            if(_head != null)
            {
                action.Invoke(_head.Data);
                CurrentPrint(action,_head.Next);
            }
        }

        /// <summary>
        /// Get the value of the frist node and remove the node.
        /// </summary>
        /// <returns>The value of the node. if no node has been set it returns the default value.</returns>
        public override Type GetValue()
        {
            if(_head == null)
            {
                return default;
            }

            Type value = _head.Data;
            _head = _head.Next;
            return value;
        }

        private void CurrentPrint(Action<Type> action, ListComponent<Type> next)
        {
            if(next != null)
            {
                action.Invoke(next.Data);
                CurrentPrint(action, next.Next);
            }
        }

        public override int Count() 
        {
            int i = 0;
            if (_head != null)
            {
                i = CurrentPrint(_head.Next) + 1;
            }
            return i;
        }

        public override void Sort(Func<Type,Type, bool> action)
        {
            if(_head == null)
            {
                return;
            }

            if(_head.Next == null)
            {
                return;
            }

            ListComponent<Type> end;
            ListComponent<Type> p;
            ListComponent<Type> q;

            for(end = null; end != _head.Next; end = p)
            {
                for(p = _head; p.Next != end; p = p.Next)
                {
                    q = p.Next;
                    if(action(p.Data, q.Data))
                    {
                        Type temp = p.Data;
                        p.Data = q.Data;
                        q.Data = temp;
                    }
                }
            }
        }

        private int CurrentPrint(ListComponent<Type> next)
        {
            if(next == null)
            {
                return 0;
            }
            else
            {
                return CurrentPrint(next.Next) + 1;
            }
        }
    }
}
