using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = getUserValue("integer a");
                if (a == 0)
                {
                    Console.WriteLine("a cannot be 0");
                    Console.ReadKey();
                    return;
                }

                int b = getUserValue("integer b");
                int c = getUserValue("integer c");

                double d = Math.Pow(b, 2) - 4 * a * c;

                if (d < 0)
                {
                    Console.WriteLine("The equation has no solutions");
                }
                else if (d == 0)
                {
                    double x = -b / 2 * a;
                    Console.WriteLine("The equation has one solution, x1 = x2 = {0}", x);
                }
                else
                {
                    double x1 = (-b - Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b + Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("The equation has two solutions, x1 = {0}, x2={1}", x1, x2);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static int getUserValue(string nameValue)
        {
            Console.WriteLine("Please enter {0}", nameValue);
            string s = Console.ReadLine();
            return Int32.Parse(s);
        }
    }

}
