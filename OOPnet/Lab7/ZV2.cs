using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.IO;

namespace OOPnet.Lab7
{
    class ZV2
    {
        public static void ZV2Main()
        {
            Queue<Person> persons = new Queue<Person>();

            string line, path = @"Lab7\ZV2text.txt";

            Console.WriteLine("ZV2------------------------------------");
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    String[] data = line.Split(" ");
                    if (data.Length == 5)
                    {
                        Person NewPerson = new Person(data[0], data[1], data[2], Int32.Parse(data[3]), double.Parse(data[4]));
                        persons.Enqueue(NewPerson);
                    }
                }
            }

            int k = persons.Count;
            Console.WriteLine("Age < 40");
            while (k!=0)
            {
                if (persons.Peek().Age < 40)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(persons.Dequeue());
                    Console.WriteLine("------------------------------------");
                }
                else
                    persons.Enqueue(persons.Dequeue());
                k--;
            }

            if (persons.Count != 0)
            {
                Console.WriteLine("Age >= 40");
                while (persons.Count != 0)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine(persons.Dequeue());
                    Console.WriteLine("------------------------------------");
                }
            }
        }
    }
}
