using System;
using System.Collections.Generic;
using System.Text;

namespace OOPnet.Lab6
{
    class ForEx2
    {
        public static void ZVMain()
        {
            IRoom[] arr = new IRoom[8];

            arr[0] = new ClassRoom(10,12,32,4);
            arr[1] = new ClassRoom(8, 7, 20, 3);
            arr[2] = new ClassRoom(20, 16, 40, 5);
            arr[3] = new ClassRoom(100, 56, 100, 7);

            arr[4] = new MyRoom(5, 6, 1);
            arr[5] = new MyRoom(8, 9, 1);
            arr[6] = new MyRoom(4, 10, 2);
            arr[7] = new MyRoom(13, 5, 3);

            Console.WriteLine("Start Data ------------------");
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine("Room[{0}]:",(i+1));
                arr[i].Show();
                Console.WriteLine();
            }
               
            Console.WriteLine("Sort by Area ------------------");
            Array.Sort(arr);
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine("Room[{0}]:", (i + 1));
                arr[i].Show();
                Console.WriteLine();
            }
            Console.WriteLine("Sort by Number of Windows ------------------");
            Array.Sort(arr, new RoomComparer());
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine("Room[{0}]:", (i + 1));
                arr[i].Show();
                Console.WriteLine();
            }
        }
    }
}
