using System;

namespace LinkedList
{

    public class LinkedList<Type>
    {
        private ListComponent<Type> _first;

        public void AddFirst(Type data)
        {
            ListComponent<Type> temp = _first;
            _first = new ListComponent<Type>() { Data = data };
            _first.Next = temp;
        }

        public void RemoveFirst()
        {
            _first = _first.Next;
        }

        public void Print(Action<Type> action)
        {
            if(_first != null)
            {
                action.Invoke(_first.Data);
                Printing( action,_first.Next);
            }
        }

        private void Printing(Action<Type> action, ListComponent<Type> next)
        {
            if(next != null)
            {
                action.Invoke(next.Data);
                Printing(action, next.Next);
            }
        }

        public int Count()
        {
            int i = 0;
            if (_first != null)
            {
                i = Current(_first.Next) + 1;
            }
            return i;
        }

        public void Sort(Func<Type,Type, bool> action)
        {
            if(_first == null)
            {
                return;
            }

            if(_first.Next == null)
            {
                return;
            }

            ListComponent<Type> end;
            ListComponent<Type> p;
            ListComponent<Type> q;

            for(end = null; end != _first.Next; end = p)
            {
                for(p = _first; p.Next != end; p = p.Next)
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

        private int Current(ListComponent<Type> next)
        {
            if(next == null)
            {
                return 0;
            }
            else
            {
                return Current(next.Next) + 1;
            }
        }
    }
}
