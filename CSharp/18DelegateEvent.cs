using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    class CEvent
    {


        public event EventHandler<string> Progress;
        public string file = "fds";
        public void a(string _)
        {
            Progress += CEvent_Progress;
            Progress?.Invoke(this, "hello");
        }
         
        private void CEvent_Progress(object sender, string e)
        {
            throw new NotImplementedException();
        }
    }
    


}
