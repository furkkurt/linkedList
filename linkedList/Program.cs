using System;

namespace linkedList
{
    class MainClass 
    {
        public static void Main(string[] args)
        {
            TestStack();

        }

        public static void TestLinkedList() 
        {
            LinkedList<object> list = new LinkedList<object>();
            list.Add(1);
            list.Add(2);
            list.Add("Hello World!");
            list.Add(3);
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Contains(3));
            list.Remove();
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Contains(3));

            foreach (object i in list)
            {
                Console.WriteLine(i);
            }
        }

        public static void TestStack()
        {
            Stack<object> stack = new Stack<object>(3);
            stack.Push("dos");
            stack.Push(1);
            stack.Push("Furkan");
            stack.Push("Kurt");
            Console.WriteLine(stack.ToString());
            stack.Pop();
            stack.Push("Kurt");
            Console.WriteLine(stack.ToString());
        }
    }
}
