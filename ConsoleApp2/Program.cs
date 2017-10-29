using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
 
            try
            {
                double x = getUserValue("x");
                double y = getUserValue("y");
                double z = getUserValue("z");

                double result = Math.Sin((x + Math.Pow(y, 2) + Math.Pow(z, 3)) / (1 + Math.Pow(x + y + z, 2))) * Math.Sqrt(Math.Abs(x + y + z));

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
