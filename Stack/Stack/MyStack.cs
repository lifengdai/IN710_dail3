using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    //This is the stack class, you can give this class any data type
    //you want
    public class MyStack<T>
    {
        private MyGenericList<T> mgl;

       public MyStack()
       {
          mgl = new MyGenericList<T>();
       }

       public void Push(T thing)
       {
           mgl.Add(thing);
       }

       public T Pop()
       {
           T willReturn = Peek();
           mgl.RemoveAt(Count() - 1);

           return willReturn;
       }

       public T Peek()
       {
           return mgl.Item(Count() - 1);
       }

       public int Count()
       {
          return mgl.Count();
       }

       public bool isEmpty()
       {
           if (Count() == 0)
           {
               return true;
           }
           else
           {
               return false;
           }
       }

       public MyGenericList<T> Mgl
       {
           get { return mgl; }
           set { mgl = value; }
       }
   }
}
