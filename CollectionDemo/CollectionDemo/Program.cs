using System.Collections;
using System.Collections.Generic;
namespace CollectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(40);
            list.Add("Hello");

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            list.Insert(3, "World");
            foreach(var i in list)
            {
               Console.WriteLine(i);
           }
            Console.WriteLine(list[2]);
            Console.WriteLine(list.Count);
        }
        
    }
}
