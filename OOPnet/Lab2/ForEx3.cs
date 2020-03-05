using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab2
{
    class ForEx3
    {
        public static void ZV3Main()
        {
            ForEx3 c = new ForEx3();
            if (c.readMV())
                if (c.CreateR())
                    c.PrintR();
        }

        private double[] A;
        private double[] B;
        private double[] C;
        private int CSize;

        private bool flagR = false;
        private bool flagF = false;



        private bool readMV()
        {
            try
            {
                int n, m;
                Console.WriteLine("Enter size of matrix(n,m):");
                do
                {
                    Console.Write("Size A = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("SIze B = ");
                    m = int.Parse(Console.ReadLine());
                    if (n > 0 && m > 0)
                    {
                        A = new double[n];
                        B = new double[m];
                        break;
                    }
                    else
                        Console.WriteLine("Please enter n and m more then zero!");
                } while (true);

                Console.WriteLine("Enter A[{0}]:", A.Length);
                for (int i = 0; i != A.Length; i++)
                {
                    Console.Write("A[{0}] = ",(i+1));
                    A[i] = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("Enter B[{0}]:", B.Length);
                for (int i = 0; i != B.Length; i++)
                {
                    Console.Write("B[{0}] = ", (i + 1));
                    B[i] = double.Parse(Console.ReadLine());
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

        bool CreateR()
        {
            if (flagR)
            {
                C = new double[A.Length];
                CSize = 0;
                for (int i = 0; i != A.Length; i++)
                {
                    bool f = false;
                    for (int j = 0; j != B.Length; j++)
                        if (A[i] == B[j]) f = true;

                    if (!f)
                        C[CSize++] = A[i];
                }
                flagF = true;
                return true;
            }
            else
                return false;
        }

        void PrintR()
        {
            if (flagF)
            {
                Console.Write(" C =  { ");
                for (int i = 0; i != CSize; i++)
                {
                        Console.Write(C[i] + " ");
                }
                Console.WriteLine("}");

            }
        }
    }
}
