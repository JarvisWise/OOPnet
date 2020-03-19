using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    class MyRoom : IRoom
    {
        private double side1;
        private double side2;
        private int windowNumber;

        public MyRoom() { }
        public MyRoom(double s1, double s2, int wn)
        {
            if (s1 > 0) side1 = s1; else side1 = 0;
            if (s2 > 0) side2 = s2; else side2 = 0;
            if (wn > 0) windowNumber = wn; else windowNumber = 0;
        }

        public void Show()
        {
            Console.WriteLine("This MyRoom has:");
            Console.WriteLine("Area = " + Area());
            Console.WriteLine("Number of windows = " + windowNumber);
        }

        public double Area()
        {
            return side1 * side2;
        }

        public int Wn
        {
            get { return windowNumber; }
        }

        public int CompareTo(IRoom a)
        {
            return Area().CompareTo(a.Area());
        }
    }
}
