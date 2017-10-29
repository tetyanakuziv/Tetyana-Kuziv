using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int[] sv = new int[a];

            for (int i = 0; i < a; i++)
            {

                sv[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(sv);
            Console.WriteLine("The biggest number is {0}", sv[a - 1]);
            Console.ReadKey();
        }
    }
}
