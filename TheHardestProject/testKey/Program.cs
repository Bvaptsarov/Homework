using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testKey
{
    class Program
    {
     
        public static void Main(string[] args)
        {
            foreach (DictionaryEntry tests in steps)
            {
                try
                {
                    Process runCmd = new Process();
                    runCmd.StartInfo.FileName = CONSOLE_NAME;
                    runCmd.StartInfo.UseShellExecute = true;
                    runCmd.StartInfo.RedirectStandardOutput = false;
                    runCmd.StartInfo.Arguments = tests.Value.ToString();

                    if (cbShowConsole.Checked)
                    {
                        runCmd.StartInfo.CreateNoWindow = true;
                        runCmd.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    }
                    else
                    {
                        runCmd.StartInfo.CreateNoWindow = false;
                        runCmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    }
                    runCmd.Start();
                }
                catch (Exception ex)
                {
                    string t1 = ex.Message;
                }
            }
        }
    }
}
