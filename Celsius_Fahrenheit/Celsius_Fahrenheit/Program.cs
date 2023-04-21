namespace Celsius_Fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("Enter temperature in celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = celsius * 9 / 5 + 32;
                Console.WriteLine("Temperature in fahrenheit: " + fahrenheit);
                Console.WriteLine("Do you want to continue? (yes/no): ");
                input = Console.ReadLine();
            }
            while (input.ToLower() == "yes");



        }
    }
}