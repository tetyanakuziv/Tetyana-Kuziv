using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11integer2
{
    class Program
    {
        static void Main(string[] args)
        {//Integer2. Дана масса M в килограммах. Используя операцию деления нацело, найти количество полных тонн в ней (1 тонна = 1000 кг). 
            try
            {
                int m = getUserValue("weight in kilograms");
                if (m < 0)
                {
                    Console.WriteLine("Please enter another number");
                    Console.ReadKey();
                }
                int mt = m / 1000;
                Console.WriteLine("The weight in tons:{0}", mt);
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
