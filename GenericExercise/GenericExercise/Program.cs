﻿namespace GenericExercise
{
    class MyStack<T>



    {
        public int count;
        public T[] array;
        public MyStack()
        {
            array = new T[10];
            count = 0;
        }
        public void push(T obj)
        {
            array[count] = obj;
            count++;
        }
        public T pop()
        {
            T item = array[count - 1];
            count--;
            return item;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            int z = 0;



            MyStack<int> myStack = new MyStack<int>();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);



            foreach (int i in myStack.array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Number of objects in the stack = {myStack.count}");



            Console.WriteLine($"Poped item-{++j} is: {myStack.pop()}");
            Console.WriteLine($"Poped item-{++j} is: {myStack.pop()}");



            MyStack<string> myStack1 = new MyStack<string>();
            myStack1.push("01");
            myStack1.push("02");
            myStack1.push("03");
            myStack1.push("04");



            foreach (string i in myStack1.array)
            {
                Console.WriteLine(i);
            }



            Console.WriteLine($"Number of objects in the stack = {myStack1.count}");
            Console.WriteLine($"Poped item-{++z} is: {myStack1.pop()}");
            Console.WriteLine($"Poped item-{++z} is: {myStack1.pop()}");
        }
    }
}