using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            string path = @"C:\procerror.txt";    //absolute path change to work ?

            using (StreamReader sr = new StreamReader(path))
            {
                String line = sr.ReadToEnd();
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File is not found, please try again");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("The path is too long and the windows does not support it");
        }
        catch (InsufficientMemoryException)
        {
            Console.WriteLine("Mem exception?");
        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}

