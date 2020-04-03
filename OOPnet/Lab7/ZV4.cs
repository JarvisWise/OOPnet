using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace OOPnet.Lab7
{
    class ZV4
    {
        public static void ZV4Main()
        {
            Stack<int> numbers = new Stack<int>();

            string line, path1 = @"Lab7\ZV4read.txt", path2 = @"Lab7\ZV4print.txt";

            Console.WriteLine("ZV4------------------------------------");
            Console.WriteLine("Read: ");
            using (StreamReader MyFile = new StreamReader(path1))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    String[] data = line.Split(" ");
                    for (int i = 0; i != data.Length; i++)
                    {
                        
                        /*bool flag = true;
                        for (int j = 0; j != data[i].Length; j++)
                            if (!Char.IsDigit(data[i][j]))
                                flag = false;

                        if(flag)*/
                        numbers.Push(Int32.Parse(data[i]));
                        Console.Write(data[i]+" ");
                    }
                }
            }
            Console.WriteLine("\nPrint: ");
            using (StreamWriter MyFile = new StreamWriter(path2))
            {
                while (numbers.Count != 0)
                {
                    int number = numbers.Pop();
                    MyFile.Write(number + " ");
                    Console.Write(number + " ");
                }
            }
        }
    }
}
