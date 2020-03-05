using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab2
{
    class ForEx4
    {
        private static int el=-1;
        private static double x;
        private static double res;
        private static String sym;
        private static String[] s =new String[]{"first","First","FIRST","second","Second","SECOND","third","Third","THIRD"};


        public static double ZV4Main()
        {
            do
            {
                Console.WriteLine("Enter x and choose function: ");
                Console.Write("x = ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("For f(x) = (sin(x))^2,enter(first,First,FIRST)");
                Console.WriteLine("For f(x) = (log(x))^2,enter(second,Second,SECOND)");
                Console.WriteLine("For f(x) = 1/cos(x^3),enter(third,Third,THIRD)");
                Console.Write("Enter function: ");
                sym = Console.ReadLine();

                bool f = false;
                for (int i = 0; i != s.Length; i++)
                    if (sym.Equals(s[i]))
                    {
                        f = true;
                        el = i;
                    }
                if (f)
                    break;
                else
                    Console.WriteLine("You enter unccorect operation, please try again!");
            } while (true);

            switch (el)
            {
                case 0:
                case (1):
                case (2):
                    res = Math.Pow(Math.Sin(x),2);
                    break;
                case (3):
                case (4):
                case (5):
                    if(x>0)
                    res = Math.Pow(Math.Log(x),2);
                    else
                    Console.WriteLine("Cannot solve Log(x)^2");
                    break;
                case (6):
                case (7):
                case (8):
                    if (Math.Cos(x*x*x)!=0)
                        res = 1/(Math.Cos(x*x*x));
                    else
                        Console.WriteLine("Cannot solve 1/cos(x^3)");
                    break;
                default:
                    break;
            }
            return res;
        }
    }
}
