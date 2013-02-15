using System;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string downloadingPath = @"http://www.devbg.org/img/Logo-BASD.jpg";
            string saveToPath = @"E:\logo.jpg";
            using (WebClient client = new WebClient())
            {
                client.DownloadFile(downloadingPath, saveToPath);
            }
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("File not Supported exception");
        }
        catch (NotImplementedException)
        {
            Console.WriteLine("Something unpreddictable can happen all the time");
        }
        catch (WebException we)
        {
            Console.WriteLine(we.StackTrace);
        }
    }
}

