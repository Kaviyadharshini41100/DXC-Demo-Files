using System.Reflection.Metadata.Ecma335;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            int n1, n2, n3;
            int day;
            Console.WriteLine("Enter first num");
            n1=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second num");
            n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter third num");
            n3 = Convert.ToInt16(Console.ReadLine());
            if((n1>n2) && (n1>n3))
            {
                Console.WriteLine("Number 1 is greater");
            }
            else if((n2>n1) && (n2>n3))
            {
                Console.WriteLine("Number 2 is greater");
            }
            else
            {
                Console.WriteLine("Number 3 is greater");
            }
            Console.WriteLine("Program Executed successfully");
            Console.WriteLine();
            day = 5;
            switch(day)
            {
                case 1:
                    {
                        Console.WriteLine("Monday");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Tuesday");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Wednesdday");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thursday");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Friday");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Saturday");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Sunday");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid input");
                        break;
                    }
            }
            Console.WriteLine("Switch case Program");
            

        }
        
    }
}