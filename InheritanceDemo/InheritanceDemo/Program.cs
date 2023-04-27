namespace InheritanceDemo
{
    internal class Calculator
    {
        public int Sum(int a,int b)
        {
            return a + b;
        }
        public int Subtract(int a,int b)
        {
            return a - b;
        }
    }
    class SubCalculator : Calculator
    {
        public int Square(int x)
        {
            return x * x;
        }
        public void Message()
        {
            Console.WriteLine("This is new one");
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            SubCalculator calc = new SubCalculator();
            calc.Message();
        }
    }
}