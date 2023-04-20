namespace Simple_intrest
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int P;
            Double T, R;
            Console.WriteLine("Enter Principle Amount:");
            P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Intrest value");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Time Period");
            T = Convert.ToDouble(Console.ReadLine());
            Double SI = (P * R * T) / 100;
            Console.WriteLine(SI);
        }
    }
}