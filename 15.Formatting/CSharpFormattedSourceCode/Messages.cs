using System;
using System.Linq;
using System.Text;

namespace CSharpFormattedSourceCode
{
    static class Messages
    {
        private static readonly StringBuilder output = new StringBuilder();

        public static String Output 
        {
            get
            {
                return output.ToString();
            }
        }

        public static void EventAdded()
        {
            output.Append("Event added" + Environment.NewLine);
        }

        public static void EventDeleted(int x)
        {
            if (x == 0)
            {
                NoEventsFound();
            }
            else
            {
                output.Append(x + " events deleted" + Environment.NewLine);
            }
        }

        public static void NoEventsFound()
        {
            output.Append("No events found" + Environment.NewLine);
        }

        public static void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                output.Append(eventToPrint + Environment.NewLine);
            }
        }
    }
}
