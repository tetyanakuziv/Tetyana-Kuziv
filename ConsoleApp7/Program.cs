using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter ulong value");
            string s = Console.ReadLine();

            string str = s.Trim();
            if (str.Length == 0)
            {
                Console.WriteLine("Incorrect value");
                Console.ReadKey();
                return;
            }

            try
            {
                int[] x = strIntArray(str);

                int y = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    y += x[i];
                }

                Console.WriteLine("Summa of all numbers is {0}", y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            Console.ReadKey();
        }

        static int[] strIntArray(string s)
        {
            int[] x = new int[s.Length];

            for (int i = 0; i < s.Length; i++)
            {
                x[i] = Int32.Parse(s[i].ToString());
            }

            return x;
        }
    }
}
