using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab3
{
    class ForEx5
    {
        public static void ZVMain()
        {
            StringBuilder text = new StringBuilder();
            string words = String.Empty;
            string lastword = String.Empty;

            string line;
            using (StreamReader MyFile = new StreamReader(@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab3\TextFor5.txt"))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    //split
                    int i = 0;
                    while (i < line.Length)
                    {
                        string time = String.Empty;
                        while (i < line.Length && !char.IsLetter(line, i))
                            i++;

                        int j = i;

                        while (j < line.Length && char.IsLetter(line, j))
                            j++;

                        if (i != j)
                        {
                            for (int k = i; k != j; k++)
                            {
                                time += line[k];
                            }
                            //Console.Write(time + " ");
                            lastword = time;
                            //words.Append(time + " ");
                            words += (time + " ");
                        }
                        i = j;

                    }
                    //

                }
            }
            ////////////////////////////////////////////////////////
            ///
            string[] ArrayWord = words.Split(' ');

            Console.WriteLine("\n\n It is line without " + lastword+"!");
            for (int i = 0; i != ArrayWord.Length; i++)
            {
                if (ArrayWord[i] != lastword)
                    Console.Write(ArrayWord[i] + " ");
            }
            Console.ReadLine();





        }
    }
}
