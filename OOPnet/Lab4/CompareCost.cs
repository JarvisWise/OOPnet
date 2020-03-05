using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class CompareCost: IComparer<Product>
    {
        public int Compare(Product a, Product b)
        {
            return a.Cost.CompareTo(b.Cost);
        }
    }
}
