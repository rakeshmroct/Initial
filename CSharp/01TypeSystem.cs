using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class CTypeSystem
    {
        void MethodAccessException()
        {
            //Types, variables, and values
            //Built -in types
            //Custom types - struct, class, interface, enum
            //The common type system - inheritence, value/reference
            //Types of literal values
            //Generic types
            //Implicit types, anonymous types, and nullable value types


            var anonArray = new[] { new { name = "apple", diam = 4 }, new { name = "grape", diam = 1 } };
            int a = 5;
            int b = a + 2; //OK

            bool test = true;

            // Error. Operator '+' cannot be applied to operands of type 'int' and 'bool'.
            //int c = a + test;
        }

    }
}
