using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOPnet.Lab5
{
    class ForEx1
    {
        public static void ZVMain()
        {
            try
            {
                using (StreamReader MyFile = new StreamReader(@"C:\Users\User\source\repos\OOPnet\OOPnet\Lab5\ForEx1.txt"))
                {
                    Persona candidate = new Candidate();
                    try
                    {
                        candidate.ReadData(MyFile);
                        Console.WriteLine("Example of Candidate");
                        candidate.PrintData();
                        Console.WriteLine("--------------------\n");

                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                   
                    Persona student = new Student();
                    try
                    {
                        student.ReadData(MyFile);
                        Console.WriteLine("Example of Student");
                        student.PrintData();
                        Console.WriteLine("--------------------\n");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                   

                    Persona teacher = new Teacher();
                    try
                    {
                        teacher.ReadData(MyFile);
                        Console.WriteLine("Example of Teacher");
                        teacher.PrintData();
                        Console.WriteLine("--------------------\n");
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                   
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }



        }

    }
}
