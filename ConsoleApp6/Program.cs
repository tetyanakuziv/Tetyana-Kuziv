using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three-digit natural number");
            string s = Console.ReadLine();

            try
            {
                int x = Int32.Parse(s);

                if (x < 100 || x > 999)
                {
                    Console.WriteLine("Please enter three-digit natural number");
                    Console.ReadKey();
                    return;
                }


                int[] ax = new int[3];
                ax[0] = x / 100;
                x = x % 100;
                ax[1] = x / 10;
                x = x % 10;
                ax[2] = x;

                int y = ax[0] + ax[1] + ax[2];
                Console.WriteLine("{0}+{1}+{2}={3}", ax[0], ax[1], ax[2], y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
