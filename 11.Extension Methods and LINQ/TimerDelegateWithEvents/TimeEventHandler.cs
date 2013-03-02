using System;
using System.Linq;
using System.Timers;

//http://msdn.microsoft.com/en-us/library/system.timers.elapsedeventargs.aspx for more info about the ElapsedEventHandler

namespace TimerDelegateWithEvents
{
    public delegate void CallBack();

    public class TimeEventHandler
    {
        public CallBack ToInvokeMethod;
        private Timer time = new Timer();

        public void Start(int ticks)
        {
            time.Elapsed += new ElapsedEventHandler(ActionEvent);
            time.Interval = ticks;
            time.Enabled = true;
        }

        public void ActionEvent(object sourse, ElapsedEventArgs e)
        {
            ToInvokeMethod.Invoke();
        }
    }
}
