using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab5
{
    class Teacher:Candidate
    {
        protected string position;
        protected int experience;

        public Teacher() { }

        public Teacher(string SecondName, DateTime BornYear, string Faculty, string Position, int Experience) : base(SecondName, BornYear, Faculty)
        {
            position = Position;
            if (Experience >= 0) experience = Experience;
            else experience = 0;
        }

        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("Position : " + position);
            Console.WriteLine("Experience : " + experience);
        }


        public override void ReadData(StreamReader MyFile)
        {
            string[] elements = base.ReadDataHelp(MyFile);
            if (elements.Length >= 5)
            {
                position = elements[3];
                experience = Int32.Parse(elements[4]);
            }
            else
            {
                throw new FormatException("unncorrect format of data");
            }
        }
    }
}
