using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace OOPnet.Lab7
{
    class ZV3
    {
        public static void ZV3Main()
        {
            ArrayList persons = new ArrayList();

            string line, path = @"Lab7\ZV2text.txt";

            Console.WriteLine("ZV3------------------------------------");
            using (StreamReader MyFile = new StreamReader(path))
            {
                while ((line = MyFile.ReadLine()) != null)
                {
                    String[] data = line.Split(" ");
                    if (data.Length == 5)
                    {
                        Person NewPerson = new Person(data[0], data[1], data[2], Int32.Parse(data[3]), double.Parse(data[4]));
                        persons.Add(NewPerson);
                    }
                }
            }


            persons.Sort(new PersonComparer());

            Console.WriteLine("Sorted array:");
            for (int i = 0; i != persons.Count; i++)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine(persons[i]);
                Console.WriteLine("------------------------------------");
            }
        }
    }
}
