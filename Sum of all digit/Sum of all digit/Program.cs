namespace Sum_of_all_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, k;
            Console.WriteLine("Enter numbers");
            num = Convert.ToInt32(Console.ReadLine());
            while (num>0)
            {
                k = num % 10;
                sum = sum + k;
                num = num / 10;
            }
            Console.WriteLine("Sum of all digits=" + sum);

        }
    }
}