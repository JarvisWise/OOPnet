using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace OOPnet.Lab3
{
    class ForEx3
    {
 
       
            public static void ZVMain(string path)
            {
                int counter = 0; // лічильник слів, де d стоїть на 2-му місці
                string line; // допоміжний рядок
                char[] separator = { ' ', '.', '*', '+', ';', ',', '?', '!', '‐', '/' }; // масив
                StringBuilder otvet = new StringBuilder(); // рядок-відповідь
                using (StreamReader MyFile = new StreamReader(path))
                {
                    // читання рядка з файлу, поки це можливо
                    while ((line = MyFile.ReadLine()) != null)
                    {
                        Console.WriteLine(line); // друкуємо, що прочитали
                                                 //виділяємо слова
                        string[] words = line.Split(separator);
                        foreach (string slovo in words) //цикл за словами, цикл foreach
                        {
                            if ((slovo.Length >= 2) && (slovo[1] == 'd'))
                            {
                                counter++;
                                otvet.Append(slovo);
                                otvet.Append(" ");
                            }
                        }
                    }
                }
                Console.WriteLine("\n\nThere were {0} sequences.", counter);
                Console.WriteLine(otvet.ToString());
                Console.ReadLine();
            }
        
    }
}

