using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class CDeconstruct
    {
        public (string,string) a()
        {
            var d = ("Hello", "World");
            (string a, string b) = d;
            return (a, b);
        }
        

    }
}
