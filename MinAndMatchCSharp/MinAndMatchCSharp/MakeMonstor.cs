using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinAndMatchCSharp
{
    class MakeMonstor
    {
        private HeadFactory hf;
        private BodyFactory bf;
        private LegsFactory lf;
        private string[] keys = { "fairy", "frankenstein", "skeleton", "vampire", "werewolf", "witch" };

        public MakeMonstor(ComboBox head, ComboBox body, ComboBox legs)
        {
            hf = new HeadFactory();
            bf = new BodyFactory();
            lf = new LegsFactory();

            for (int i = 0; i < keys.Length; i++)
            {
                head.Items.Add(keys[i].ToString());
                body.Items.Add(keys[i].ToString());
                legs.Items.Add(keys[i].ToString());
            }
        }

        public Monstor monstor(string head, string body, string legs)
        {
            return Monstor.create(hf.createBodyparts(head), bf.createBodyparts(body), lf.createBodyparts(legs));
        }
    }
}
