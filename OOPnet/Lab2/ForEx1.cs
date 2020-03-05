using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab2
{
    class ForEx1
    {
        public static void ZV1Main()
        {
            ForEx1 c = new ForEx1();
            if (c.readMV())
                if (c.CreateR())
                    c.PrintR();
        }

        private int ZN, ZM;
        private double[,] M;
        private double[] V;
        private bool flagR = false;
        private double[] R;
        private bool flagF = false;



        private bool readMV()
        {
            try
            {
                int n, m;
                Console.WriteLine("Enter size of matrix(n,m):");
                do
                {
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("m = ");
                    m = int.Parse(Console.ReadLine());
                    if (n > 0 && m > 0)
                    {
                        ZN = n;
                        ZM = m;
                        break;
                    }
                    else
                        Console.WriteLine("Please enter n and m more then zero!");
                } while (true);

                Console.WriteLine("Enter M[{0}][{1}]:", n, m);
                M = new double[n, m];
                for (int i = 0; i != n; i++)
                    for (int j = 0; j != m; j++)
                    {
                        Console.Write("M[{0}][{1}]= ", (i + 1), (j + 1));
                        M[i, j] = double.Parse(Console.ReadLine());
                    }
                Console.WriteLine("\nEnter V[{0}]:", m);
                V = new double[m];
                for (int i = 0; i != m; i++)
                {
                    Console.Write("V[{0}]= ", (i + 1));
                    V[i] = double.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("невірний формат вводу даних");
                return false;
            }
            catch (OverflowException)
            {
                Console.WriteLine("переповнення");
                return false;
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("недостатньо пам'яті для створеннянового об'єкта");
                return false;
            }
            flagR = true;
            return true;
        }

        private bool CreateR()
        {
            if (flagR)
            {
                R = new double[ZN];
                for (int i = 0; i != ZN; i++)
                {
                    for (int j = 0; j != ZM; j++)
                    {
                        R[i] += M[i, j] * V[j];
                    }
                }
                flagF = true;
                return true;
            }
            else
                return false;
        }

        private void PrintR()
        {
            if (flagF) {
                Console.Write("R = { ");
                    for (int i =0;i!=ZN;i++)
                    {
                        Console.Write(R[i]+" ");
                    }
                Console.WriteLine("}");
            }
        }


    }




}

