using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograssIndicator
{
    class SpainBoxSubscriber : Subscriber
    {
        private NumericUpDown nud;
        public SpainBoxSubscriber(ProgressSubject ps, NumericUpDown nud) : base(ps)
        {
            this.nud = nud;
        }

        public override void progress(object o, EventArgs e)
        {
            nud.Value++;
            nud.Refresh();
        }
    }
}
