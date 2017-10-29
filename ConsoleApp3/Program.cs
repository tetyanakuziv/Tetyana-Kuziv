using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double a = getUserValue("side a");
                if (a <= 0)
                {
                    Console.WriteLine("Side a cannot be <=0");
                    Console.ReadKey();
                    return;
                }

                double b = getUserValue("side b ");
                if (b <= 0)
                {
                    Console.WriteLine("Side b cannot be <=0");
                    Console.ReadKey();
                    return;
                }

                if (a >= b)
                {
                    Console.WriteLine("Side a cannot be >=b");
                    Console.ReadKey();
                    return;
                }


                double alfa = getUserValue("angle alfa");
                if (alfa <= 0 || alfa >= 90)
                {
                    Console.WriteLine("Angle alfa cannot be <=0 or >=90");
                    Console.ReadKey();
                    return;
                }
                double radians = alfa * (Math.PI / 180);

                double result = (Math.Tan(radians) * (a + b) * (b - a)) / 4;

                Console.WriteLine("Result: {0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static double getUserValue(string nameValue)
        {
            Console.WriteLine("Please enter {0}", nameValue);
            string s = Console.ReadLine();

            return Double.Parse(s);
        }

    }
}
