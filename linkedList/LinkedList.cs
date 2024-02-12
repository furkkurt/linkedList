using System;
namespace linkedList
{
    public class LinkedList
    {
        private Node head;
        private int size;

        public LinkedList()
        {
            this.head = null;
            this.size = 0;

        }

        public void Add(object o)
        {
            this.head = new Node(o, this.head);
            size++;
        }

        public void Remove()
        {
            if (this.head != null)
            {
                this.head = this.head.Next;
                size--;
            }

        }

        public int Size
        {
            get { return this.size; }
        }

        public object Get(int index)
        {
            Node current = this.head;
            for (int i = 0; i < index; i++)
                current = current.Next;

            return current.Data;
        }

        public override string ToString()
        {
            String str = "";
            for (int i = 0; i < size; i++)
            {
                str += i;
                str += ": ";
                str += this.Get(i);
                str += "\n";
            }
            return str;
        }

        public bool Contains(object o)
        {
            for (int i = 0; i < size; i++)
            {

                if (o.Equals(Get(i)))
                    return true;
            }

            return false;
        }
    }
}
