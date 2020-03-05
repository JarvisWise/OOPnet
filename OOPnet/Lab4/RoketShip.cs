using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class RoketShip: BaseShip
    {
        private string roketType;
        private int roketNumber;

        public RoketShip() : base()
        {
            roketType = String.Empty;
            roketNumber = 0;
        }

        public RoketShip(string s, string p, double v, double e, string f, string rt, int rn) : base(s, p, v, e, f)
        {
            roketType = rt;
            if (rn >= 0) roketNumber = rn;
            else roketNumber = 0;
        }

        public int RoketNumber
        {
            get { return roketNumber; }
            set { if (value >= 0) roketNumber = value; }
        }
        public string RoketType
        {
            get { return roketType; }
            set { roketType = value; }
        }
    }
}
