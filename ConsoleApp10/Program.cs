using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, n = 9999, x;
            Console.Write("root of the number:");
            x = Convert.ToDouble(Console.ReadLine());

            do
            {
                x1 = 0.5 * (n + (x / n));
                n = x1;
                // Console.WriteLine(x1);
            }
            while ((x1 * x1 > (x + 0.000000001)));

            Console.Write("root of the {0} = {1}", x, x1);
            Console.ReadKey();
        }
    }
}
