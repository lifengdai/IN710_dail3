using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrograssIndicator
{
    abstract class Subscriber
    {
        protected ProgressSubject ps;

        public Subscriber(ProgressSubject ps)
        {
            this.ps = ps;
            ps.eventHandle += new EventHandler(progress);
        }

        public abstract void progress(object o, EventArgs e);
    }
}
