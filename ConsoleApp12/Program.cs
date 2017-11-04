using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        const int ARRAY_LENGTH = 10;

        static void Main(string[] args)
        {
            Point[] points = new Point[ARRAY_LENGTH];

            try
            {
                for (int i = 0; i < points.Length; i++)
                {
                    Console.WriteLine("Please enter Point {0}", i + 1);
                    double x = getUserDoubleValue("coordinate x");
                    double y = getUserDoubleValue("coordinate y");
                    Point point = new Point(x, y);
                    points[i] = point;
                }


                double maxPer = 0;

                for (int i = 0; i < points.Length; i++)
                {
                    Point p1 = points[i];

                    for (int j = 0; j < points.Length; j++)
                    {
                        Point p2 = points[j];
                        if (p2.Equals(p1))
                        {
                            continue;
                        }

                        for (int k = 0; k < points.Length; k++)
                        {
                            Point p3 = points[k];
                            if (p3.Equals(p1) || p3.Equals(p2))
                            {
                                continue;
                            }

                            double s = 1 / 2 * ((p1.X - p3.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p3.Y));
                            if (s == 0)
                            {
                                // Three sides lie on one straight line
                                continue;
                            }

                            double p1p2 = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
                            double p2p3 = Math.Sqrt(Math.Pow(p3.X - p2.X, 2) + Math.Pow(p3.Y - p2.Y, 2));
                            double p1p3 = Math.Sqrt(Math.Pow(p3.X - p1.X, 2) + Math.Pow(p3.Y - p1.Y, 2));

                            double per = p1p2 + p2p3 + p1p3;

                            maxPer = Math.Max(maxPer, per);
                        }
                    }
                }

                if (maxPer == 0)
                {
                    Console.WriteLine("The triangle is not exist");
                }
                else
                {
                    Console.WriteLine("The max perimeter of the triangle : {0}", maxPer);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }

        static double getUserDoubleValue(string nameValue)
        {
            Console.WriteLine(nameValue);
            string s = Console.ReadLine();
            return Convert.ToDouble(s);
        }
    }
}

