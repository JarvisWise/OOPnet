using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab1
{
    class ForEx2
    {

        public static void ZV2Main()
        {
            double[] result;
            ForEx2 sample = new ForEx2();

            Console.WriteLine("Enter data for tabulation:");
            if (sample.readData())
            {
                sample.tabulation();
                try
                {
                    result = sample.getRes();
                    for (int i = 0; i != result.Length; i++)
                    {
                        Console.WriteLine("Y[" + (i + 1) + "] = " + result[i]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Uncorrect data!");
            }
        }
    

        double xMin, xMax, Dx, c;
        double[] res;
        bool read, cFlag;

        public ForEx2()
        {
            xMin = 0;
            xMax = 0;
            Dx = 0;
            c=0;
            res = null;
            read = false;
            cFlag = false;
        }

        public bool readData()
        {
            Console.Write("xMin = ");
            xMin = double.Parse(Console.ReadLine());
            Console.Write("xMax = ");
            xMax = double.Parse(Console.ReadLine());
            Console.Write("Dx = ");
            Dx = double.Parse(Console.ReadLine());
            Console.Write("c = ");
            c = double.Parse(Console.ReadLine());

            if (xMin < xMax && Dx>0)
            {
                res = new double[(int)((xMax - xMin) / Dx)];
                read = true;
                return true;
            }
            else
            {
                xMin = 0;
                xMax = 0;
                Dx = 0;
                c = 0;
                return false;
            }
        }

        public void tabulation()
        {
            if (read)
            {
                int n = 0;
                for (double i = xMin; i <= xMax && n != res.Length; i += Dx, n++)
                {
                    if (i * i + 1 > 0)
                    {
                        res[n] = powForN(c * c * i * i + 2, 1.0 / 3) + (Math.Log(i * i + 1) / (2 * Math.PI));
                    }
                    else
                    {
                        res[n] = 0;
                    }
                }
                cFlag = true;
            }
        }

        public double[] getRes()
        {
            if (cFlag)
                return res;
            else
                throw new Exception("You must tabulate function befor using this metod!");
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

/*double[] result;
ForEx2 sample = new ForEx2();

Console.WriteLine("Enter data for tabulation:");
            if (sample.readData())
            {
                sample.tabulation();
                try
                {
                    result = sample.getRes();
                    for (int i = 0; i != result.Length; i++)
                    {
                        Console.WriteLine("Y["+(i+1)+"] = " + result[i]);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Uncorrect data!");
            }
        }*/
