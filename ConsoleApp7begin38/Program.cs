using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7begin38
{
    class Program
    {
        static void Main(string[] args)
        {//Begin38. Решить линейное уравнение A·x + B = 0, заданное своими коэффициентами A и B (коэффициент A не равен 0). 
            try
            {
                int A = getUserValue("the A");
                if (A == 0)
                {
                    Console.WriteLine("A cannot be 0");
                }
                int B = getUserValue("the B");
                int x = -B / A;

                Console.WriteLine("Result:{0}", x);
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

