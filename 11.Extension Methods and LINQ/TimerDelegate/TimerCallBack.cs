using System;
using System.Linq;
using System.Threading;

namespace TimerDelegate
{
    public delegate void TimeDelegate(Object state);

    public class TimerCallBack
    {
        public static void TimeNow(Object state)
        {
            Console.WriteLine(DateTime.Now);
        }

        public static void Main()
        {
            TimeDelegate timerDelegate = new TimeDelegate(TimeNow);
            TimerCallback callback = new TimerCallback(timerDelegate);
            Timer time = new Timer(callback, null, 0, 1000);

            Console.Read(); //press enter to exit
        }
    }
}
