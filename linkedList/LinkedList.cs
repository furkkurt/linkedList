using System;
using System.Collections;
using System.Collections.Generic;

namespace linkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            Node<T> current = head;
            while (current != null)
            {
                yield return (T)current.Data;
                current = current.Next;
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            // this will invoke the public generic
            // version, so there is no recursion
            return this.GetEnumerator();
        }


        private Node<T> head;
        private int NumberOfElements;

        public LinkedList()
        {
            this.head = null;
            this.NumberOfElements = 0;

        }

        public void Add(object o)
        {
            this.head = new Node<T>(o, this.head);
            NumberOfElements++;
        }

        public void Remove()
        {
            if (this.head != null)
            {
                this.head = this.head.Next;
                NumberOfElements--;
            }

        }

        public int Size
        {
            get { return this.NumberOfElements; }
        }

        public object GetElement(int index)
        {
            Node<T> current = this.head;
            for (int i = 0; i < index; i++)
                current = current.Next;

            return current.Data;
        }

        public override string ToString()
        {
            String str = "";
            for (int i = 0; i < NumberOfElements; i++)
            {
                str += i;
                str += ": ";
                str += this.GetElement(i);
                str += "\n";
            }
            return str;
        }

        public bool Contains(object o)
        {
            for (int i = 0; i < NumberOfElements; i++)
            {

                if (o.Equals(GetElement(i)))
                    return true;
            }

            return false;
        }

        public T Find<T>(Predicate<T> P)
        {
            for (int i = 0; i < NumberOfElements; i++)
            {

                if (P((T)GetElement(i)))
                    return (T)GetElement(i);
            }
            return default(T);
        }

        public T[] Filter(Predicate<T> P)
        {
            List<T> filteredList = new List<T>();
            for (int i = 0; i < NumberOfElements; i++)
            {
                if (P((T)GetElement(i)))
                    filteredList.Add((T)GetElement(i));
            }

            return filteredList.ToArray();
        }

        public static IEnumerable<T2> Map<T1, T2>(LinkedList<T1> list, Func<T1, T2> f)
        {
            LinkedList<T2> mappedList = new LinkedList<T2>();
            foreach (T1 elem in list)
            {
                mappedList.Add(f(elem));

            }
            return mappedList;
        }

        public static T2 Reduce<T1, T2>(IEnumerable<T1> enumerable, Func<T2, T1, T2> f)
        {
            T2 result = default(T2);
            foreach (T1 elem in enumerable)
            {
                result = f(result, elem);
            }
            return result;
        }

        public static LinkedList<T> InvertList<T>(LinkedList<T> list)
        {
            LinkedList<T> invertedList = new LinkedList<T>();

            for (int i = list.Size - 1; i >= 0; i--)
            {
                invertedList.Add(list.GetElement(i));
            }

            return invertedList;
        }

        public static void ForEach<T>(IEnumerable<T> e, Action<T> a)
        {
            foreach (T elem in e)
            {
                a(elem);
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
