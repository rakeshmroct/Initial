using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    interface CInterface
    {
        int a();
        string Name
        {
            get;
            set;
        }
    }
    class CBClass : CInterface
    {
        string CInterface.Name { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        int CInterface.a()
        {
            throw new NotImplementedException();
        }
    }
}
