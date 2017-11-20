using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace case2
{
    class Program
    {
        static void Main(string[] args)
        {//Case2. Дано целое число K. Вывести строку-описание оценки, соответствующей числу K (1 — «плохо», 2 — «неудовлетворительно», 3 — «удовлетворительно», 4 — «хорошо», 5 — «отлично»). Если K не лежит в диапазоне 1–5, то вывести строку «ошибка». 
            try
            {
                int k = Value("the integer K");
                switch (k)
                {
                    case 1:
                        Console.WriteLine("bad");
                        break;
                    case 2:
                        Console.WriteLine("Unsatisfactorily");
                        break;
                    case 3:
                        Console.WriteLine("Satisfactorily");
                        break;
                    case 4:
                        Console.WriteLine("Well");
                        break;
                    case 5:
                        Console.WriteLine("Excellent");
                        break;
                    default:
                        Console.WriteLine("Please enter another value");
                        break;
                }
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
