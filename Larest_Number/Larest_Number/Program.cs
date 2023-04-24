namespace Larest_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 7, 4, 5, 6, 8, 2, 3, 1 };
            int largest = a[0];
            for (int i = 1; i < a.Length; i++)
            {
                if (a[i] > largest)
                {
                    largest = a[i];
                }
            }
            Console.WriteLine("The largest number of the given array is: " + largest);
        }
    }
}