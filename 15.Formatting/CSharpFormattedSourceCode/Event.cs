using System;
using System.Text;

namespace CSharpFormattedSourceCode
{
    class Event : IComparable
    {
        public DateTime Date { get; set; }
        public String Title { get; set; }
        public String Location { get; set; }

        public Event(DateTime date, String title, String location)
        {
            this.Date = date;
            this.Title = title;
            this.Location = location;
        }

        public int CompareTo(object obj)
        {
            Event eventTriggerer = obj as Event;

            int byDate = this.Date.CompareTo(eventTriggerer.Date);
            int byTitle = this.Title.CompareTo(eventTriggerer.Title);
            int byLocation = this.Location.CompareTo(eventTriggerer.Location);

            if (byDate == 0)
            {
                if (byTitle == 0)
                {
                    return byLocation;
                }
                else
                {
                    return byTitle;
                }
            }
            else
            {
                return byDate;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.Date.ToString("yyyy-MM-dd - HH:mm:ss"));
            result.Append(" | " + this.Title);

            if ((this.Location != null) && (this.Location != string.Empty))
            {
                result.Append(" | " + this.Location);
            }

            return result.ToString();
        }
    }
}