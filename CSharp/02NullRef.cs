using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class NullRef
    {
#nullable enable
        string? r;
#nullable enable
        public void R()
        {
            string f = "fsfd" + r.Length;
            Console.WriteLine("done" + f);
        }
    }
}
