using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class B : A
    {
        private int d;

        public B(int A, int B, int D) : base(A,B) { d = D; }
        public B(int D) { d = D; }

        public  int C2 {
            get { return C + d; }
            set { if (value > 0) d = value; }
        }
    }
}
