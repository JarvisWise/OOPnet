using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab2
{
    class ForEx2
    {
        public static void ZV2Main()
        {
            ForEx2 c = new ForEx2();
            if (c.readMV())
                if (c.CreateR())
                    c.PrintR();
        }

        private int ZN=0, ZM=0;
        private double[,] M;
        private double[] Ser;
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
                Ser = new double[ZN];
                for (int i = 0; i != ZN; i++)
                {
                    double s = 0;
                    for (int j = 0; j != ZM; j++)
                        s += M[i, j];
                    s /= ZM;
                    Ser[i] = s;
                    for (int j = 0; j != ZM; j++)
                        M[i, j] -= s;
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
                for (int i = 0; i != ZN; i++)
                {
                    Console.Write("S[{0}] = {1}, R =  ",(i+1),Ser[i]);
                    Console.Write("{");
                    for (int j = 0; j != ZM; j++)
                    {
                        Console.Write(M[i,j] + " ");
                    }
                    Console.WriteLine("}");
                }
               
            }
        }

    }
}
