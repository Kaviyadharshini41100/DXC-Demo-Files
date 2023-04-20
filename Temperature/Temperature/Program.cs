namespace Temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of Celsius");
            Double Celsius = Convert.ToDouble(Console.ReadLine());
            Double Fahrenheit = ((Celsius * 9) / 5) + 32;
            Console.WriteLine("Temperature in Fahrenheit is:" + Fahrenheit);
        }
    }
}