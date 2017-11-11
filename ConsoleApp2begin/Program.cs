using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2begin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the side a");
            string s = Console.ReadLine();
            try
            {
                int a = Int32.Parse(s);
                if (a <= 0)
                {
                    Console.WriteLine("Please enter another number");
                    Console.ReadKey();
                    return;
                }
                int S = a*a;
                Console.WriteLine("Result: {0}", S);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
