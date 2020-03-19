using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    class RoomComparer: IComparer<IRoom>
    {
        public int Compare(IRoom a, IRoom b)
        {
            return a.Wn.CompareTo(b.Wn);
        }
    }
}
