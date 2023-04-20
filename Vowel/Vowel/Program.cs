namespace Vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter character");
            char ap= Convert.ToChar(Console.ReadLine());
            if(ap == 'A' || ap == 'a' || ap == 'E' || ap == 'e' || ap == 'I' || ap == 'i' || ap == 'O' || ap == 'o' || ap == 'U' || ap == 'u')
            {
                Console.WriteLine("Its an  vowel");
            }
            else
            {
                Console.WriteLine("Its  not an  vowel");
            }
        }
    }
}