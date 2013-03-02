using System;
using System.Linq;

namespace TimerDelegateWithEvents
{
    class TestCallBack
    {
        private static TimeEventHandler invoke;

        static void Call()
        {
            invoke = new TimeEventHandler();
            invoke.ToInvokeMethod += delegate { Console.WriteLine(DateTime.Now); };
            invoke.Start(1000);//delay between the callbacks
        }

        static void Main()
        {
            Call();
            Console.Read();
        }
    }
}
