using System;
using System.Collections.Generic;
using System.Text;


namespace OOPnet.Lab3
{
    class ForEx1
    {
        public static int size = 20;
        public static int Nmin = 0;
        public static int Nmax = 30;
        public static int Wmin = 0;
        public static int Wmax = 100;


        public static void ZVMain()
        {
            Console.WriteLine("Sort of two arrays");
            int[] weight = new int[size];
            int[] numbers = new int[size];
            Random rnd = new Random();

            Console.WriteLine("Arrays before:");
            for (int i = 0; i != size; i++)
            {
                weight[i] = rnd.Next(Wmin, Wmax);
                Console.Write("W[{0}] = {1}, ", (i + 1), weight[i]);
                numbers[i] = rnd.Next(Nmin, Nmax);
                Console.WriteLine("N[{0}] = {1}", (i + 1), numbers[i]);
            }
            Array.Sort(weight, numbers);
            Console.WriteLine("Arrays after sort:");
            for (int i = 0; i != size; i++)
            {
                Console.Write("W[{0}] = {1}, ", (i + 1), weight[i]);
                Console.WriteLine("N[{0}] = {1}", (i + 1), numbers[i]);
            }

        }

    }
}


