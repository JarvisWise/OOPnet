using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab1
{
    public class ForEx1
    {
        public static void ZV1Main()
        {
            double Y;
            ForEx1 sample = new ForEx1();

            Console.WriteLine("Enter data for calculation:");
            if (sample.readData())
            {
                sample.calculation();
                Y = sample.getY();
                Console.WriteLine("Y = " + Y);
            }
            else
            {
                Console.WriteLine("Uncorrect data!");
            }
        }

        double c, a, x,y;
        bool read,cFlag;

        public ForEx1() {
            c = 0;
            a = 0;
            x = 0;
            y = 0;
            read = false;
            cFlag = false;

        }

        public bool readData()
        {
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());
            Console.Write("a = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("x = ");
            x = double.Parse(Console.ReadLine());

            if (x > 0 && (2 * Math.Sin(Math.PI / 3 + x)) != 0)
            {
                read = true;
                return true;
            }
            else
            {
                c = 0;
                a = 0;
                x = 0;
                return false;
            }
        }

        public void calculation() {
            if (read)
            {
                y = powForN(c * x - a, 1.0 / 3) + (Math.Log(x) / (2 * Math.Sin(Math.PI / 3 + x)));
                cFlag = true;
            }
        }

        public double getY()
        {
            if (cFlag)
                return y;
            else
                return 0;
        }

        private static double powForN(double a, double b)
        {
            if (a < 0)
                return -Math.Pow(-a, b);
            else
                return Math.Pow(a, b);
        }
    }
}

/*static void Main(string[] args)
{
    double y;
    ForEx1 sample = new ForEx1();

    Console.WriteLine("Enter data for calculation:");
    if (sample.readData())
    {
        sample.calculation();
        y = sample.getY();
        Console.WriteLine("Y = " + y);
    }
    else
    {
        Console.WriteLine("Uncorrect data!");
    }
}*/
