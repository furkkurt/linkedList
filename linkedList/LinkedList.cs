﻿using System;
using System.Collections.Generic;

namespace linkedList
{
    public class LinkedList<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            return this.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return GetEnumerator();
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



    }
}
