using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptioon
{
    class Reverse : IEncryption
    {
        public string encryptString(string s)
        {
            string str = "";
            char[] c = s.ToCharArray();
            c = c.Reverse().ToArray();
            str = new string(c);
            return str;
        }
    }
}
