using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    public class Square: IMeasurable, IComparable<Square>
    {
        private int edge;


        public Square() { edge = 0; }

        public Square(int e) { if (e > 0) edge = e; else edge = 0; }

        public double Perimeter()
        {
            return 4 * edge;
        }
        public double Area()
        {
            return edge * edge;
        }

        public void Show()
        {
            Console.WriteLine("Square with adge = "+edge);
        }

        public int CompareTo(Square a)
        {
            return this.edge.CompareTo(a.edge);
        }
    }
}
