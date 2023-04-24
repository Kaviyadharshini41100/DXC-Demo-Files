namespace Average_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {10,10,10,10,10,10,10,10,10,10 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i]; 
            }
            double average = (double)sum / arr.Length;
                                                       
            Console.WriteLine("Average of elements: " + average);
        }
    }
}