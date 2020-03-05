using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab3
{
    class ForEx4
    {

        public static void ZVMain()
        {
            byte dcounter = 0, // лічильник груп цифр
      wcounter = 0; // лічильник груп букв
            string stroka;
            int i;
            using (StreamReader MyFile = new StreamReader(@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab3\text1.txt"))
            {
                // поки файл не пустий, читаємо рядок
                while ((stroka = MyFile.ReadLine()) != null)
                {
                    Console.WriteLine(stroka);
                    i = 0; // індекс символа в рядку
                    while (i < stroka.Length)
                    {
                        // цикл, поки не зустрінеться цифра або буква або кінець рядка
                        while ((i < stroka.Length) && !(char.IsLetterOrDigit(stroka, i)))
                        {
                            i++;
                        }
                        // зустрілася цифра і рядок не закінчилася
                        if ((i < stroka.Length) && (char.IsDigit(stroka, i)))
                            dcounter++;
                        // цикл поки черговий символ - цифра
                        while ((i < stroka.Length) && (char.IsDigit(stroka, i)))
                        {
                            i++;
                        }
                        // зустрілася буква і рядок не закінчився
                        if ((i < stroka.Length) && (char.IsLetter(stroka, i)))
                            wcounter++;
                        // цикл поки черговий символ - буква
                        while ((i < stroka.Length) && (char.IsLetter(stroka, i)))
                        {
                            i++;
                        }
                    }
                }
            }
            // порівняння лічильників і вивід результату
            if (wcounter > dcounter)
            {
                Console.Write("Груп букв більше: ");
                Console.WriteLine("{0}>{1}", wcounter, dcounter);
            }
            else if (dcounter > wcounter)
            {
                Console.Write(" Груп цифр більше: ");
                Console.WriteLine(" {0}>{1}.", dcounter, wcounter);
            }
            else
            {
                Console.Write(" Груп цифр і букв рівна кількість: ");
                Console.WriteLine(" {0} = {1}.", wcounter, dcounter);
            }
            Console.ReadLine();
        }

        
    }
}
