using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace OOPnet.Lab7
{
    class ZV5
    {
        public static void ZV5Main()
        {
            ArrayList list = new ArrayList();
            int size = 1840, varNumber=8;
            Random rnd = new Random();

            //random
            for (int i = 0; i != size; i++)
                list.Add( (int)(rnd.Next()%301+400));

            //
            Console.WriteLine("Start list: ");
            /*for(int i=0;i!=list.Count;i++)
            {
                Console.Write(list[i]+"\t");
                if (i % 10 == 0)
                    Console.WriteLine();
            }*/
            int k = 0;
            foreach (int x in list)
            {
                k++;
                Console.Write(x + "\t");
                if (k % 10 == 0)
                    Console.WriteLine();
                
            }
            Console.WriteLine("\n-------------------------------------------------");

            //sorted
            list.Sort();
            Console.WriteLine("Sorted list: ");
            k = 0;
            foreach (int x in list)
            {
                k++;
                Console.Write(x + "\t");
                if (k % 10 == 0)
                    Console.WriteLine();
               
            }
            Console.WriteLine("\n-------------------------------------------------");

            //add var
            list[varNumber] = varNumber;
            Console.WriteLine("varNumber add to position "+varNumber+" at list: ");
            k = 0;
            foreach (int x in list)
            {
                k++;
                Console.Write(x + "\t");
                if (k % 10 == 0)
                    Console.WriteLine();

            }
            Console.WriteLine("\n-------------------------------------------------");

            int newNumber = (rnd.Next() % varNumber + 1) + 1000;
            Console.WriteLine("Try to find number: "+newNumber+" at list ");
            int index = list.IndexOf(newNumber);

            if (index == -1)
                Console.WriteLine("Number " + newNumber + " did not find at lise!");
            else
                Console.WriteLine("Number "+newNumber+ " has index at list: "+index+"!");
            Console.WriteLine("\n-------------------------------------------------");

            newNumber = (rnd.Next() % (size+1));
            Console.WriteLine("Try to delete number: " + newNumber + " at list ");
            index = list.IndexOf(newNumber);
            
            if (index == -1)
            {
                Console.WriteLine("Number " + newNumber + " did not find at lise!");
            }
            else
            {
                list.Remove(newNumber);
                Console.WriteLine("Number " + newNumber + " removed from list!");
            }
            Console.WriteLine("\n-------------------------------------------------");

            Console.WriteLine("Before delete all list: ");
            k = 0;
            foreach (int x in list)
            {
                k++;
                Console.Write(x + "\t");
                if (k % 10 == 0)
                    Console.WriteLine();

            }
            Console.WriteLine("\n-------------------------------------------------");

            list.Clear();
            Console.WriteLine("After delete all list: ");
            k = 0;
            foreach (int x in list)
            {
                k++;
                Console.Write(x + "\t");
                if (k % 10 == 0)
                    Console.WriteLine();

            }
            Console.WriteLine("\n-------------------------------------------------");



        }
    }
}
