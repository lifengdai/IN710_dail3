using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptioon
{
    class Rot13 : IEncryption
    {
        public string encryptString(string s)
        {
            char[] c = s.ToCharArray();
            for (int k = 0; k < c.Length; k++)
            {
                int i = c[k];
                if (i >= 'a' && i <= 'z')
                {
                    if (i > 'm')
                    {
                        i -= 13;
                    }
                    else
                    {
                        i += 13;
                    }
                }
                else if (i >= 'A' && i <= 'Z')
                {
                    if (i > 'M')
                    {
                        i -= 13;
                    }
                    else
                    {
                        i += 13;
                    }
                }
                c[k] = (char)i;
            }
            return new string(c);
        }
    }
}
