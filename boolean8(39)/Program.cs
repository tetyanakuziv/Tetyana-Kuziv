using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean8_39_
{
    class Program
    {
        static void Main(string[] args)
        {//Boolean39. Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Ферзь за один ход может перейти с одного поля на другое». 
            try
            {
                int x1 = Value("the x1");
                int x2 = Value("the x2");
                int y1 = Value("the y1");
                int y2 = Value("the y2");
                if (x1 > 8 || x2 > 8 || y1 > 8 || y2 > 8)
                {
                    Console.WriteLine("Please enter another value");
                    Console.ReadKey();
                    return;
                }
                if (x1 < 1 || x2 < 1 || y1 < 1 || y2 < 1)
                {
                    Console.WriteLine("Please enter another value");
                    Console.ReadKey();
                    return;
                }
                Console.WriteLine(Math.Abs(x1 - x2) == Math.Abs(y1 - y2) || Math.Abs(x1 - x2) == Math.Abs(y1 - y2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
        static int Value(string nameValue)
        {
            Console.WriteLine("Please enter {0}", nameValue);
            string s = Console.ReadLine();
            return Int32.Parse(s);
        }
    }
}
