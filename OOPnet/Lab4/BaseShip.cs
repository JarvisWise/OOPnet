using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class BaseShip
    {
        private string shipName;
        private string purpose;
        private double vWater;
        private double enginePower;
        private string fuelType;

        public BaseShip() {
              shipName = String.Empty ;
              purpose = String.Empty;
              vWater = 0;
              enginePower = 0;
              fuelType = String.Empty;
        }

        public BaseShip(string s, string p, double v, double e, string f)
        {
            shipName = s;
            purpose = p;
            if (v >= 0) vWater = v;
            else vWater = 0;
            if (e >= 0) enginePower = e;
            else enginePower = 0;
            fuelType = f;
        }

        public string ShipName {
            get { return shipName; }
            set { shipName = value; }
        }
        public string Purpose
        {
            get { return purpose; }
            set { purpose = value; }
        }
        public double VWater
        {
            get { return vWater; }
            set { if(value >= 0)vWater = value; }
        }
        public double EnginePower
        {
            get { return enginePower; }
            set { if (value >= 0) enginePower = value; }
        }
        public string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }



    }
}
