﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab4
{
    class CompareName : IComparer<Product>
    {
        public int  Compare(Product a, Product b)
        {        
            return a.ProductName.CompareTo(b.ProductName);
        }
    }
}
