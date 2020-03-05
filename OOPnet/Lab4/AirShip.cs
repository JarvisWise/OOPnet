using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class AirShip: BaseShip
    {
        private string planeType;
        private int planeNumber;

        public AirShip() : base() {
            planeType = String.Empty;
            planeNumber = 0;
        }

        public AirShip(string s, string p, double v, double e, string f,string pt, int pn):base(s,p,v,e,f)
        {
            planeType = pt;
            if (pn >= 0) planeNumber = pn;
            else planeNumber = 0;
        }

        public int PlaneNumber
        {
            get { return planeNumber; }
            set { if (value >= 0) planeNumber = value; }
        }
        public string PlaneType
        {
            get { return planeType; }
            set { planeType = value; }
        }

    }
}
