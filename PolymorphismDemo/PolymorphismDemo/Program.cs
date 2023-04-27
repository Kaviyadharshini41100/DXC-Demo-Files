namespace PolymorphismDemo
{
     class Program
    {
        public virtual void show()
        {
            Console.WriteLine("This is new one");
        }
    }
    class Student : Program
    {
        public override void show()
        {
            Console.WriteLine("This is Second method");
        }
    }
    internal class detail
    {
        static void Main(string[] args)
        {
            Program p = new Student();
            p.show();
        }
    }
      
}