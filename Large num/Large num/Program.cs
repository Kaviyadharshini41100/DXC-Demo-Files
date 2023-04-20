using System;

namespace Large_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter num3");
            num3 = Convert.ToInt16(Console.ReadLine());
            if (((num1 > num2) && (num1 > num3)))
            {
                Console.WriteLine("num1 is Greater");
            }
            else if (((num2 > num1) && (num2 > num3)))
            {
                Console.WriteLine("num2 is Greater");
            }
            else
            {
                Console.WriteLine("num3 is Greater");
            }
        }
    }
}