using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDevice
{
    public class Display
    {
        public String Size { get; set; }
        public String Color { get; set; }
        public Display()
        {

            Size = null;
            Color = null;
        }
        public Display(String size, String col)
        {
            Size = size;
            Color = col;
        }
        internal string Info()
        {
            return string.Format("\nDisplay : \n\tSize - {0}\n\tColor - {1}", Size, Color);
        }
    }
}
