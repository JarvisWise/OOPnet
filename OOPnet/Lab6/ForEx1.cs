using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    class ForEx1
    {
        public static void ZVMain()
        {
            Console.WriteLine("Part 1 -------------------------------------");
            IDemo[] a = new IDemo[4];
            a[0] = new DemoPoint(0, 1);
            a[1] = new DemoPoint(-3, 0);
            a[2] = new DemoShape(3, 4, 0);
            a[3] = new DemoShape(0, 5, 6);
            foreach (IDemo x in a)
            {
                x.Show();
                Console.WriteLine("Dlina={0:f2}", x.Dlina());
                x[0] += 2;
                x[1] += 3;
                Console.WriteLine("x = " + x.X+", y = "+x.Y);
                Console.Write("New coordinate - ");
                x.Show();
                Console.WriteLine();
            }
            Console.WriteLine("Part 2 -------------------------------------");
            Square[] b = new Square[4];
            b[0] = new Square(3);
            b[1] = new Square();
            b[2] = new Square(6);
            b[3] = new Square(2);

            for (int i = 0; i != b.Length; i++)
            {
                b[i].Show();
                Console.WriteLine("Perimeter = " + b[i].Perimeter());
                Console.WriteLine("Area = " + b[i].Area() + "\n");
            }
            Console.WriteLine("Part 3(Sort) -------------------------------");
            Array.Sort(b);
            for(int i = 0; i != b.Length; i++) { 
                b[i].Show();
                Console.WriteLine("Perimeter = " + b[i].Perimeter());
                Console.WriteLine("Area = " + b[i].Area() + "\n");
            }




        }
    }
}
