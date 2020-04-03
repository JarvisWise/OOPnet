using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace OOPnet.Lab7
{
    class PersonComparer: IComparer 
    { 

        public int Compare(Object x, Object y)
        {
            Person X = (Person)x;
            Person Y = (Person)y;
            return X.Age.CompareTo(Y.Age);
        }
    }
}
