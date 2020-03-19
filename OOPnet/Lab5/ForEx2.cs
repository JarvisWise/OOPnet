using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab5
{
    class ForEx2
    {
        public static void ZVMain()
        {
            Book[] array = new Book[5];
            array[0] = new Book("Bill", "Smith", "Amazing world", "46512532", 1975, 439, "novel");
            array[1] = new Book("Bob", "Smith", "Treasure shop", "98985463", 1860, 231, "novel");
            array[2] = new Book("Tom", "Smith", "Warriors of Rome", "56363616", 2001, 195, "novel");
            array[3] = new Book("Max", "Smith", "Creepy fish", "46512532", 1943, 511, "novel");
            array[4] = new Book("Will", "Smith", "Underground word", "67365736", 1833, 533, "novel");

            for (int i = 0;i!= array.Length; i++)
            {
                Console.WriteLine("Book number {0}:\n"+array[i]+"\n-----------------",(i+1));
            }

            Console.Write("\nEnter one of code: ");
            string newCode = String.Empty;
            newCode = Console.ReadLine();
            Book b1 = Book.findByCode(array, newCode);
            if (b1 != null)
                Console.WriteLine("This is book with code " + newCode + ": " + b1);
            else Console.WriteLine("Book did not find!");

            int a, b;
            do {
                Console.WriteLine("\nEnter two numbers of books(1-5):");
                Console.Write("a = ");
                a = Int32.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = Int32.Parse(Console.ReadLine());

                if (a >= 1 && a <= 5 && b >= 1 && b <= 5)
                    break;
                else
                    Console.WriteLine("Try again!");

            } while (true);

            int z = array[a - 1].CompareByPages(array[b - 1]);
            if (z > 0)
            {
                Console.WriteLine("Book {0} has more pages than book {1}!\n" +"\n\nBook {0}:" + array[a - 1] +"\n\nBook {1}:"+ array[b - 1],a,b);
            }
            else if (z < 0) {
                Console.WriteLine("Book {1} has more pages than book {0}!\n" + "\n\nBook {0}:" + array[a - 1] + "\n\nBook {1}:" + array[b - 1], a, b);

            }
            else
                Console.WriteLine("Books {0} and {1} have same number of pages!\n" + "\n\nBook {0}:" + array[a - 1] + "\n\nBook {1}:" + array[b - 1], a, b);

        }
    }
}
