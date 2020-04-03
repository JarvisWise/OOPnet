using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace OOPnet.Lab7
{
    public class Example
    {
        public static void EMain()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Queue intQ = new Queue();
            for (int i = 1; i <= n; i++)
                intQ.Enqueue(i);
            Console.WriteLine("Розмірність черги " + intQ.Count);
            Console.WriteLine("Верхній елемент черги = " + intQ.Peek());
            Console.WriteLine("Розмірність черги " + intQ.Count);
            Console.Write("Вміст черги = ");
            while (intQ.Count != 0)
                Console.Write("{0} ", intQ.Dequeue());
            Console.WriteLine("\nНова розмірність черги " + intQ.Count);
        }
    }
}
