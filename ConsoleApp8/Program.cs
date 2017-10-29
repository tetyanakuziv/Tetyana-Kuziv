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
            try
            {
                double w = getUserDoubleValue("width of area");
                if (w <= 0)
                {
                    Console.WriteLine("width cannot be <= 0");
                    Console.ReadKey();
                    return;
                }

                double h = getUserDoubleValue("height of area");
                if (h <= 0)
                {
                    Console.WriteLine("height cannot be <= 0");
                    Console.ReadKey();
                    return;
                }

                double x = getUserDoubleValue("x");
                if (x < 0)
                {
                    Console.WriteLine("x cannot be <0");
                    Console.ReadKey();
                    return;
                }

                double y = getUserDoubleValue("y");
                if (y < 0)
                {
                    Console.WriteLine("y cannot be < 0");
                    Console.ReadKey();
                    return;
                }

                double vx = getUserDoubleValue("speed Vx");
                double vy = getUserDoubleValue("speed Vy");

                Point point = new Point();
                point.X = x;
                point.Y = y;
                point.Vx = vx;
                point.Vy = vy;

                int tmax = getUserIntValue("tmax");
                if (tmax <= 0)
                {
                    Console.WriteLine("tmax cannot be <= 0");
                    Console.ReadKey();
                    return;
                }

                for (int t = 0; t <= tmax; t++)
                {
                    Console.WriteLine("{0} {1} {2}", t, point.X, point.Y);
                    point.X += point.Vx;
                    point.Y += point.Vy;

                    checkDirection(point, w, h);
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
            Console.WriteLine("Please enter {0}", nameValue);
            string s = Console.ReadLine();
            return Convert.ToDouble(s);
        }

        static int getUserIntValue(string nameValue)
        {
            Console.WriteLine("Please enter {0}", nameValue);
            string s = Console.ReadLine();
            return Convert.ToInt32(s);
        }

        static void checkDirection(Point point, double xmax, double ymax)
        {
            if (point.X < 0)
            {
                point.X = -point.X;
                point.Vx = -point.Vx;
            }

            if (point.Y < 0)
            {
                point.Y = -point.Y;
                point.Vy = -point.Vy;
            }

            if (point.X >= xmax)
            {
                point.X = xmax - (point.X - xmax);
                point.Vx = -point.Vx;
            }

            if (point.Y >= ymax)
            {
                point.Y = ymax - (point.Y - ymax);
                point.Vy = -point.Vy;
            }
        }

    }

}

