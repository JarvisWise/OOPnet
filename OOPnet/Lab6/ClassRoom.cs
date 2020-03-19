using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    class ClassRoom: IRoom
    {
        private double side1;
        private double side2;
        private int chairNumber;
        private int windowNumber;

        public ClassRoom() { }
        public ClassRoom(double s1, double s2,int cn, int wn)
        {
            if (s1 > 0) side1 = s1; else side1 = 0;
            if (s2 > 0) side2 = s2; else side2 = 0;
            if (cn > 0) chairNumber = cn; else chairNumber = 0;
            if (wn > 0) windowNumber = wn; else windowNumber = 0;
        }

        public void Show()
        {
            Console.WriteLine("This CassRoom has:");
            Console.WriteLine("Area = "+ Area());
            Console.WriteLine("Number of chairs = " + chairNumber);
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
