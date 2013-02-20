using System;
using System.Linq;

namespace PhoneDevice
{
    public class Call
    {
        public DateTime? Date = new DateTime();

        public String DialedNumber { get; private set; }
        public ulong? Duration { get; private set; }

        public Call()
        {
            Date = null;
            DialedNumber = null;
            Duration = null;
        }
        public Call(String dialed,ulong dur)
        {
            Date = DateTime.Now;
            DialedNumber = dialed;
            Duration = dur;
        }
    }
}
