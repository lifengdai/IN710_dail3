using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    //This this a dynamic list class
    //It contains a list of Item class
    //I implement IEnumerable, so you can use foreach loop on it,
    //however there is no 100% guarantee that it will not crash 
    public class MyGenericList<T> : IEnumerable<T>
    {
        private Item<T> head;
        private Item<T> tail;
        private listEmu le;
        public MyGenericList()
        {
            initState();
            head = null;
            tail = null;
            le = new listEmu(head);
        }

        //Count how many elements in it
        public int Count()
        {
            Item<T> walker = head;
            int count = 0;

            while (walker != null)
            {
                ++count;
                walker = walker.Next1;
            }
            return count;     
        }

        //Add one element in it
        public void Add(T needToBeAdded)
        {
            Item<T> i = new Item<T>();
            i.Item1 = needToBeAdded;

            if(head == null)
            {
                head = i;
                tail = i;
            }
            else
            {
                tail.Next1 = i;
                tail = i;
            }
            le.Head = head;
            le.Start.Next1 = head;
            le.BackUp = le.Start;
        }

        //Fetch one element by index
        public T Item(int index)
        {
            Item<T> walker = head;
            for (int i = 0; i < index; i++)
            {
                walker = walker.Next1;
            }
            return walker.Item1;
        }

        //Remove one element at index position
        public void RemoveAt(int index)
        {
            Item<T> walker = head;
            Item<T> wantToRemove = head;

            if(index == 0)
            {
                if(Count() == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next1;
                }
            }
            else
            {
                if(index == Count() - 1)
                {
                    for (int i = 0; i < index - 1; i++)
                    {
                        walker = walker.Next1;
                    }
                    tail = walker;
                    tail.Next1 = null;
                }
                else
                {
                    for (int i = 0; i < index; i++)
                    {
                        if((i == index - 1) && (i != 0))
                        {
                            walker = walker.Next1;
                        }
                        wantToRemove = wantToRemove.Next1;
                    }

                    walker.Next1 = wantToRemove.Next1;
                }
            }
        }

        //Remove one element
        public void Remove(T needToBeRemoved)
        {
            Item<T> walker = head;
            Item<T> containNeedToBeRemoved = null;

            for (int i = 0; i < Count(); i++)
            {
                if (walker.Next1.Equals(needToBeRemoved))
                {
                    containNeedToBeRemoved = walker;
                    break;
                }
                else
                {
                    walker = walker.Next1;
                }
            }

            walker = head;

            if (head.Item1.Equals(needToBeRemoved))
            {
                if (Count() == 1)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    head = head.Next1;
                }
            }
            else
            {
                if (tail.Item1.Equals(needToBeRemoved))
                {
                    while (!walker.Next1.Equals(needToBeRemoved))
                    {
                        walker = walker.Next1;
                    }
                    tail = walker;
                }
                else
                {
                    while (!walker.Next1.Equals(needToBeRemoved))
                    {
                        walker = walker.Next1;
                    }
                    walker.Next1 = containNeedToBeRemoved.Next1;
                }
            }
        }

        //Clear all element in this list
        public void Clear()
        {
            initState();
        }

        //set head and tail to null
        //and hope the garbage collector will clear the memory
        private void initState()
        {
            head = null;
            tail = null;
        }

        //Inner class
        class listEmu : IEnumerator<T>
        {
            private Item<T> head;
            private Item<T> start;
            private Item<T> backUp;
            private bool disposedValue = false;

            public listEmu(Item<T> head)
            {
                this.head = head;
                backUp = head;
                start = new Item<T>();
            }

            public T Current
            {
                get 
                {
                    if (head == null)
                    {
                        //It seems that this will never throw
                        throw new InvalidOperationException();
                    }
                    else
                    {
                        return start.Item1;
                    }
                }
            }

            public void Dispose()
            {
                Dispose(true);
                GC.SuppressFinalize(this);
                start = new Item<T>();
            }

            protected virtual void Dispose(bool disposing)
            {
                if (!this.disposedValue)
                {
                    if (disposing)
                    {
                        
                    }
                    head = backUp;
                }

                this.disposedValue = true;
            }

            ~listEmu()
            {
                Dispose(false);
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public bool MoveNext()
            {
                start = start.Next1;
                if(start == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public void Reset()
            {
                head = backUp;
            }

            public Item<T> Head
            {
                get { return head; }
                set { head = value; }
            }

            public Item<T> BackUp
            {
                get { return backUp; }
                set { backUp = value; }
            }

            public Item<T> Start
            {
                get { return start; }
                set { start = value; }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return le;
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return le;
        }
    }
}
