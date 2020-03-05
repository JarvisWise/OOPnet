using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab1
{
    class ForEx4
    {
        private static double a;
        private static double b;
        private static double res;
        private static String sym;


        public static double calculator()
        {
            do{
                Console.WriteLine("Enter your operation(^,sqrt,%) in format(a operation b): ");
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("operation(^,sqrt,%): ");
                sym = Console.ReadLine();
                if (!sym.Equals("sqrt"))
                {
                    Console.Write("b = ");
                    b = double.Parse(Console.ReadLine());
                }
                else
                    b = 0;

                if (sym.Equals("^") || sym.Equals("sqrt") || sym.Equals("%"))
                    break;
                else
                    Console.WriteLine("You enter unccorect operation, please try again!");
            } while (true);

            switch(sym)
            {
                case ("^"):
                    res = Math.Pow(a, b);
                    break;
                case ("sqrt"):
                    res = Math.Sqrt(a);
                    break;
                case ("%"):
                    res = (a*100)/b;//сколько проц составляет число а от числа в
                    break;
                default:
                    res = 0;
                    break;
            }
            return res;
        }
    }
}
