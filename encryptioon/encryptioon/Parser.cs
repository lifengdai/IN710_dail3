using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptioon
{
    class Parser
    {
        private IEncryption encryptionMachine;

        public string Encrypt(string s)
        {
            return encryptionMachine.encryptString(s);
        }

        public IEncryption EncryptionMachine
        {
            get
            {
                return encryptionMachine;
            }

            set
            {
                encryptionMachine = value;
            }
        }
    }
}
