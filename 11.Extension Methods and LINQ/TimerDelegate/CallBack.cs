using System;
using System.Linq;
using System.Threading;

namespace TimerDelegate
{
    public delegate void CallBack(object state);

    public class TimerCallBack
    {
        public static void TimeNow(Object state)
        {
            Console.WriteLine(DateTime.Now);
        }

        public static void Main()
        {
            CallBack callback = new CallBack(TimeNow);
            Timer time = new Timer(callback.Invoke, null, 0, 1000);

            Console.Read(); //press enter to exit
        }
    }
}
