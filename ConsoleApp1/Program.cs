using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer value");
            string s = Console.ReadLine();

            try
            {
                int x = Int32.Parse(s);
                int y = 2 * x;
                Console.WriteLine("Result: {0}", y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

    }
}
