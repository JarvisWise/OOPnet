using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    interface IDemo
    {
        void Show(); //оголошення методу
        double Dlina(); //оголошення методу
        int X { get; } //оголошення властивості, доступного тільки для читання
        int this[int i] { get; set; } //оголошення індексатора, доступного для читання-запису

        int Y { get; }
    }
}
