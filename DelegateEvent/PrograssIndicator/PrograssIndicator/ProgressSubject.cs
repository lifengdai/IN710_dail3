using System;
using System.Threading;

namespace PrograssIndicator
{
    class ProgressSubject
    {
        public event EventHandler eventHandle;

        public ProgressSubject() { }

        public void SlowWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                OnUpdateEvent();
            }
        }

        private void OnUpdateEvent()
        {
            if (eventHandle != null)
                eventHandle(this, new EventArgs());
        }
    }
}
