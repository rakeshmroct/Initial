using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class CIndexer
    {
        int[] a = { 2, 3, 4, 5, 6 };
        public int this[int c]{
            get
            {
                return a[c];
            }
            
       }
    }
}
