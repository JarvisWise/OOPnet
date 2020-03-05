using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab3
{
    class ForEx6
    {
        public static void ZVMain()
        {
            StringBuilder text = new StringBuilder();
            StringBuilder newText = new StringBuilder();

            string words = String.Empty;

            string line;
            using (StreamReader MyFile = new StreamReader(@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab3\TextFor5.txt"))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    text.Append(line + "\n");

                }
            }

            Console.Write("\nEnter word for replase: " );
            string word = Console.ReadLine();



            Console.Write("\nEnter new word: ");
            string newWord = Console.ReadLine();

            newText = text.Replace(word, newWord);
            Console.WriteLine("\n"+newText);


           
            Console.ReadLine();
        }
    }
}
