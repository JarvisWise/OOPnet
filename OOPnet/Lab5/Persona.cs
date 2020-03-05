using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab5
{
    abstract class Persona
    {

        protected DateTime bornYear;
        protected string secondName;

        public abstract void PrintData();
        public abstract void ReadData(StreamReader MyFile);
        public TimeSpan Age()
        {
            //return bornYear.Subtract(DateTime.Today);
            return DateTime.Today.Subtract(bornYear);
        }


                
    }
}
