using System;
namespace linkedList
{
    public class Stack : LinkedList
    {
        private int maxNumberOfElements;
        public bool IsEmpty;
        public bool IsFull;

        public Stack(int maxNumberOfElements)
        {
            this.maxNumberOfElements = maxNumberOfElements;
            this.IsEmpty = true;
            this.IsFull = false;

        }

        public void Push(object o)
        {
            if (this.Size < this.maxNumberOfElements)
                this.Add(o);
            if (this.Size == this.maxNumberOfElements)
                this.IsFull = true;
        }

        public void Pop()
        {
            if (this.Size > 0)
                this.Remove();
            if (this.Size == 0)
                this.IsEmpty = true;

        }
    }
}
