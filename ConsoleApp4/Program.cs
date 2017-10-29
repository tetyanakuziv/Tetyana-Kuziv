using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = getUserValue("integer a");
                int b = getUserValue("integer b");
                if (a == 0)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("The equation has many solutions");
                    }
                    else
                    {
                        Console.WriteLine("The equation has no solutions");
                    }
                }
                else
                {
                    float result = (float)b / a;

                    Console.WriteLine("Result: {0}", result);
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
