using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab7
{
    class ZV1
    {
        public static void ZV1Main()
        {
            List<Char> symbols = new List<Char>();
            //@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab3\test1.txt"
            string line, path= @"Lab7\ZV1text.txt";

            Console.WriteLine("ZV1------------------------------------");
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    foreach (Char c in line)
                        symbols.Add(c);
                    symbols.Add('\n');
                }
            }

            int leftBracket = 0, rightBracket = 0;
            Console.WriteLine("Text from file:");
            for (int i = 0; i != symbols.Count; i++)
            {
                Console.Write(symbols[i]);
                if (symbols[i] == '(')
                    leftBracket++;
                else if (symbols[i] == ')')
                    rightBracket++;
            }

            Console.Write("Result: ");
            if (leftBracket == rightBracket)
            {
                Console.WriteLine("Number of symbol \'(\' == Number of symbol \')\'");
            }
            else if (leftBracket > rightBracket)
            {
                Console.WriteLine("Number of symbol \'(\' > Number of symbol \')\'");
            }
            else {
                Console.WriteLine("Number of symbol \'(\' > Number of symbol \')\'");
            }
        }
    }
}
