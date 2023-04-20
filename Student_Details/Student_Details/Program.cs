namespace Student_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student name");
            String StudentName = Console.ReadLine();
            Console.WriteLine("Enter Student ID");
            int ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Age");
            int Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mark1:");
            int Mark1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark2:");
            int Mark2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark3:");
            int Mark3 = Convert.ToInt32(Console.ReadLine());

            double Total = Mark1 + Mark2 + Mark3;
            double Avg = Total / 3;
            double Per = (Total / 300) * 100;
            Console.WriteLine("Total Marks are" + Total);
            Console.WriteLine("Percentage is" + Per);
                if (Per >= 90 && Per<= 100)
                {
                    Console.WriteLine("A Grade");
                }
                else if (Per >= 80 && Per <= 89)
                {
                    Console.WriteLine("B Grade");
                }
                else if (Per >= 60 && Per <= 79)
                {
                    Console.WriteLine("C Grade");
                }
                else if (Per >= 50 && Per <= 59)
                {
                    Console.WriteLine("D Grade");
                }
                else
                {
                    Console.WriteLine("E Grade");

                }
                if(Per >= 50)
                 {
                   Console.WriteLine("Result is Pass");
                }
                else
                {
                   Console.WriteLine("Result is Fail");
                }
            

            

           
            







        }
    }
}