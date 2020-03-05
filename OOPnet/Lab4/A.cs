using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class A
    {
        private int a;
        private int b;

        public A() { a = 5;b = 10; }
       public A(int A, int B) { a = A; b = B; }

        public int C {
            get { return b / a; }
            set {  }
        }
    }
}
