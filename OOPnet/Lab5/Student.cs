using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab5
{
    class Student:Candidate
    {
        protected int course;
        public Student() { }

        public Student(string SecondName, DateTime BornYear, string Faculty, int Course): base(SecondName,BornYear,Faculty)
        {
            course = Course;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Course : "+course);
        }


        public override void ReadData(StreamReader MyFile)
        {
            string[] elements = base.ReadDataHelp(MyFile);
            if (elements.Length >= 4)
            {
                int dop = Int32.Parse(elements[3]);
                if (dop >= 1 && dop <= 5)
                {
                    course = dop;
                }
                else
                {
                    throw new FormatException("unncorrect  course");
                }
            }
            else {
                throw new FormatException("unncorrect format of data");
            }
        }

    }
}
