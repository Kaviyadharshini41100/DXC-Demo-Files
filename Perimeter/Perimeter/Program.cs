namespace Perimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter L");
            Double L = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter B");
            Double B = Convert.ToDouble(Console.ReadLine());
            Double perimeter = 2 * (L + B);
            Console.WriteLine(perimeter);
        }
    }
}