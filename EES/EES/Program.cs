using EES.Helper;

namespace EES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your full name : ");
                string fullName = Console.ReadLine();
                Console.Write("Enter your age : ");
                while (!byte.TryParse(Console.ReadLine(), out byte age))
                {
                    Console.WriteLine("Invalid Age, try again");
                    Console.Write("Enter your age : ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
