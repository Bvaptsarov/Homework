using System;
using System.Linq;

namespace PhoneDevice
{
    class GsmCallHistoryTest
    {
        public static void Main()
        {
            Gsm testObject = new Gsm("Samsung Galaxy S2", "Samsung", 250.50, "Bobi", new Battery("Hydro", -10, 120, 1), new Display("2.5\"", "16M"));
            testObject.AddCall(new Call("+35900009922", 500));
            testObject.AddCall(new Call("+3592112", 600));
            //printing call history
            testObject.GetCallHistory();
            //calc the whole sum
            Console.WriteLine("The sum is - {0}BGN",testObject.TotalPrice((decimal)0.37));
            //after removal the longest call
            testObject.RemoveCallByIndex(1); //this is the second call with index 1 (from 0 to n)
            Console.WriteLine("The sum after removal the second call(which in this case is the longest)");
            Console.WriteLine("The sum is - {0}BGN", testObject.TotalPrice((decimal)0.37));
            //printing call history
            testObject.ClearAllCalls();
            testObject.GetCallHistory();//returns nothing, emptry List
        }

    }
}
