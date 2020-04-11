using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class Clambda
    {
        public void a()
        {
            Func<int,int> d=(a) => { Console.WriteLine(a);return a; };
        }
    }
}
