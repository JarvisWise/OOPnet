using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab7
{
    public class Person
    {
        private string Name1;
        private string Name2;
        private string Name3;
        private int age;
        private double weight;

        public Person()
        {
            Name1 = String.Empty;
            Name2 = String.Empty;
            Name3 = String.Empty;
            age = 0;
            weight = 0;
        }
        public Person(string Name1, string Name2, string Name3, int age, double weight)
        {
            this.Name1 = Name1;
            this.Name2 = Name2;
            this.Name3 = Name3;
            if (age > 0) this.age = age; else age = 0;
            if (weight > 0) this.weight = weight; else weight = 0;
        }

        public int Age{
            get { return age; }
        }


        public override string ToString()
        {
            string line = String.Empty;
            line+=("Name1: "+Name1);
            line+=("\nName2: " + Name2);
            line+=("\nName3: " + Name3);
            line+=("\nAge: " + age);
            line+=("\nWeight: " + weight);
            return line;
        }


    }
}
