using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireAlarm
{
    class InstrctionSubscriber : Subscriber
    {
        public InstrctionSubscriber(Publisher subject) : base(subject) { }

        public override void Alarm(object o, EventArgFires e)
        {
            MessageBox.Show(e.Message, "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
