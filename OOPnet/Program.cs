using System;
using OOPnet.Lab3;
using OOPnet.Lab4;
using OOPnet.Lab5;

namespace OOPnet
{
    class Program
    {
        static void Main(string[] args)
        {
            //zv1
            /*Console.WriteLine("------------------Testing function from 1------------------");
            ForEx1.ZV1Main();
            Console.WriteLine("\n-----------------------------------------------------------");

            //zv2
            Console.WriteLine("------------------Testing function from 2------------------");
            ForEx2.ZV2Main();
            Console.WriteLine("\n-----------------------------------------------------------");

            //zv3
            Console.WriteLine("------------------Testing function from 3------------------");
            ForEx3.ZV3Main();
            Console.WriteLine("\n-----------------------------------------------------------");

            //zv4
            Console.WriteLine("------------------Testing function from 4------------------");
            double res = ForEx4.ZV4Main();
            Console.Write("Result = " + res);
            Console.WriteLine("\n-----------------------------------------------------------");
            */////////////////////////////////
              //lab3
            /*
          Console.WriteLine("ZV1---------------------------------------------------");
            ForEx1.ZVMain();
          Console.WriteLine("ZV2---------------------------------------------------");
          ForEx2.ZVMain();
          Console.WriteLine("ZV3---------------------------------------------------");
          ForEx3.ZVMain(@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab3\test1.txt");
          ForEx3.ZVMain(@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab3\test2.txt");
          //ForEx3.ZVMain(@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab3\test3.txt");

          Console.WriteLine("ZV4---------------------------------------------------");
          ForEx4.ZVMain();
          Console.WriteLine("ZV5---------------------------------------------------");
          ForEx5.ZVMain();
          Console.WriteLine("ZV6---------------------------------------------------");
          ForEx6.ZVMain();*/


            //lab4
            //zv1
            
            /*Console.WriteLine("ZV1--------------------------------------------");
            A a = new A();
            Console.WriteLine("This is property C of class A: "+a.C);

            //zv2
            Console.WriteLine("ZV2--------------------------------------------");
            A a1 = new A();
            Console.WriteLine("This is property C of object a1: "+a1.C);
            A a2 = new A(3, 9);
            Console.WriteLine("This is property C of object a2: " + a2.C);
            B b1 = new B(1, 3, 3);
            Console.WriteLine("This is property C2 of object b1: " + b1.C2);
            B b2 = new B(9);
            Console.WriteLine("This is property C2 of object b2: " + b2.C2);

            //zv3
            Console.WriteLine("ZV3------------------------------------------");
            BaseShip bs = new BaseShip("Nova","trade",12500, 3500, "petrol" );
            Console.WriteLine("\nBaseShip sample:");
            Console.WriteLine("Name: "+bs.ShipName);
            Console.WriteLine("Purpose: "+ bs.Purpose);
            Console.WriteLine("vWater: "+ bs.VWater);
            Console.WriteLine("Engine power: "+bs.EnginePower);
            Console.WriteLine("Type of fuel: "+bs.FuelType);
            AirShip ais = new AirShip("Avrora", "navy", 21500, 1300, "organic","force aircraft",15);
            Console.WriteLine("\nAirShip sample:");
            Console.WriteLine("Name: " + ais.ShipName);
            Console.WriteLine("Purpose: "+ais.Purpose);
            Console.WriteLine("vWater: "+ais.VWater);
            Console.WriteLine("Engine power: "+ais.EnginePower);
            Console.WriteLine("Type of fuel: "+ais.FuelType);
            Console.WriteLine("Type of planes: " + ais.PlaneType);
            Console.WriteLine("Number of planes: " + ais.PlaneNumber);
            RoketShip rs = new RoketShip("Apolon", "navy", 11900, 2015, "petrol", "jetroket", 50);
            Console.WriteLine("\nRoketShip sample:");
            Console.WriteLine("Name: " + rs.ShipName);
            Console.WriteLine("Purpose: " + rs.Purpose);
            Console.WriteLine("vWater: " + rs.VWater);
            Console.WriteLine("Engine power: " + rs.EnginePower);
            Console.WriteLine("Type of fuel: " + rs.FuelType);
            Console.WriteLine("Type of rokets: " + rs.RoketType);
            Console.WriteLine("Number of rokets: " + rs.RoketNumber);

            //zv4
            Console.WriteLine("ZV4--------------------------------------------");
            Store.ZVMain();*/
            

            //lab5
            Lab5.ForEx1.ZVMain();

            Lab5.ForEx2.ZVMain();


        }
    }
}
