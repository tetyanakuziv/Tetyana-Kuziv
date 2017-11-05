using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int m = getUserValue("number of rows");
                int n = getUserValue("number of cols");

                if (m == n)
                {
                    Console.WriteLine("This matrix is not rectangular. Please enter another numbers");
                    Console.ReadKey();
                    return;
                }

                if (m <= 0)
                {
                    Console.WriteLine("The number of rows cannot be <= 0");
                    Console.ReadKey();
                    return;
                }

                if (n <= 0)
                {
                    Console.WriteLine("The number of cols cannot be <= 0");
                    Console.ReadKey();
                    return;
                }

                int[,] matrix1 = new int[m, n];
                for (int i = 0; i < m; i++)
                {
                    int[] rowValues = getUserRowValues(i + 1);
                    if (rowValues.Length != n)
                    {
                        Console.WriteLine("Count of entered values is not equals count of columns");
                        Console.ReadKey();
                        return;
                    }

                    for (int j = 0; j < n; j++)
                    {
                        int x = rowValues[j];
                        matrix1[i, j] = x;
                    }
                }

                int[,] matrix2 = new int[n, m];
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        int x = matrix1[i, j];
                        matrix2[j, i] = x;
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("{0} ", matrix2[i, j]);
                    }
                    Console.WriteLine();
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
            return Convert.ToInt32(s);
        }

        static int[] getUserRowValues(int row)
        {
            Console.WriteLine("Please enter values of row {0} by space. For example: 12 34 25 16...", row);
            string s = Console.ReadLine();
            s = s.Trim();

            string[] strar = s.Split(' ');

            int[] intar = new int[strar.Length];
            for (int i = 0; i < strar.Length; i++)
            {
                intar[i] = Convert.ToInt32(strar[i]);
            }
            return intar;
        }
    }
}
