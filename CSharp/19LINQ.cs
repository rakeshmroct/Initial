using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp
{
    class CLINQ
    {
        // Specify the data source.
        int[] scores = new int[] { 97, 92, 81, 60 };
        public void a()
        {
            // Define the query expression.
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            // Execute the query.
            foreach (int i in scoreQuery)
            {
                Console.Write(i + " ");
            }
        }
}
}
