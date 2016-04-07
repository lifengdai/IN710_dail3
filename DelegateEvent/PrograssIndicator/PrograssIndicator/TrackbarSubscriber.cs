using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograssIndicator
{
    class TrackbarSubscriber : Subscriber
    {
        private TrackBar tb;

        public TrackbarSubscriber(ProgressSubject ps, TrackBar tb) : base(ps)
        {
            this.tb = tb;
        }

        public override void progress(object o, EventArgs e)
        {
            tb.Value++;
        }
    }
}
