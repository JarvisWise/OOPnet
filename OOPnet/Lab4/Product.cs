using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class Product
    {
        private string productName;
        private string data;
        private double cost;
        private double weight;

       
        public Product() {
            productName = String.Empty;
            data = String.Empty;
            cost = 0;
            weight = 0;
        }

        public Product(string p, string d, double c, double w)
        {
            productName = p;
            data = d;
            if (c >= 0) cost = c;
            else cost = 0;
            if (w >= 0) weight = w;
            else weight = 0;
        }
        public void print()
        {
            Console.WriteLine("Name: " + productName);
            Console.WriteLine("Date: " + data);
            Console.WriteLine("Cost: " + cost);
            Console.WriteLine("Weight: " + weight);
        }


        public string ProductName {
            get { return productName; }
            set { productName = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { if(value>=0) cost = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { if (value >= 0) weight = value; }
        }

        /*public static bool CompareName( Product a,  Product b)
        {
            for (int i = 0; i < a.productName.Length && i < b.productName.Length; i++)
            {
                if (a.productName[i] > b.productName[i])
                {
                    return true;
                } else if (a.productName[i] < b.productName[i])
                {
                    return false;
                }
            }

            if (a.productName.Length > b.productName.Length)
                return true;
            else return false;

        }

        public static bool compareCost(Product a, Product b)
        {
            return a.cost > b.cost;
        }

        public static bool compareWeight(Product a, Product b)
        {
            return a.weight > b.weight;
        }*/

    }
}
