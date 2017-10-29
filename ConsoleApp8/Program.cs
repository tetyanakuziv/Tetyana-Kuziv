using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
 
            string s = "qwerty";

            Console.WriteLine("1."+s);

            m(s);

            Console.WriteLine("2." + s);


            Console.ReadKey();
        }

        static void m(string s)
        {

            Console.WriteLine("3." + s);

            s = s + "qwerrrrrr";

            Console.WriteLine("4." + s);
        }

        private class A
        {
            public string s;
        }
    }
}
