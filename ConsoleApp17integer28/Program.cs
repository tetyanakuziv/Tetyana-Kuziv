using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17integer28
{
    class Program
    {
        static void Main(string[] args)
        {//Integer28. Дано целое число K, лежащее в диапазоне 1–365, и целое число N, лежащее в диапазоне 1–7. Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было днем недели с номером N. 
            try
            {
                int k = getUserValue("K");
                if (k < 0 || k > 365)
                {
                    Console.WriteLine("Please enter another value");
                    Console.ReadKey();
                    return;
                }
                int n = getUserValue("N");
                if (n < 0 || n > 7)
                {
                    Console.WriteLine("Please enter another value");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine(" The number of day of week is {0}", (k + n - 1) % 7);
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
