using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12ineger3
{
    class Program
    {
        static void Main(string[] args)
        {   //Integer3.Дан размер файла в байтах.Используя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл(1 килобайт = 1024 байта). 
            try
            {
                int b = getUserValue("file in bytes");
                if (b < 0)
                {
                    Console.WriteLine("Please enter another number");
                    Console.ReadKey();
                    return;
                }
                int kb = b / 1024;
                Console.WriteLine("file in kilobytes:{0}", kb);
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

