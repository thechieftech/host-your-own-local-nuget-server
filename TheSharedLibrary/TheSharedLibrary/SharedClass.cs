using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSharedLibrary
{
    public class SharedClass
    {
        public string SayMyName(string theName)
        {
            return string.Format("Your name is {0}", theName);
        }
    }
}
