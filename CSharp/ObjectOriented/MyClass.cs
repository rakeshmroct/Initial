using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.ObjectOriented
{
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("MyClass Constructor Created");
        }
        public void rest()
        {
            Console.WriteLine("Resting in MyClass");
        }
        public virtual void walk()
        {
            Console.WriteLine("MyClass walking");
        }
    }
}
