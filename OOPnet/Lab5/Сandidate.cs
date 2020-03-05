using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab5
{
    class Candidate : Persona
    {
        protected string faculty;

       public Candidate() { }

        public Candidate(string SecondName, DateTime BornYear, string Faculty)
        {
            secondName = SecondName;
            bornYear = BornYear;
            faculty = Faculty;
        }



        public override void PrintData()
        {
            Console.WriteLine("SecondName : "+ secondName);
            Console.WriteLine("Age : " + (int)(Age().Days/365));//
            Console.WriteLine("Faculty : "+ faculty);
        }
        protected string[] ReadDataHelp(StreamReader MyFile)
        {
            string[] elements;
            string line = MyFile.ReadLine();
            if (line != null)
            {
                elements = line.Split(' ');
                if (elements.Length >= 3)
                {
                    secondName = elements[0];
                    string[] date = elements[1].Split('/');
                    if (date.Length == 3)
                    {
                        bornYear = new DateTime(Int32.Parse(date[0]), Int32.Parse(date[1]), Int32.Parse(date[2]));//2011/7/22
                    }
                    else
                    {
                        throw new FormatException("unncorrect format of date");
                    }

                    faculty = elements[2];
                }
                else
                {
                    throw new FormatException("unncorrect format of data");
                }
            }
            else {
                throw new NullReferenceException("Problem with data file!");
            }
            return elements;
        }

        public override void ReadData(StreamReader MyFile)
        {
            ReadDataHelp(MyFile);
        }
    }
}
