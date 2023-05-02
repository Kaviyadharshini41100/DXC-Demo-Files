namespace ExceptionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            
            try
            {
                Console.WriteLine("Enter number 1");
                a = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter number 2");
                b = Convert.ToInt16(Console.ReadLine());
                if (a < b)
                {
                    throw new InValidException("Value of first number cannot be less than second number");
                }
                c = a / b;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("You cannot divide any number by zero!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Only numbers are allowed");
            }
            catch (InValidException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong!");
            }
            finally
            {
                Console.WriteLine($"The result is {c}");
                Console.WriteLine("Program End.");
            }
        }
           

    }
    
}