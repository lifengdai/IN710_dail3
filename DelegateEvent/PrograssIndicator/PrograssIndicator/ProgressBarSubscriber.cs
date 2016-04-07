using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrograssIndicator
{
    class ProgressBarSubscriber : Subscriber
    {
        private ProgressBar pb;
        public ProgressBarSubscriber(ProgressSubject ps, ProgressBar pb) : base(ps)
        {
            this.pb = pb; 
        }

        public override void progress(object o, EventArgs e)
        {
            pb.PerformStep();
        }
    }
}
