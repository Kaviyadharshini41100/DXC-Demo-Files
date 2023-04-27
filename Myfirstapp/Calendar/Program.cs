namespace Calendar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, result;
            char op;
            Console.Write("Enter first number: ");
            num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter operator: ");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            Console.WriteLine("Result: " + result);
            Console.ReadKey();
        }
        
    }
    
}