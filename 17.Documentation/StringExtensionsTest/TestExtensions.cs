using System;
using System.Linq;
using StringExtensions;

namespace StringExtensionsTest
{
    class TestExtensions
    {
        static void Main(string[] args)
        {
            string testingString = "I am a student, therefore i'm poor!";

            Console.WriteLine(testingString.ToMd5Hash());
            Console.WriteLine("".ToBoolean());

            Console.WriteLine(string.Empty.ToShort());
            Console.WriteLine(testingString.ToDateTime());
            Console.WriteLine("hello world.".CapitalizeFirstLetter());

            Console.WriteLine("Здравей свят.".ConvertCyrillicToLatinLetters());
            Console.WriteLine("Zdravey svqt.".ConvertLatinToCyrillicKeyboard());

            Console.WriteLine("borisla21321(*67123)".ToValidUsername());
            Console.WriteLine("NotValid file name ***lalala*** .docx".ToValidLatinFileName());
            Console.WriteLine("Test".GetFirstCharacters(3));
            Console.WriteLine("Correct-File-Name.txt.exe".GetFileExtension());
            Console.WriteLine("hello beautiful kind world.".GetStringBetween("hello", "world"));
            Console.WriteLine("doc".ToContentType());
            
            var arr = "Hello world.".ToByteArray();
            Console.WriteLine(String.Join(" ",arr));
        }
    }
}
