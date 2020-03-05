using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab3
{
    class ForEx2
    {
        public static int size = 0;
        public static int Wmin = 20;
        public static int Wmax = 150;
        public static int Hmin = 100;
        public static int Hmax = 210;


        public static void ZVMain()
        {
            do
            {
                Console.Write("Please Enter number of workers: ");
                size = Int32.Parse(Console.ReadLine());
                if (size > 0)
                    break;
                else
                    Console.WriteLine("Enter number of workers again!");


            } while (true);

            Console.WriteLine("Sort of two arrays");
            int[] height = new int[size];
            int[] weight = new int[size];
            Random rnd = new Random();

            Console.WriteLine("Arrays before:");
            for (int i = 0; i != size; i++)
            {
                height[i] = rnd.Next(Hmin, Hmax);
                Console.Write("H[{0}] = {1}, ", (i + 1), height[i]);
                weight[i] = rnd.Next(Wmin, Wmax);
                Console.WriteLine("W[{0}] = {1}", (i + 1), weight[i]);
            }
            Array.Sort(height, weight);
            Console.WriteLine("\nArrays after sort:\n");
            for (int i = 0; i != size; i++)
            {
                Console.Write("H[{0}] = {1}, ", (i + 1), height[i]);
                Console.WriteLine("W[{0}] = {1}", (i + 1), weight[i]);
            }

        }

    }
}
