using System;
using System.Collections;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            CLINQ d = new CLINQ();
            d.a();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }

        private static void D_Progress(object sender, string e)
        {
            Console.WriteLine("Event occured!");
        }
    }
}
