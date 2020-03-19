using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    interface IRoom: IComparable<IRoom>
    {
        void Show();
        double Area();
        int Wn { get; }
    }
}
