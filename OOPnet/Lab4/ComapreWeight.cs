using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class ComapreWeight : IComparer<Product>
    {
        public int Compare(Product a, Product b)
        {
            return a.Weight.CompareTo(b.Weight);
        }
    }
}
