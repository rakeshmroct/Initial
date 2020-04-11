using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class CGenerics<T> {
        T a;
        public CGenerics(T b){
            a=b;
        }
        public string S()
        {
            return a.GetType().ToString();
        }
    }
}
