using System;
using System.Linq;
using System.Text;

/*Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.
*/
namespace Extensions.StringBuilderExtension
{
    public static class SubStringExtention
    {
        public static String SubString(this StringBuilder str, int startIndex, int length)
        {
            StringBuilder tmp = new StringBuilder(length);
            for (int i = startIndex; i < startIndex+length; i++)
            {
                tmp.Append(str[i]);
            }
            return tmp.ToString();
        }
    }
}