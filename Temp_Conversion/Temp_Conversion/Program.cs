namespace Temp_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature in Celsius\tTemperature in Fahrenheit");
            for(int celsius=0; celsius<=100; celsius+=10)
            {
                double fahrenheit = (celsius * 9 / 5.0) + 32;
                Console.WriteLine($"{celsius}\t\t\t\t{fahrenheit}");
                

            }
        }
    }
}