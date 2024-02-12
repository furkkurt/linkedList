using System;

namespace linkedList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add("Hello World!");
            list.Add(3);
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Contains(3));
            list.Remove();
            Console.WriteLine(list.ToString());
            Console.WriteLine(list.Contains(3));

        }
    }
}
